using System;
using System.Runtime.CompilerServices;

public class Program
{
    public class JakisProgram
    {
        public string Name { get; set; }

        public JakisProgram(string name )
        {
            this.Name = name;
        }

        public JakisProgram()
        {
            this.Name = "Jakis Name";
        }
    }
    
    public static void Main()
    {
        int a = 5;
        int b = 5;
        int c = 0;


        Console.WriteLine("Typ wartościowy - kopia wartości");
        Console.WriteLine( "To jest ==");
        Console.WriteLine($"To jest porównanie a z b {a == b}"); //True
        Console.WriteLine($"To jest porównanie a z c {a == c}"); //False
        Console.WriteLine();
        Console.WriteLine("To jest Equals");
        Console.WriteLine($"To jest Equals a z b {a.Equals(b)}");//True
        Console.WriteLine($"To jest Equls a z c {a.Equals(c)}");//False

        Console.WriteLine();
        Console.WriteLine();

        //Tworze obiekty
        var cos = new JakisProgram();
        var cos1 = new JakisProgram();

        Console.WriteLine("Typ obiektowy - danie referencji");
        Console.WriteLine("To jest ==");
        Console.WriteLine($"To jest porównanie 2 obiektów {cos ==  cos1}");//False
        Console.WriteLine($"To jest porównanie 2 obiektów, ale name {cos.Name == cos1.Name}");//True
        Console.WriteLine();
        Console.WriteLine("To jest Equals");
        Console.WriteLine($"To jest Equals 2 obiektów {cos.Equals(cos1)}");//False a powinno być true - niby porównuje wartość obiektów?
        Console.WriteLine($"To jest Equals 2 obiektów, ale name {cos.Name.Equals(cos1.Name)}");//True - to samo co wyżej xd

        Console.WriteLine();
        Console.WriteLine();

        //a tutaj stringi
        string napis = "napis";
        string napis1 = "napis";

        Console.WriteLine("Typ string - danie kopii/ bo bez new");
        Console.WriteLine("To jest ==");
        Console.WriteLine($"To jest porównanie 2 stringow {napis == napis1}");//True
        Console.WriteLine();
        Console.WriteLine("To jest Equals");
        Console.WriteLine($"To jest Equals 2 stringow {napis.Equals(napis1)}");//True
        Console.WriteLine();
        Console.WriteLine();

        string napis2 = new string("napis");
        string napis3 = new string("napis");

        Console.WriteLine("Typ string - danie referencji");
        Console.WriteLine("To jest ==");
        Console.WriteLine($"To jest porównanie 2 stringow {napis2 == napis3}");//False
        Console.WriteLine();
        Console.WriteLine("To jest Equals");
        Console.WriteLine($"To jest Equals 2 stringow {napis2.Equals(napis3)}");//False
        Console.WriteLine();
        Console.WriteLine();

        int? proba = null;
        int? proba1 = null;
        Console.WriteLine("Typ int? - z null");
        Console.WriteLine("To jest ==");
        Console.WriteLine($"To jest porównanie 2 null {proba == proba1}");//False
        Console.WriteLine();
        Console.WriteLine("To jest Equals");
        Console.WriteLine($"To jest Equals 2 null {proba.Equals(proba1)}");//False



    }
}