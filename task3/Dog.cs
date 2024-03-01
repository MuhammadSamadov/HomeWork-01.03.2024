namespace task3;

 class Dog : Animal
{
    public override string GetName()
    {
        return Name;
    }
    public override void Eat()
    {
        System.Console.WriteLine("Eating");
    }
}
