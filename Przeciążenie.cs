using System;

// PRZECIĄŻENIE METOD (METHOD OVERLOADING) - ta sama nazwa, różne parametry
public class Calculator
{
    // PRZECIĄŻONE METODY Add - kompilator wybiera na podstawie TYPÓW parametrów
    
    // WERSJA 1: dwa int'y
    public int Add(int a, int b)
    {
        Console.WriteLine($"Używam wersji INT: {a} + {b}");
        return a + b;  // Zwraca int
    }
    
    // WERSJA 2: dwa double'y - RÓŻNY TYP = INNA METODA!
    public double Add(double a, double b)
    {
        Console.WriteLine($"Używam wersji DOUBLE: {a} + {b}");
        return a + b;  // Zwraca double
    }
    
    // WERSJA 3: dwa string'i - KONKATENACJA, nie dodawanie!
    public string Add(string a, string b)
    {
        Console.WriteLine($"Używam wersji STRING: '{a}' + '{b}'");
        return a + b;  // Łączy stringi
    }
    
    // WERSJA 4: RÓŻNA LICZBA PARAMETRÓW - 3 int'y zamiast 2
    public int Add(int a, int b, int c)
    {
        Console.WriteLine($"Używam wersji 3 INT: {a} + {b} + {c}");
        return a + b + c;
    }
    
    // WERSJA 5: RÓŻNA KOLEJNOŚĆ TYPÓW - int, double
    public double Add(int a, double b)
    {
        Console.WriteLine($"Używam wersji INT + DOUBLE: {a} + {b}");
        return a + b;  // int zostanie automatycznie przekonwertowany na double
    }
    
    // WERSJA 6: RÓŻNA KOLEJNOŚĆ TYPÓW - double, int
    public double Add(double a, int b)
    {
        Console.WriteLine($"Używam wersji DOUBLE + INT: {a} + {b}");
        return a + b;  // int zostanie automatycznie przekonwertowany na double
    }
}

public class Program
{
    public static void Main()
    {
        Calculator calc = new Calculator();
        
        Console.WriteLine("=== KOMPILATOR AUTOMATYCZNIE WYBIERA METODĘ ===\n");
        
        // KOMPILATOR SPRAWDZA TYPY I AUTOMATYCZNIE WYBIERA Add(int, int)
        int result1 = calc.Add(5, 3);           // 5 i 3 to int → Add(int, int)
        Console.WriteLine($"Wynik: {result1}\n");
        
        // KOMPILATOR WIDZI .5 i .2 → to double → Add(double, double)
        double result2 = calc.Add(5.5, 3.2);   // 5.5 i 3.2 to double → Add(double, double)
        Console.WriteLine($"Wynik: {result2}\n");
        
        // KOMPILATOR WIDZI CUDZYSŁOWY → to string → Add(string, string)
        string result3 = calc.Add("Hello", " World");  // string + string → Add(string, string)
        Console.WriteLine($"Wynik: {result3}\n");
        
        // KOMPILATOR LICZY PARAMETRY: 3 int'y → Add(int, int, int)
        int result4 = calc.Add(1, 2, 3);       // 3 parametry int → Add(int, int, int)
        Console.WriteLine($"Wynik: {result4}\n");
        
        Console.WriteLine("=== CIEKAWOSTKI - KOLEJNOŚĆ TYPÓW MA ZNACZENIE ===");
        
        // PIERWSZY PARAMETR: int, DRUGI: double → Add(int, double)
        double result5 = calc.Add(5, 3.5);     // int + double → Add(int, double)
        Console.WriteLine($"Wynik: {result5}\n");
        
        // PIERWSZY PARAMETR: double, DRUGI: int → Add(double, int)
        double result6 = calc.Add(5.5, 3);     // double + int → Add(double, int)  
        Console.WriteLine($"Wynik: {result6}\n");
        
        // OBA PARAMETRY: double → Add(double, double)
        double result7 = calc.Add(5.0, 3.0);   // double + double → Add(double, double)
        Console.WriteLine($"Wynik: {result7}\n");
        
        Console.WriteLine("=== JAK KOMPILATOR WYBIERA ===");
        Console.WriteLine("calc.Add(5, 3)     → szuka Add(int, int)");
        Console.WriteLine("calc.Add(5, 3.5)   → szuka Add(int, double)");  
        Console.WriteLine("calc.Add(5.5, 3)   → szuka Add(double, int)");
        Console.WriteLine("calc.Add(5.5, 3.5) → szuka Add(double, double)");
        Console.WriteLine("\nKLUCZ: Nazwa metody + typy parametrów + kolejność = UNIKALNA SYGNATURA");
        
        Console.ReadKey();
    }
} 