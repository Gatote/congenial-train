namespace persona;

public class Person
{
    public int Age{get;set;}
    public string Name{get;set;}
    public void SetAge(int n){
        Age=n;
    }
    public void SetName(string n){
        Name=n;
    }
    public void SayHello(){
        Console.WriteLine("Hi i'm {0}",Name);
    }
}
public class Student : Person
{
    public void GoToClasses()
    {
        Console.WriteLine("I’m going to class.");
    }
    public void ShowAge()
    {
        Console.WriteLine("My age is: {0} years old.", Age);
    }
}
public class Teacher : Person
{
    public void Explain()
    {
        Console.WriteLine("Explanation begins.");
    }
}