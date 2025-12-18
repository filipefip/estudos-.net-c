class Subject
{
    public string Name { get; set; }
    private List<Student> EnrolledStudents = new List<Student>();

    public Subject(string name)
    {
        Name = name;
    }

    public void AddStudentInSubject(Student student)
    {
        EnrolledStudents.Add(student);
    }

    public void DisplayEnrolledStudents()
    {
        Console.WriteLine($"Disciplina: {Name}");
        Console.WriteLine("Alunos matriculados:");
        foreach (var student in EnrolledStudents)
        {
            Console.WriteLine($"- {student.Name}");
        }
    }
}