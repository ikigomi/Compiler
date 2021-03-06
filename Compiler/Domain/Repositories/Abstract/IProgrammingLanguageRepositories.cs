using Compiler.Domain.Entities.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Compiler.Domain.Repositories.Abstract
{
    public interface IProgrammingLanguageRepositories
    {
        public IQueryable<ProgrammingLanguage> GetLanguages();
        public ProgrammingLanguage GetLanguageById(int id);
    }
}
