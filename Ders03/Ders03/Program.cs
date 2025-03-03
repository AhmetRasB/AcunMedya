using Ders03;

StudentManager manager = new StudentManager();

Student student = new Student()
{
    ID = "2232",
    Email = "test@gmail.com",
    Password = "123456",
    FirstName = "Ali",
    LastName = "Veli",
    StudentNumber = "123456"
};

manager.Add(student);