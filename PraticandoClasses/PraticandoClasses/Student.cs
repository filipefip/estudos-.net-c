class Student
{
    private Dictionary<Subject, double> grades = new Dictionary<Subject, double>();
    public string Name { get; set; }
    public int Age { get; set; }

    public void EnrollSubject(Subject subject, double note)
    {
        subject.AddStudentInSubject(this);
        grades[subject] = note;
    }

    public void DisplayGrades()
    {
        Console.WriteLine($"Aluno: {Name}");
        Console.WriteLine("Notas por disciplina:");
        foreach (var entry in grades)
        {
            Console.WriteLine($"- {entry.Key.Name}: {entry.Value}");
        }
    }
}