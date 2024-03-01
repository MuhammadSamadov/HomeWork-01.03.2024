namespace task1;

public class Person
{
    public string? Name { get; set; }
    public Person(string name)
    {
        Name=name;
    }
    public Person(){}
    public void ToString()
    {
        System.Console.WriteLine("Enter your Info");
    }
}
