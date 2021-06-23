using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compiler.Domain.CoreCompiler.ApiModels.GeeksForGeeks
{
    public class ApiModelRequest
    {
        public Language Language { get; set; }
        public string Code { get; set; }
        public string Input { get; set; } = string.Empty;
        public bool Save { get; set; } = false;
    }
}
