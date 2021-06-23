using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Compiler.Domain.CoreCompiler.ApiModels.Glot
{
    public class ApiModelResponse:IResult
    {
        public string Stdout { get; set; }
        public string Stderr { get; set; }
        public string Error { get; set; }

        public bool IsOk
        {
            get
            {
                return string.IsNullOrEmpty(Stderr);
            }
        }

        public string Errors
        {
            get
            {
                return string.Join("\n", Output, Stderr, Error);
            }
        }

        public string Output
        {
            get
            {
                return Stdout;
            }
        }
    }
}
