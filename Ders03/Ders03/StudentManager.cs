namespace Ders03;

public class StudentManager
{
    private List<Student> _students = new List<Student>();

    public void Add(Student student)
    {
        _students.Add(student);
        Console.WriteLine("Eklendi");
    }

    public List<Student> GetList()
    {
        return _students;
    }

    public Student GetByID(string id)
    {
        foreach (var student in _students)
        {
            if (student.ID == id)
            {
                return student;
            }
        }

        return null;
    }

    public void Delete(string id)
    {
        var student = GetByID(id);
        if (student != null)
        {
            _students.Remove(student);
            Console.WriteLine("Silindi");
        }
        else
        {
            Console.WriteLine("Öğrenci bulunamadı");
        }
    }
}