
using System;

class Student
{
    public static string studentType = "Tech";
    // private string name;
    public string name;
    public string address;
    public int roll;
    public DateTime dob;

    public void PrintDetails()
    {
        Console.WriteLine($"{n
        ame} {address} {roll} {dob}");
    }

    public static void PrintStudentType()
    {
        Console.WriteLine($"Student Type: {studentType}");
    }
}