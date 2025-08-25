using System;

namespace Student_Management_System;

interface IPerson
{
    void DisplayInformation();
}


class Student : IPerson
{
    public string StudentName { get; set; }
    public int StudentID { get; set; }
    public int Age { get; set; }

    public Student(string studentName, int studentID, int age)
    {
        StudentName = studentName;
        StudentID = studentID;
        Age = age;
    }

    public virtual void DisplayInformation()
    {
        Console.WriteLine($"name: {StudentName}\nid: {StudentID}\nage: {Age}");
    }

    public Tuple<string, int, int> GetStudentInfo()
    {
        return new Tuple<string, int, int>(StudentName, StudentID, Age);
    }
}


class CollegeStudent : Student
{
    public string Subject { get; set; }
    public int Average { get; set; }

    public CollegeStudent(string studentName, int studentID, int age, string subject, int average) : base(studentName, studentID, age)
    {
        Subject = subject;
        Average = average;
    }

    public override void DisplayInformation()
    {
        base.DisplayInformation();
        Console.WriteLine($"subject: {Subject}\naverage: {Average}");
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