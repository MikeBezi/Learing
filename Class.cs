using System.ComponentModel.DataAnnotations;

namespace Nauka
{
    internal class Program
    {
        // KLASA ANIMAL - przykład enkapsulacji (private properties)
        class Animal
        {
            // ENKAPSULACJA - prywatne właściwości, dostęp tylko przez metody klasy
            private string Name { get; set; }
            private string Description { get; set; }
            private int Weight { get; set; }

            // METODA PRYWATNA - generuje losową liczbę w zakresie 0 do length-1
            private int RandomNumber(int lenght)
            {
                Random random = new Random();
                return random.Next(lenght);  // Next(5) = 0,1,2,3 lub 4
            }
            
            // GENERATOR IMION - wybiera losowe imię z tablicy
            private string CreateName()
            {
                string[] Names = { "Stefan", "Andrzej", "Danuta", "Grażyna", "Marzena" };
                int NameNumber = RandomNumber(Names.Length);  // 0-4
                return Names[NameNumber];
            }

            // GENERATOR OPISÓW - wybiera losowy gatunek zwierzęcia
            private string CreateDesciption()
            {
                string[] Description = { "Żyrafa", "Słoń", "Pingwin", "Papuga", "Hipopotam" };
                int DescriptionNumber = RandomNumber(Description.Length);
                CreateWeight(DescriptionNumber);  // WYWOŁUJE METODĘ ustawiania wagi
                return Description[DescriptionNumber];
            }

            // LOGIKA BIZNESOWA - różne wagi dla różnych płci (końcówka imienia)
            private void CreateWeight(int WeightsNumber)
            {
                // SPRAWDZA PŁEĆ po ostatniej literze imienia (a = kobieta)
                if (this.Name[this.Name.Length - 1] == 'a')
                {
                    int[] Weights = { 50, 100, 20, 5, 120};  // Wagi dla kobiet
                    this.Weight = Weights[WeightsNumber];
                }
                else
                {
                    int[] Weights = { 80, 150, 30, 7, 180 }; // Wagi dla mężczyzn (cięższe!)
                    this.Weight = Weights[WeightsNumber];
                }
            }

            // KONSTRUKTOR - wywołuje się automatycznie przy tworzeniu obiektu: new Animal()
            public Animal()
            {
                this.Name = CreateName();        // Najpierw imię (potrzebne dla wagi!)
                this.Description = CreateDesciption(); // Potem opis (który ustawi wagę)
            }

            // METODA PUBLICZNA - jedyny sposób żeby "zobaczyć" prywatne dane
            public void Display()
            {
                Console.WriteLine($"{this.Name} to {this.Description} i ma {this.Weight} kg");
            }
        }
        
        // KLASA ZOO - zarządza kolekcją zwierząt
        class Zoo
        {
            private string NameZoo = "Pro zoo";             // POLE - stała nazwa zoo
            private int NumberOfAniamls { get; set; }       // WŁAŚCIWOŚĆ - liczba zwierząt

            // KOLEKCJA - przechowuje wiele obiektów Animal
            private List<Animal> animals = new List<Animal>();

            // METODA INFORMACYJNA - pokazuje podstawowe info o zoo
            public void HAHAHA()
            {
                Console.WriteLine($"{NameZoo} ma {NumberOfAniamls} zwierząt!");
            }
             
            // KONSTRUKTOR Z PARAMETREM - pozwala ustawić liczbę zwierząt
            public Zoo(int Number)
            {
                this.NumberOfAniamls = Number;
                NewAniamls(Number);  // Tworzy określoną liczbę zwierząt
            }

            // KONSTRUKTOR DOMYŚLNY - bez parametrów, tworzy 30 zwierząt
            public Zoo()
            {
                this.NumberOfAniamls = 30;
                NewAniamls(NumberOfAniamls);
            }

            // FACTORY METHOD - tworzy określoną liczbę zwierząt i dodaje do listy
            public void  NewAniamls(int NumberAnimals)
            {
                for (int i = 0; i < NumberAnimals; i++)
                {
                    var Animal = new Animal();  // Każdy animal ma losowe dane!
                    animals.Add( Animal );      // Dodaje do kolekcji
                }
            }

            // ITERACJA PO KOLEKCJI - pokazuje wszystkie zwierzęta z numeracją
            public void PokaAnimals()
            {
                for (int i = 0; i < this.animals.Count; i++)
                {
                    Console.Write($"{i + 1} ");      // Numeracja od 1
                   this.animals[i].Display();       // Wywołuje metodę Display() każdego zwierzęcia
                }
            }
        }
        
        // PUNKT WEJŚCIA PROGRAMU
        static void Main(string[] args)
        {
            // TWORZENIE OBIEKTU przez konstruktor domyślny (30 zwierząt)
            var PierwszeZoo = new Zoo();
            PierwszeZoo.HAHAHA();      // Info o zoo
            PierwszeZoo.PokaAnimals(); // Lista wszystkich zwierząt

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            
            // TWORZENIE OBIEKTU przez konstruktor z parametrem (100 zwierząt)
            var DrugieZoo = new Zoo(100);
            DrugieZoo.HAHAHA();
            DrugieZoo.PokaAnimals();
        }
    }
}
