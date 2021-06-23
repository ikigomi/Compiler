using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compiler.Domain.CoreCompiler.ApiModels.GeeksForGeeks
{
    public class ApiModelResult:IResult
    {
        public string Valid { get; set; }
        public string Id { get; set; }
        public string Time { get; set; }
        public string Status { get; set; }
        public string Output { get; set; }
        public string Memory { get; set; }
        public string Hash { get; set; }
        public string CompResult { get; set; }
        public string RntError { get; set; }
        public string CmpError { get; set; }

        public bool IsOk
        {
            get 
            {
                return CompResult == "S";
            }
        }

        public string Errors
        {
            get
            {
                return RntError + '\n' + CompResult;
            }
        }
    }
}
