using Compiler.Domain.Entities.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Compiler.Models
{
    public class KataSolutionViewModel
    {
        public Kata Kata { get; set; }
        public string Code { get; set; }
        public string[] Tests { get; set; }
        public bool IsSolved { get; set; } = true;
        public bool ContainsErrors { get; set; } = false;
        public string[] Result { get; set; }
    }
}
