using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
namespace Nauka
{
 
    internal class Program
    {
        class Klasa
        {
            private static Dictionary<int, string> Uczniowie  = new Dictionary<int, string>();
            private string Name { get; set; }
            
            private int Age { get; set; }

            private string Class {  get; set; }
            private static int Id = 0;
            public Klasa(string name, int age, string clas)
            {
                this.Name = name;
                this.Age = age;
                this.Class = clas;
                Uczniowie.Add(Id, this.Name);
                Id++;
            }
            public void ShowUczen()
            {
                Console.WriteLine(this.Name);
                Console.WriteLine(this.Age);
                Console.WriteLine(this.Class);
                Console.WriteLine(Id);
            }

            public static void AllClass()
            {
                foreach (var item in Uczniowie)
                {
                    Console.WriteLine(item);
                }
            }
            public static void poId(int Id)
            {
                Console.WriteLine(Uczniowie[Id]);
            }
        }
      
        static void Main(string[] args)
        {

            string[] Imiona = new string[] { "Beka", "Sajmon", "Gola", "Mola", "Weronika", "Cos", "Ko", "BV", "Da" };
            int[] lata = new int[] { 16, 17, 18, 20, 21, 15, 12, 18, 20 };


            for (int i = 0; i < Imiona.Length; i++)
            {
                new Klasa(Imiona[i], lata[i], "2b");
            }

            var Uczen1 = new Klasa("Mike", 16, "3b");
           Uczen1.ShowUczen();
            Console.WriteLine();
            var Uczen2 = new Klasa("Bike", 18, "2b");
            Uczen2.ShowUczen();
            Console.WriteLine();
            Console.WriteLine();
            Klasa.AllClass();

            Klasa.poId(0);

        }



    }
}
