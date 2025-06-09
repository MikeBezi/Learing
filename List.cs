using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
namespace Nauka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // DICTIONARY - kolekcja par KLUCZ-WARTOŚĆ (jak słownik: słowo = definicja)
            Dictionary<int, string> Uczniownie = new Dictionary<int, string>();
            Uczniownie.Add(1, "Mike");    // Klucz: 1, Wartość: "Mike"
            Uczniownie.Add(2, "Piotr");   // Klucz: 2, Wartość: "Piotr"
            Uczniownie.Add(3, "Bob");     // Klucz: 3, Wartość: "Bob"

            // ITERACJA PO DICTIONARY - KeyValuePair zawiera Key i Value
            foreach (KeyValuePair<int, string> x in Uczniownie)
            {
                Console.WriteLine($"Klucz: {x.Key}, Wartość: {x.Value}");
            }
            
            // TABLICA STAŁEGO ROZMIARU - musi mieć określony rozmiar [5]
            int[] jakos = new int[5];     // Tworzy tablicę z 5 miejscami (indeksy 0-4)
            jakos[0] = 1;                 // INDEKSOWANIE od 0!
            jakos[1] = 2;
            jakos[2] = 3;
            jakos[3] = 4;
            jakos[4] = 5;
            
            // FOREACH - automatycznie przechodzi przez wszystkie elementy
            foreach (int x in jakos)
            {
                Console.WriteLine(x);     // Wypisuje: 1, 2, 3, 4, 5
            }

            // TABLICA Z INICJALIZACJĄ - rozmiar automatycznie = liczba elementów
            string[] imiona = new string[] { "Mike", "Bob", "Kowalski"};  // rozmiar = 3
            foreach (string x in imiona)
            {
                Console.WriteLine(x);     // Wypisuje wszystkie imiona
            }

            // LISTA - DYNAMICZNY ROZMIAR! Może rosnąć i maleć
            List <int> Wartosci = new List<int>();  // Pusta lista na początku
            Wartosci.Add(1);              // Dodaje element - lista rośnie!
            Wartosci.Add(2);              // Teraz ma 2 elementy
            Wartosci.Add(3);              // Teraz ma 3 elementy

            // ITERACJA PO LIŚCIE - tak samo jak po tablicy
            foreach (int x in Wartosci)
            { 
                Console.WriteLine(x);     // Wypisuje: 1, 2, 3
            }

            // RÓŻNE SPOSOBY TWORZENIA LIST

            // LISTA Z INICJALIZACJĄ - od razu z wartościami
            List<int> liczby = new List<int> { 1, 2, 3, 4, 5 };      // 5 elementów od razu
            List<string> miasta = new List<string> { "Warszawa", "Kraków", "Gdańsk" };  // 3 miasta

            // PUSTA LISTA - dodajemy elementy później
            List<string> imiona = new List<string>();

            // DODAWANIE ELEMENTÓW do pustej listy
            imiona.Add("Jan");            // Pierwszy element (indeks 0)
            imiona.Add("Anna");           // Drugi element (indeks 1)
            imiona.Add("Piotr");          // Trzeci element (indeks 2)

            // WŁAŚCIWOŚĆ Count - ile elementów ma lista (jak Length u tablic)
            Console.WriteLine($"Mam {imiona.Count} imion");  // Wypisuje: 3
            
            // DOSTĘP DO ELEMENTÓW przez indeks [0], [1], [2]...
            Console.WriteLine(imiona[0]);      // "Jan" - pierwszy element
            Console.WriteLine(imiona[1]);      // "Anna" - drugi element    
            Console.WriteLine(imiona[2]);      // "Piotr" - trzeci element

            // DOSTĘP DO OSTATNIEGO ELEMENTU - Count-1 (bo indeksy od 0!)
            Console.WriteLine(imiona[imiona.Count - 1]);  // "Piotr" - ostatni element

            // FOREACH - najłatwiejszy sposób przejścia przez wszystkie elementy
            foreach (int liczba in liczby)
            {
                Console.WriteLine(liczba);  // Wypisuje każdą liczbę
            }

            // FOR LOOP - gdy potrzebujesz indeksu elementu
            for (int i = 0; i < liczby.Count; i++)
            {
                Console.WriteLine($"Element {i}: {liczby[i]}");  // Pokazuje indeks + wartość
            }

            // STRING.JOIN - łączy wszystkie elementy w jeden string
            Console.WriteLine(string.Join(", ", liczby));  // Wypisuje: "1, 2, 3, 4, 5"
        }
    }
}
