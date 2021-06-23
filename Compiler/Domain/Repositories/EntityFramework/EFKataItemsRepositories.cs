using Compiler.Domain.Entities.Tasks;
using Compiler.Domain.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Compiler.Domain.Repositories.EntityFramework
{
    public class EFKataItemsRepositories : IKataRepositories
    {
        private readonly AppDbContext context;

        public EFKataItemsRepositories(AppDbContext context)
        {
            this.context = context;
        }

        public void DeleteKata(int id)
        {
            context.Katas.Remove(new Kata {Id=id });
            context.SaveChanges();
        }

        public Kata GetKataById(int id)
        {
            return context.Katas.FirstOrDefault(x => x.Id == id);
        }

        public IQueryable<Kata> GetKatas()
        {
            return context.Katas;
        }

        public void SaveKata(Kata discount)
        {
            if (discount.Id == default)
                context.Entry(discount).State = EntityState.Added;
            else
                context.Entry(discount).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
