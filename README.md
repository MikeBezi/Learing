Nauka C#:
- klasy,
- biblioteka,
- listy,
- poliformizm,
- przeciążenie.

Klasa:
- abstract - klasas abstrakcyjna, nie można jej stworzyć 
public abstract class Animal  // Nie możesz: new Animal()

- sealed - nie można dziedziczyć
public sealed class Dog : Animal  // Nikt nie może dziedziczyć po Dog

- normalna(nic)

Metody:
- abstract - meotda nie ma implementacji, ale MUSI być nadpisana
public abstract class Animal
{
    public abstract void MakeSound();  // BRAK implementacji! Tylko sygnatura
    // Każde dziecko MUSI mieć swoją wersję!
}

public class Dog : Animal
{
    public override void MakeSound()  // MUSI być! Inaczej błąd kompilacji!
    {
        Console.WriteLine("HAU HAU!");
    }
}



- virtual - powoduje ze dziedziczone klasy mają "baze", ale mogą ją nadpisać
public class Animal
{
    public virtual void MakeSound()  // MA implementację
    {
        Console.WriteLine("Zwierzę robi jakiś dźwięk");  // Domyślne zachowanie
    }
}

public class Dog : Animal
{
    public override void MakeSound()  // MOŻE nadpisać (ale nie musi!)
    {
        Console.WriteLine("HAU HAU!");
    }
}

public class Fish : Animal
{
    // NIE nadpisuję MakeSound() - użyje się ta z Animal!
    // Fish będzie robić "Zwierzę robi jakiś dźwięk"
}

- normalna (nic) - można ją nadpisać ale z słówek "new", lepiej po prostu dziedziczyć - virtual