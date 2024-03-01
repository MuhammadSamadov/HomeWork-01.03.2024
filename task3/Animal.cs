namespace task3;

abstract class Animal
{
    public string? Name { get;set;}
    public void SetName(string name)
    {
        Name=name;
    }
    public virtual string GetName()
    {
        return Name;
    }
    public  abstract void Eat();
}
