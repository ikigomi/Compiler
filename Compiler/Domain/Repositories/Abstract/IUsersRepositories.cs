using Compiler.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Compiler.Domain.Repositories.Abstract
{
    public interface IUsersRepositories
    {
        public IQueryable<ApplicationUser> GetUsers();
        public ApplicationUser GetUserByLogin(string name);
        public ApplicationUser GetUserById(string id);
    }
}
