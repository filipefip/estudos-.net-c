class Teacher
{
    public string Name { get; set; }
    private List<Subject> SubjectsTaught = new List<Subject>();

    public Teacher(string name)
    {
        Name = name;
    }

    public void AddSubject(Subject subject)
    {
        SubjectsTaught.Add(subject);
    }

    public void DisplaySubjects()
    {
        Console.WriteLine($"Professor: {Name}");
        Console.WriteLine("Disciplinas ministradas:");
        foreach (var subject in SubjectsTaught)
        {
            Console.WriteLine($"- {subject.Name}");
        }
    }

    public void StudentsHasSubject()
    {
        Console.WriteLine($"Professor: {Name}");
        foreach (var subject in SubjectsTaught)
        {
            subject.DisplayEnrolledStudents();
        }
    }
}