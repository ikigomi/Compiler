using Compiler.Domain.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Compiler.Domain.Repositories
{
    public class DataManager
    {
        public IKataRepositories Katas { get; set; }
        public IProgrammingLanguageRepositories Languages { get; set; }
        public ILogsRepositories Logs { get; set; }
        public IUsersRepositories Users { get; set; }
        public IAttemptsRepositories Attempts { get; set; }

        public DataManager(IKataRepositories kataRepositories, IProgrammingLanguageRepositories programmingLanguages, ILogsRepositories logs, IUsersRepositories users, IAttemptsRepositories attempts)
        {
            Katas = kataRepositories;
            Languages = programmingLanguages;
            Logs = logs;
            Attempts = attempts;
            Users = users;
            Attempts = attempts;
        }
    }
}
