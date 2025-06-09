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
        Console.WriteLine($"{Name}: HAU HAU!");
    }
    
    public override void Move()
    {
        Console.WriteLine($"{Name} biega i macha ogonem!");
    }
}

public class Cat : Animal
{
    public Cat(string name) : base(name) { }
    
    public override void MakeSound()
    {
        Console.WriteLine($"{Name}: Miau miau~");
    }
    
    public override void Move()
    {
        Console.WriteLine($"{Name} skrada się cicho...");
    }
}

public class Bird : Animal
{
    public Bird(string name) : base(name) { }
    
    public override void MakeSound()
    {
        Console.WriteLine($"{Name}: Ćwir ćwir!");
    }
    
    public override void Move()
    {
        Console.WriteLine($"{Name} leci wysoko w niebie!");
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
        Console.WriteLine("*brzęk brzęk* Gra gitara!");
    }
}

public class Piano : IPlayable
{
    public void Play()
    {
        Console.WriteLine("*plin plon* Gra pianino!");
    }
}

public class Program
{
    public static void Main()
    {
        Console.WriteLine("=== POLIMORFIZM Z DZIEDZICZENIEM ===\n");
        
        // POLIMORFICZNA TABLICA - wszystkie elementy to "Animal", ale w rzeczywistości różne typy!
        Animal[] zwierzeta = 
        {
            new Dog("Burek"),      // Typ Dog, ale traktowany jak Animal
            new Cat("Filemon"),    // Typ Cat, ale traktowany jak Animal
            new Bird("Tweety"),    // Typ Bird, ale traktowany jak Animal
            new Dog("Azor")        // Kolejny Dog, ale też traktowany jak Animal
        };
        
        Console.WriteLine("MAGIC POLIMORFIZMU:");
        Console.WriteLine("Nie wiem jakie zwierzę, ale każde zrobi swoje!\n");
        
        // POLIMORFIZM W AKCJI - ta sama metoda, różne zachowania!
        foreach (Animal zwierze in zwierzeta)
        {
            // MAGIA POLIMORFIZMU:
            // - Kompilator widzi: Animal.MakeSound() i Animal.Move()
            // - W runtime program sprawdza prawdziwy typ obiektu
            // - Wywołuje override metodę: Dog.MakeSound(), Cat.MakeSound() itp.
            zwierze.MakeSound();   // Różne dźwięki w zależności od typu!
            zwierze.Move();        // Różne sposoby poruszania!
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
        
        Console.WriteLine("Koncert polimorficzny:");
        foreach (IPlayable instrument in instrumenty)
        {
            instrument.Play(); // Każdy instrument gra inaczej!
        }
        
        Console.WriteLine("\n=== JAK TO DZIAŁA ===");
        Console.WriteLine("1. W czasie kompilacji: 'zwierze.MakeSound()' - kompilator wie tylko że to Animal");
        Console.WriteLine("2. W czasie działania: program sprawdza prawdziwy typ obiektu");
        Console.WriteLine("3. Wywołuje odpowiednią metodę override - Dog.MakeSound(), Cat.MakeSound() itp.");
        Console.WriteLine("4. To jest POLIMORFIZM - jedno wywołanie, różne zachowania!");
        
        Console.WriteLine("\nNaciśnij cokolwiek...");
        Console.ReadKey();
    }
}