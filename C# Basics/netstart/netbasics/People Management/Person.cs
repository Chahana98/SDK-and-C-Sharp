// Person.cs
public class Person
{
    public int index { get; set; }
    public string userId {get; set; }
    public string firstName { get; set; }
    public string lastName { get; set; }
    public Gender sex {get; set; } 
    public string email {get; set; }
    public string phone;
    DateTime dob;
    string jobTitle;
}

public enum Gender{
    Male,
    Female,
    Others
}
