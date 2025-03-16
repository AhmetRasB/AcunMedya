using System;
using Mart1Odev.Entities;
using ProgrammingManagement.Business;
using ProgrammingManagement.DataAccess;
using ProgrammingManagement.Entities;

class Program
{
    static void Main()
    {
        var programmingLanguageService = new ProgrammingLanguageManager(new ProgrammingLanguageRepository());
        var technologyService = new TechnologyManager(new TechnologyRepository());

        Console.Write("Programlama dili giriniz: ");
        string languageName = Console.ReadLine();

        ProgrammingLanguage language = new() { Id = 1, Name = languageName };
        programmingLanguageService.Add(language);

        Console.Write("Teknoloji giriniz: ");
        string techName = Console.ReadLine();

        Technology tech = new() { Id = 1, Name = techName, ProgrammingLanguageId = 1 };
        technologyService.Add(tech);

        Console.WriteLine("\nKayıtlı Programlama Dilleri:");
        foreach (var lang in programmingLanguageService.GetAll())
            Console.WriteLine($"- {lang.Name}");

        Console.WriteLine("\nKayıtlı Teknolojiler:");
        foreach (var t in technologyService.GetAll())
            Console.WriteLine($"- {t.Name}");
    }
}