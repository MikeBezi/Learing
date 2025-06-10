# 📚 Nauka C#

## 📋 Spis treści
- [Wprowadzenie](#wprowadzenie)
- [Typy klas](#typy-klas)
- [Typy metod](#typy-metod)
- [Przykłady klas](#przykłady-klas)
- [Przykłady metod](#przykłady-metod)
- [Przykłady Equals(), a ==](#equals(),-a-==)

\
---

## Wprowadzenie
Nauka C#:
- klasy,
- biblioteka,
- listy,
- poliformizm,
- przeciążenie,
- Equals.

## Typy klas
- **abstract** - klasa abstrakcyjna
- **sealed** - nie można dziedziczyć
- **normalna(nic)** - zwykła klasa

## Typy metod
- **abstract** - metoda abstrakcyjna
- **virtual** - metoda wirtualna
- **normalna (nic)** - można ją nadpisać ale z słówkiem "new", lepiej po prostu dziedziczyć - virtual

---

## Przykłady klas

### Abstract - klasa abstrakcyjna
Klasę abstrakcyjną **nie można jej stworzyć** bezpośrednio:
```csharp
public abstract class Animal  // Nie możesz: new Animal()
```

### Sealed - nie można dziedziczyć
```csharp
public sealed class Dog : Animal  // Nikt nie może dziedziczyć po Dog
```

## Przykłady metod

### Abstract - metoda bez implementacji
Metoda **nie ma implementacji**, ale **MUSI być nadpisana**:
```csharp
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
```

### Virtual - metoda z bazową implementacją
Powoduje że dziedziczone klasy mają "bazę", ale **mogą ją nadpisać**:
```csharp
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
```

###Equals(), a ==
Equals to metoda z klasy obiekt, a == to operator.