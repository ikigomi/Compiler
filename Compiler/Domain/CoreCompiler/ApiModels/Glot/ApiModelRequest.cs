using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Compiler.Domain.CoreCompiler.ApiModels.Glot
{   
    public class ApiModelFile
    {
        public string name { get; set; }
        public string content { get; set; }
    }

    public class ApiModelRequest
    {
        public string stdin { get; set; }
        public ApiModelFile[] files { get; set; }
    }
}
