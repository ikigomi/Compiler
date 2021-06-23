using Compiler.Domain.Entities.Tasks;
using Compiler.Domain.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Compiler.Domain.Repositories.EntityFramework
{
    public class EFProgrammingLanguageRepositories : IProgrammingLanguageRepositories
    {
        private readonly AppDbContext context;
        public EFProgrammingLanguageRepositories(AppDbContext context)
        {
            this.context = context;
        }

        public ProgrammingLanguage GetLanguageById(int id)
        {
            return context.Languages.FirstOrDefault(x => x.Id == id);
        }

        public IQueryable<ProgrammingLanguage> GetLanguages()
        {
            return context.Languages;
        }
    }
}
