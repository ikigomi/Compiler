using Compiler.Domain.Entities.Logs;
using Compiler.Domain.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Compiler.Domain.Repositories.EntityFramework
{
    public class EFLogsRepositories:ILogsRepositories
    {
        private readonly AppDbContext context;

        public EFLogsRepositories(AppDbContext context)
        {
            this.context = context;
        }

        public IQueryable<Logs> GetLogs()
        {
            return context.Logs;
        }

        public Logs GetLastLogs(string userId, int kataId)
        {
            return context.Logs.Where(x=>x.UserId==userId && x.KataId==kataId).OrderByDescending(x => x.Id).FirstOrDefault();
        }

        public void SaveLogs(Logs logs)
        {
            context.Entry(logs).State = EntityState.Added;
            context.SaveChanges();
        }
    }
}
