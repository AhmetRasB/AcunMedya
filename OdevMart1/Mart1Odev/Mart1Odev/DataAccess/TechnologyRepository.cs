using System.Collections.Generic;
using System.Linq;
using ProgrammingManagement.Entities;

namespace ProgrammingManagement.DataAccess
{
    public class TechnologyRepository : IRepository<Technology>
    {
        private readonly List<Technology> _technologies = new();

        public void Add(Technology entity) => _technologies.Add(entity);
        public void Update(Technology entity)
        {
            var existing = GetById(entity.Id);
            if (existing != null) existing.Name = entity.Name;
        }
        public void Delete(int id) => _technologies.RemoveAll(x => x.Id == id);
        public Technology GetById(int id) => _technologies.FirstOrDefault(x => x.Id == id);
        public List<Technology> GetAll() => _technologies;
    }
}