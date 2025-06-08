using System;

public class Calculator
{
    // Przeciążone metody Add - różne typy parametrów
    public int Add(int a, int b)
    {
        Console.WriteLine($"Używam wersji INT: {a} + {b}");
        return a + b;
    }
    
    public double Add(double a, double b)
    {
        Console.WriteLine($"Używam wersji DOUBLE: {a} + {b}");
        return a + b;
    }
    
    public string Add(string a, string b)
    {
        Console.WriteLine($"Używam wersji STRING: '{a}' + '{b}'");
        return a + b;
    }
    
    // Można też różną liczbę parametrów
    public int Add(int a, int b, int c)
    {
        Console.WriteLine($"Używam wersji 3 INT: {a} + {b} + {c}");
        return a + b + c;
    }
    
    // Różne typy parametrów - int i double
    public double Add(int a, double b)
    {
        Console.WriteLine($"Używam wersji INT + DOUBLE: {a} + {b}");
        return a + b;
    }
    
    // Różne typy parametrów - double i int  
    public double Add(double a, int b)
    {
        Console.WriteLine($"Używam wersji DOUBLE + INT: {a} + {b}");
        return a + b;
    }
}

public class Program
{
    public static void Main()
    {
        Calculator calc = new Calculator();
        
        Console.WriteLine("=== KOMPILATOR AUTOMATYCZNIE WYBIERA METODĘ ===\n");
        
        // Kompilator automatycznie wybierze Add(int, int)
        int result1 = calc.Add(5, 3);
        Console.WriteLine($"Wynik: {result1}\n");
        
        // Kompilator automatycznie wybierze Add(double, double)  
        double result2 = calc.Add(5.5, 3.2);
        Console.WriteLine($"Wynik: {result2}\n");
        
        // Kompilator automatycznie wybierze Add(string, string)
        string result3 = calc.Add("Hello", " World");
        Console.WriteLine($"Wynik: {result3}\n");
        
        // Kompilator automatycznie wybierze Add(int, int, int)
        int result4 = calc.Add(1, 2, 3);
        Console.WriteLine($"Wynik: {result4}\n");
        
        Console.WriteLine("=== CIEKAWOSTKI ===");
        
        // Teraz mamy precyzyjne kontrole nad typami!
        double result5 = calc.Add(5, 3.5);     // int + double → Add(int, double)
        Console.WriteLine($"Wynik: {result5}\n");
        
        double result6 = calc.Add(5.5, 3);     // double + int → Add(double, int)  
        Console.WriteLine($"Wynik: {result6}\n");
        
        double result7 = calc.Add(5.0, 3.0);   // double + double → Add(double, double)
        Console.WriteLine($"Wynik: {result7}\n");
        
        Console.WriteLine("=== JAK KOMPILATOR WYBIERA ===");
        Console.WriteLine("calc.Add(5, 3)     → szuka Add(int, int)");
        Console.WriteLine("calc.Add(5, 3.5)   → szuka Add(int, double)");  
        Console.WriteLine("calc.Add(5.5, 3)   → szuka Add(double, int)");
        Console.WriteLine("calc.Add(5.5, 3.5) → szuka Add(double, double)");
        
        Console.ReadKey();
    }
} 