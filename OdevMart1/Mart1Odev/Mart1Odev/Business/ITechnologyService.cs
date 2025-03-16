using System.Collections.Generic;
using ProgrammingManagement.Entities;

namespace ProgrammingManagement.Business
{
    public interface ITechnologyService
    {
        void Add(Technology tech);
        void Update(Technology tech);
        void Delete(int id);
        Technology GetById(int id);
        List<Technology> GetAll();
    }
}