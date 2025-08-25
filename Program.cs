using System;

namespace Student_Management_System;

interface IPerson
{
    void DisplayInformation();
}


class Student : IPerson
{
    // Fields
    protected string _studentName;
    protected int _studentID;
    protected int _age;

    // Properties
    public string StudentName
    {
        get { return _studentName; }
        set { _studentName = value; }
    }
    
    public int StudentID
    {
        get { return _studentID; }
        set { _studentID = value; }
    }
    
    public int Age
    {
        get { return _age; }
        set { _age = value; }
    }

    public Student(string studentName, int studentID, int age)
    {
        _studentName = studentName;
        _studentID = studentID;
        _age = age;
    }

    public virtual void DisplayInformation()
    {
        Console.WriteLine($"name: {_studentName}\nid: {_studentID}\nage: {_age}");
    }

    public Tuple<string, int, int> GetStudentInfo()
    {
        return new Tuple<string, int, int>(StudentName, StudentID, Age);
    }
}


class CollegeStudent : Student
{
    // Fields
    private string _subject;
    private int _average;

    // Properties
    public string Subject
    {
        get { return _subject; }
        set { _subject = value; }
    }
    
    public int Average
    {
        get { return _average; }
        set { _average = value; }
    }

    public CollegeStudent(string studentName, int studentID, int age, string subject, int average) : base(studentName, studentID, age)
    {
        _subject = subject;
        _average = average;
    }

    public override void DisplayInformation()
    {
        base.DisplayInformation();
        Console.WriteLine($"subject: {_subject}\naverage: {_average}");
    }
}


public class Program
{
    public static void Main(string[] args)
    {
        Student student1 = new CollegeStudent("Dani", 123, 17, "Computer Science", 97);
        student1.StudentID = 1234;
        student1.DisplayInformation();
    }
}