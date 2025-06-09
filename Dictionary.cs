using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
namespace Nauka
{
    internal class Program
    {
        // KLASA REPREZENTUJĄCA UCZNIA w systemie szkolnym
        class Klasa
        {
            // STATIC DICTIONARY - WSPÓLNA dla wszystkich obiektów Klasa!
            // Każdy obiekt może dodawać się do tej samej listy uczniów
            private static Dictionary<int, string> Uczniowie  = new Dictionary<int, string>();
            
            // PRYWATNE WŁAŚCIWOŚCI - enkapsulacja danych ucznia
            private string Name { get; set; }
            private int Age { get; set; }
            private string Class {  get; set; }
            
            // STATIC ID - automatycznie zwiększa się dla każdego nowego ucznia
            // STATIC = wspólne dla wszystkich obiektów, nie dla konkretnego obiektu
            private static int Id = 0;
            
            // KONSTRUKTOR - wywołuje się przy tworzeniu nowego ucznia: new Klasa()
            public Klasa(string name, int age, string clas)
            {
                this.Name = name;         // Ustawia imię tego konkretnego ucznia
                this.Age = age;           // Ustawia wiek tego konkretnego ucznia
                this.Class = clas;        // Ustawia klasę tego konkretnego ucznia
                
                // DODAJE UCZNIA DO STATYCZNEGO SŁOWNIKA - wszyscy uczniowie w jednym miejscu
                Uczniowie.Add(Id, this.Name);  // Klucz = Id, Wartość = Name
                Id++;                     // Zwiększa ID dla następnego ucznia (0, 1, 2, 3...)
            }
            
            // METODA INSTANCYJNA - pokazuje dane TEGO konkretnego ucznia
            public void ShowUczen()
            {
                Console.WriteLine(this.Name);   // Imię tego ucznia
                Console.WriteLine(this.Age);    // Wiek tego ucznia
                Console.WriteLine(this.Class);  // Klasa tego ucznia
                Console.WriteLine(Id);          // Aktualne ID (ostatnie użyte + 1)
            }

            // STATIC METODA - NIE POTRZEBUJE OBIEKTU! Wywołanie: Klasa.AllClass()
            public static void AllClass()
            {
                // Pokazuje WSZYSTKICH uczniów ze statycznego słownika
                foreach (var item in Uczniowie)
                {
                    Console.WriteLine(item);    // Wypisuje KeyValuePair (Id, Name)
                }
            }
            
            // STATIC METODA Z PARAMETREM - znajdź ucznia po ID
            public static void poId(int Id)
            {
                Console.WriteLine(Uczniowie[Id]);  // Dostęp do słownika przez klucz [Id]
            }
        }
      
        static void Main(string[] args)
        {
            // TABLICE DANYCH - przygotowanie danych do automatycznego tworzenia uczniów
            string[] Imiona = new string[] { "Beka", "Sajmon", "Gola", "Mola", "Weronika", "Cos", "Ko", "BV", "Da" };
            int[] lata = new int[] { 16, 17, 18, 20, 21, 15, 12, 18, 20 };

            // AUTOMATYCZNE TWORZENIE UCZNIÓW w pętli
            for (int i = 0; i < Imiona.Length; i++)
            {
                // Tworzy nowy obiekt Klasa z i-tym imieniem, i-tym wiekiem, klasa "2b"
                new Klasa(Imiona[i], lata[i], "2b");  // Każdy uczen automatycznie dodaje się do słownika!
                // Uwaga: nie zapisujemy referencji - obiekt istnieje, ale nie mamy do niego dostępu
            }

            // RĘCZNE TWORZENIE UCZNIÓW - zachowujemy referencje w zmiennych
            var Uczen1 = new Klasa("Mike", 16, "3b");   // var = kompilator automatycznie rozpozna typ
           Uczen1.ShowUczen();    // Wywołuje metodę instancyjną na konkretnym obiekcie
            Console.WriteLine();
            
            var Uczen2 = new Klasa("Bike", 18, "2b");   // Kolejny uczeń, kolejne ID
            Uczen2.ShowUczen();
            Console.WriteLine();
            Console.WriteLine();
            
            // WYWOŁANIE STATIC METOD - NIE POTRZEBA OBIEKTU!
            Klasa.AllClass();     // Pokazuje WSZYSTKICH uczniów (z pętli + ręcznych)

            Klasa.poId(0);        // Pokazuje pierwszego ucznia (Id = 0)
        }
    }
}
