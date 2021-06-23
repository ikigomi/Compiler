using Compiler.Domain.CoreCompiler.ApiModels;
using Compiler.Domain.CoreCompiler.ApiModels.GeeksForGeeks;
using Compiler.Domain.CoreCompiler.ApiModels.Glot;
using Compiler.Domain.Entities.Logs;
using Compiler.Domain.Entities.Tasks;
using Compiler.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using xNet;

namespace Compiler.Domain.CoreCompiler
{
    public static class CoreCompiler
    {
        private static KataSolutionViewModel solution = new KataSolutionViewModel();

        public static KataSolutionViewModel Solve(string code, Kata kata)
        {
            solution.Kata = kata;
            solution.Code = code;
            solution.IsSolved = true;
            solution.ContainsErrors = false;

            List<string> result = new List<string>();
            List<string> testsResult = new List<string>();
            if (code == null)
                result.Add("Введите код для компиляции");
            else
            {
                ParallelOptions options = new ParallelOptions();
                options.MaxDegreeOfParallelism = 4;
                // типо многопоток для ускорения 
                //Parallel.For(0, kata.InputData.Length, options, (i, state) =>
                //{
                //    string res = $"Тест {i + 1}\n";
                //    var compileResult = CompileGlot(code, kata.InputData[i].Replace(',', '\n'), (Language)kata.Language.Id);
                //    Console.WriteLine("compileResult.IsOk\t" + compileResult.IsOk);
                //    Console.WriteLine("compileResult.Errors\t" + compileResult.Errors);
                //    Console.WriteLine("compileResult.Output\t" + compileResult.Output);
                //    if (!compileResult.IsOk)
                //    {
                //        solution.IsSolved = false;
                //        solution.ContainsErrors = true;
                //        if (!result.Contains(compileResult.Errors))
                //            result.Add(compileResult.Errors);
                //        state.Break();
                //    }
                //    else
                //    {

                //        solution.IsSolved = solution.IsSolved ? compileResult.Output.Trim('\n') == kata.OutputData[i].Trim() : false;
                //        testsResult.Add($"[Тест {i + 1}: {(compileResult.Output.Trim('\n') == kata.OutputData[i].Trim() ? "Пройден" : "Не пройден")}]");
                //        res += $"Вывод: {compileResult.Output}";
                //        res += "\n\n";
                //        result.Add(res);
                //    }
                //});
                for (int i = 0; i < kata.InputData.Length; i++)
                {
                    string res = $"Тест {i + 1}\n";
                    var compileResult = CompileGlot(code, kata.InputData[i].Replace(',', '\n'), (Language)kata.Language.Id);
                    Console.WriteLine("compileResult.IsOk\t" + compileResult.IsOk);
                    Console.WriteLine("compileResult.Errors\t" + compileResult.Errors);
                    Console.WriteLine("compileResult.Output\t" + compileResult.Output);
                    if (!compileResult.IsOk)
                    {
                        solution.IsSolved = false;
                        solution.ContainsErrors = true;
                        if (!result.Contains(compileResult.Errors))
                            result.Add(compileResult.Errors);
                        break;
                    }
                    else
                    {

                        solution.IsSolved = solution.IsSolved ? compileResult.Output.Trim('\n') == kata.OutputData[i].Trim() : false;
                        testsResult.Add($"[Тест {i + 1}: {(compileResult.Output.Trim('\n') == kata.OutputData[i].Trim() ? "Пройден" : "Не пройден")}]");
                        res += $"Вывод: {compileResult.Output}";
                        res += "\n\n";
                        result.Add(res);
                    }
                }


            }

            solution.Tests = testsResult.ToArray();
            solution.Result = result.ToArray();
            return solution;
        }

        private static ApiModelResult CompileGeeksForGeeks(string code, string input, Language lang)
        {
            ApiModelResult result;

            string compilerUrl = "https://ide.geeksforgeeks.org/main.php";
            string resultUrl = "https://ide.geeksforgeeks.org/submissionResult.php";


            using (var request = new HttpRequest())
            {

                var data = new ApiModels.GeeksForGeeks.ApiModelRequest
                {
                    Language = lang,
                    Code = code,
                    Input = input
                };

                var statusResponse = request.Post(compilerUrl, $"lang={data.Language}&code={data.Code}&input={data.Input}&save={data.Save.ToString().ToLower()}", "application/x-www-form-urlencoded; charset=UTF-8").ToString();
                var status = JsonConvert.DeserializeObject<ApiModelStatus>(statusResponse);

                do
                {
                    var compilerResult = request.Post(resultUrl, $"sid={status.Sid}&requestType=fetchResults", "application/x-www-form-urlencoded; charset=UTF-8").ToString();
                    result = JsonConvert.DeserializeObject<ApiModelResult>(compilerResult);
                } while (result.Status.ToLower() == "IN-QUEUE".ToLower());
            }
            return result;
        }

        private static ApiModelResponse CompileGlot(string code, string input, Language lang)
        {
            if (lang == Language.Python3)
                lang = Language.Python;
            

            ApiModelResponse result;

            string url = $"https://run.glot.io/languages/{lang.ToString().ToLower()}/latest";

            var request = new HttpClient();

            request.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Token", "24d3af1e-5d44-47dc-8aab-1110eae8140a");

            var files = new ApiModelFile[1];
            files[0] = new ApiModelFile { name = lang.ToString(), content = code };

            var data = new ApiModels.Glot.ApiModelRequest
            {
                stdin = input,
                files = files
            };

            var json = JsonConvert.SerializeObject(data);

            var content = new System.Net.Http.StringContent(JsonConvert.SerializeObject(data), Encoding.UTF8, "application/json");


            result = JsonConvert.DeserializeObject<ApiModelResponse>(request.PostAsync(url, content).Result.Content.ReadAsStringAsync().Result);
        
            return result;
        }
    }
}
