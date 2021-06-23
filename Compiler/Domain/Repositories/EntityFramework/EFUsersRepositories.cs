using Compiler.Domain.Entities;
using Compiler.Domain.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Compiler.Domain.Repositories.EntityFramework
{
    public class EFUsersRepositories : IUsersRepositories
    {
        private readonly AppDbContext context;
        public EFUsersRepositories(AppDbContext context)
        {
            this.context = context;
        }

        public ApplicationUser GetUserById(string id)
        {
            return context.Users.FirstOrDefault(x => x.Id == id);
        }

        public ApplicationUser GetUserByLogin(string name)
        {
            return context.Users.FirstOrDefault(x => x.UserName == name);
        }

        public IQueryable<ApplicationUser> GetUsers()
        {
            return context.Users;
        }

    }
}
