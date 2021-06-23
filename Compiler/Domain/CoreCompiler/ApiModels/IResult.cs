using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Compiler.Domain.CoreCompiler.ApiModels
{
    interface IResult
    {
        public bool IsOk { get; }
        public string Errors { get; }
        public string Output { get; }
    }
}
