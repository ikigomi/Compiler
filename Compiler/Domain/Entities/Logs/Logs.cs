using Compiler.Domain.Entities.Tasks;

namespace Compiler.Domain.Entities.Logs
{
    public class Logs
    {
        public int Id { get; set; }
        public string Code { get; set; }

        public int KataId { get; set; }
        public Kata Kata { get; set; }

        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
    }
}
