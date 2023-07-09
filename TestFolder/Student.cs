using System;
namespace Test;
public class Student
{
    public int StudentId { get; set;}

    public string FirstName { get; set;}

    public string LastName { get; set;}

    public string FullName {get; private set;} = $"{FirstName} {LastName}";
}