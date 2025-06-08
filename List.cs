using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
namespace Nauka
{
 
    internal class Program
    {
      
        static void Main(string[] args)
        {
            Dictionary<int, string> Uczniownie = new Dictionary<int, string>();
            Uczniownie.Add(1, "Mike");
            Uczniownie.Add(2, "Piotr");
            Uczniownie.Add(3, "Bob");

            foreach (KeyValuePair<int, string> x in Uczniownie)
            {
                Console.WriteLine($"Klucz: {x.Key}, Wartość: {x.Value}");
            }
            int[] jakos = new int[5];
            jakos[0] = 1;
            jakos[1] = 2;
            jakos[2] = 3;
            jakos[3] = 4;
            jakos[4] = 5;
            foreach (int x in jakos)
            {
                Console.WriteLine(x);
            }

            string[] imiona = new string[] { "Mike", "Bob", "Kowalski"};
            foreach (string x in imiona)
            {
                Console.WriteLine(x);
            }

            List <int> Wartosci = new List<int>();
            Wartosci.Add(1);
            Wartosci.Add(2);
            Wartosci.Add(3);

            foreach (int x in Wartosci)
            { 
                Console.WriteLine(x); 
            }
        }

    }
}
