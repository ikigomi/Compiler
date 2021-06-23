using Compiler.Domain.Entities.Logs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Compiler.Domain.Repositories.Abstract
{
    public interface ILogsRepositories
    {
        public IQueryable<Logs> GetLogs();
        public Logs GetLastLogs(string userId, int kataId);
        public void SaveLogs(Logs logs);
    }
}
