using System.Collections.Generic;
using ProgrammingManagement.DataAccess;
using ProgrammingManagement.Entities;

namespace ProgrammingManagement.Business
{
    public class TechnologyManager : ITechnologyService
    {
        private readonly IRepository<Technology> _repository;

        public TechnologyManager(IRepository<Technology> repository)
        {
            _repository = repository;
        }

        public void Add(Technology tech) => _repository.Add(tech);
        public void Update(Technology tech) => _repository.Update(tech);
        public void Delete(int id) => _repository.Delete(id);
        public Technology GetById(int id) => _repository.GetById(id);
        public List<Technology> GetAll() => _repository.GetAll();
    }
}