using System.Collections.Generic;
using Mart1Odev.Entities;
using ProgrammingManagement.Entities;

namespace ProgrammingManagement.Business
{
    public interface IProgrammingLanguageService
    {
        void Add(ProgrammingLanguage language);
        void Update(ProgrammingLanguage language);
        void Delete(int id);
        ProgrammingLanguage GetById(int id);
        List<ProgrammingLanguage> GetAll();
    }
}