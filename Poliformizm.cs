using System;

// POLIMORFIZM - jedna metoda, różne zachowania w czasie działania programu

// Klasa bazowa z metodą virtual
public class Animal
{
    public string Name { get; set; }
    
    public Animal(string name)
    {
        Name = name;
    }
    
    // virtual = może być nadpisana w klasach pochodnych
    public virtual void MakeSound()
    {
        Console.WriteLine($"{Name}: *jakaś zwierzęca cisza*");
    }
    
    public virtual void Move()
    {
        Console.WriteLine($"{Name} porusza się");
    }
}

// Klasy pochodne z override
public class Dog : Animal
{
    public Dog(string name) : base(name) { }
    
    public override void MakeSound()
    {
        Console.WriteLine($"{Name}: HAU HAU! 🐕");
    }
    
    public override void Move()
    {
        Console.WriteLine($"{Name} biega i macha ogonem! 🏃‍♂️");
    }
}

public class Cat : Animal
{
    public Cat(string name) : base(name) { }
    
    public override void MakeSound()
    {
        Console.WriteLine($"{Name}: Miau miau~ 🐱");
    }
    
    public override void Move()
    {
        Console.WriteLine($"{Name} skrada się cicho... 🐾");
    }
}

public class Bird : Animal
{
    public Bird(string name) : base(name) { }
    
    public override void MakeSound()
    {
        Console.WriteLine($"{Name}: Ćwir ćwir! 🐦");
    }
    
    public override void Move()
    {
        Console.WriteLine($"{Name} leci wysoko w niebie! 🕊️");
    }
}

// Przykład z interfejsem - też polimorfizm!
public interface IPlayable
{
    void Play();
}

public class Guitar : IPlayable
{
    public void Play()
    {
        Console.WriteLine("🎸 *brzęk brzęk* Gra gitara!");
    }
}

public class Piano : IPlayable
{
    public void Play()
    {
        Console.WriteLine("🎹 *plin plon* Gra pianino!");
    }
}

public class Program
{
    public static void Main()
    {
        Console.WriteLine("=== POLIMORFIZM Z DZIEDZICZENIEM ===\n");
        
        // Tworzymy tablicę zwierząt - polimorfizm!
        Animal[] zwierzeta = 
        {
            new Dog("Burek"),
            new Cat("Filemon"), 
            new Bird("Tweety"),
            new Dog("Azor")
        };
        
        Console.WriteLine("🔥 MAGIC POLIMORFIZMU:");
        Console.WriteLine("Nie wiem jakie zwierzę, ale każde zrobi swoje!\n");
        
        // POLIMORFIZM W AKCJI - ta sama metoda, różne zachowania!
        foreach (Animal zwierze in zwierzeta)
        {
            // Kompilator nie wie który typ, ale w runtime wywoła właściwą metodę!
            zwierze.MakeSound();
            zwierze.Move();
            Console.WriteLine();
        }
        
        Console.WriteLine("=== POLIMORFIZM Z INTERFEJSAMI ===\n");
        
        // Polimorfizm przez interfejsy
        IPlayable[] instrumenty = 
        {
            new Guitar(),
            new Piano(),
            new Guitar()
        };
        
        Console.WriteLine("🎵 Koncert polimorficzny:");
        foreach (IPlayable instrument in instrumenty)
        {
            instrument.Play(); // Każdy instrument gra inaczej!
        }
        
        Console.WriteLine("\n=== JAK TO DZIAŁA ===");
        Console.WriteLine("1. W czasie kompilacji: 'zwierze.MakeSound()' - kompilator wie tylko że to Animal");
        Console.WriteLine("2. W czasie działania: program sprawdza prawdziwy typ obiektu");
        Console.WriteLine("3. Wywołuje odpowiednią metodę override - Dog.MakeSound(), Cat.MakeSound() itp.");
        Console.WriteLine("4. To jest POLIMORFIZM - jedno wywołanie, różne zachowania! 🎯");
        
        Console.WriteLine("\nNaciśnij cokolwiek...");
        Console.ReadKey();
    }
}