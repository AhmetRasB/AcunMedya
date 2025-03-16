using System.Collections.Generic;
using System.Linq;
using Mart1Odev.Entities;
using ProgrammingManagement.Entities;

namespace ProgrammingManagement.DataAccess
{
    public class ProgrammingLanguageRepository : IRepository<ProgrammingLanguage>
    {
        private readonly List<ProgrammingLanguage> _languages = new();

        public void Add(ProgrammingLanguage entity) => _languages.Add(entity);
        public void Update(ProgrammingLanguage entity)
        {
            var existing = GetById(entity.Id);
            if (existing != null) existing.Name = entity.Name;
        }
        public void Delete(int id) => _languages.RemoveAll(x => x.Id == id);
        public ProgrammingLanguage GetById(int id) => _languages.FirstOrDefault(x => x.Id == id);
        public List<ProgrammingLanguage> GetAll() => _languages;
    }
}