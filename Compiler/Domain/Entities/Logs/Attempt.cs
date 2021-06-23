using Compiler.Domain.Entities.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Compiler.Domain.Entities.Logs
{
    public class Attempt
    {
        public int Id { get; set; }
        public int MaxAttempts { get; set; } = 5;
        public int CurrentAttempts { get; set; } = 0;
        public bool IsSolved { get; set; } = false;

        public int KataId { get; set; }
        public Kata Kata { get; set; }

        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
    }
}
