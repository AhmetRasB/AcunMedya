using System.Collections.Generic;
using Mart1Odev.Entities;
using ProgrammingManagement.DataAccess;
using ProgrammingManagement.Entities;

namespace ProgrammingManagement.Business
{
    public class ProgrammingLanguageManager : IProgrammingLanguageService
    {
        private readonly IRepository<ProgrammingLanguage> _repository;

        public ProgrammingLanguageManager(IRepository<ProgrammingLanguage> repository)
        {
            _repository = repository;
        }

        public void Add(ProgrammingLanguage language) => _repository.Add(language);
        public void Update(ProgrammingLanguage language) => _repository.Update(language);
        public void Delete(int id) => _repository.Delete(id);
        public ProgrammingLanguage GetById(int id) => _repository.GetById(id);
        public List<ProgrammingLanguage> GetAll() => _repository.GetAll();
    }
}