class Animal
{
    // Herança
    protected string Name { get; set; }
    public Animal(string name)
    {
        Name = name;
    }
    public void Eat()
    {
        Console.WriteLine($"{Name} está comendo.");
    }

    // Plimorfismo
    public virtual void MakeSound()
    {
        Console.WriteLine("O animal faz algum som.");
    }
}

class Cat : Animal
{
    // Herança
    public Cat(string name) : base(name)
    {
    }

    public void Meow()
    {
        Console.WriteLine($"{Name} está miando.");
    }

    // Plimorfismo
    public override void MakeSound()
    {
        Console.WriteLine("O gato faz 'Miau!'");
    }
}

class Dog : Animal
{
    // Herança
    public Dog(string name) : base(name)
    {
    }
    public void Bark()
    {
        Console.WriteLine($"{Name} está latindo.");
    }

    // Polimorfismo
    public override void MakeSound()
    {
        Console.WriteLine("O cachorro faz 'Au Au!'");
    }
}