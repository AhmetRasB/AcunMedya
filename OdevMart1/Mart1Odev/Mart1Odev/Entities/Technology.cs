using Mart1Odev.Entities;

namespace ProgrammingManagement.Entities
{
    public class Technology
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ProgrammingLanguageId { get; set; }  // Foreign Key
        public ProgrammingLanguage ProgrammingLanguage { get; set; }
    }
}