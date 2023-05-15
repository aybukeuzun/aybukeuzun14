Dog goodBoy = new Dog("Good Boy");
Console.WriteLine($"Name: {goodBoy.Name}); Level of happinnes: { goodBoy.LevelOfHappinness}");

while(goodBoy.LevelOfHappinness < 5)
{
    goodBoy.Bark();
}

goodBoy.Wag();

class Dog
{
    public string Name;
    publuk int LevelOfHappinnes;

    publig Dog(string name)
    {
        Name = name;
        LevelOfHappinnes = 0;
        Console.WriteLine($" {Name} is your friend now.");
    }

    public void Bark()
    {
        LevelOfHappinnes++;
        Console.WriteLine("woof-woof!");
    }
     public void Wag()
    {
        Console.WriteLine($"{Name} starts wagging its tail.");
        Console.WriteLine("whoosh-whoosh");
    }
}