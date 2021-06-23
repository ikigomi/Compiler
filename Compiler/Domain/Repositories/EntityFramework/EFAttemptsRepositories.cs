using Compiler.Domain.Entities.Logs;
using Compiler.Domain.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Compiler.Domain.Repositories.EntityFramework
{
    public class EFAttemptsRepositories : IAttemptsRepositories
    {
        private readonly AppDbContext context;

        public EFAttemptsRepositories(AppDbContext context)
        {
            this.context = context;
        }

        public void IncreaseMaxAttemptsNumber(string userId, int kataId, int number)
        {
            var attempt = GetAttempt(userId, kataId);
            attempt.MaxAttempts += number;
            context.SaveChanges();
        }

        public IQueryable<Attempt> GetAttempts()
        {
            return context.Attempts;
        }

        public Attempt GetAttempt(string userId, int kataId)
        {
            return context.Attempts.Where(x => x.UserId == userId && x.KataId == kataId).OrderByDescending(x => x.Id).FirstOrDefault();
        }

        public void IncrementCurrentAttempt(string userId, int kataId, bool isSolved)
        {
            var attempt = GetAttempt(userId, kataId);

            if (attempt == null)
            {
                attempt = new Attempt
                {
                    KataId=kataId,
                    UserId=userId,                    
                    IsSolved = isSolved
                };
                attempt.CurrentAttempts++;
                context.Attempts.Add(attempt);
            }
            else
            {
                attempt.IsSolved |= isSolved;
                attempt.CurrentAttempts++;
            }

            context.SaveChanges();
        }
    }
}
