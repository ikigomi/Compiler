using Compiler.Domain.CoreCompiler.ApiModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Compiler.Domain.Entities.Tasks
{
    public class ProgrammingLanguage
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
