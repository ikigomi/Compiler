using Compiler.Domain.Entities.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Compiler.Models
{
    public class HomeViewModel
    {
        public IQueryable<Kata> Katas { get; set; }
        public IQueryable<ProgrammingLanguage> Languages { get; set; }
    }
}
