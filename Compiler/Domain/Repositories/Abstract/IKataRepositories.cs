using Compiler.Domain.Entities.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Compiler.Domain.Repositories.Abstract
{
    public interface IKataRepositories
    {
        public IQueryable<Kata> GetKatas();
        public Kata GetKataById(int id);
        public void DeleteKata(int id);
        public void SaveKata(Kata kata);
    }
}
