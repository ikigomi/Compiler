using Compiler.Domain.Entities.Logs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Compiler.Domain.Repositories.Abstract
{
    public interface IAttemptsRepositories
    {
        public IQueryable<Attempt> GetAttempts();
        public Attempt GetAttempt(string userId, int kataId);
        public void IncreaseMaxAttemptsNumber(string userId, int kataId, int number);
        public void IncrementCurrentAttempt(string userId, int kataId, bool isSolved);
    }
}
