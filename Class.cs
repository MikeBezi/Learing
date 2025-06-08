using System.ComponentModel.DataAnnotations;

namespace Nauka
{
 
    internal class Program
    {
        class Animal
        {
            private string Name { get; set; }
            private string Description { get; set; }
            private int Weight { get; set; }

            private int RandomNumber(int lenght)
            {
                Random random = new Random();
                return random.Next(lenght);
            }
            private string CreateName()
            {
                string[] Names = { "Stefan", "Andrzej", "Danuta", "Grażyna", "Marzena" };
                int NameNumber = RandomNumber(Names.Length);
                return Names[NameNumber];
            }

            private string CreateDesciption()
            {
                string[] Description = { "Żyrafa", "Słoń", "Pingwin", "Papuga", "Hipopotam" };
                int DescriptionNumber = RandomNumber(Description.Length);
                CreateWeight(DescriptionNumber);
                return Description[DescriptionNumber];
            }

            private void CreateWeight(int WeightsNumber)
            {
                if (this.Name[this.Name.Length - 1] == 'a')
                {
                    int[] Weights = { 50, 100, 20, 5, 120};
                    this.Weight = Weights[WeightsNumber];
                }
                else
                {
                    int[] Weights = { 80, 150, 30, 7, 180 };
                    this.Weight = Weights[WeightsNumber];
                }
            }

            public Animal()
            {
                this.Name = CreateName();
                this.Description = CreateDesciption();
                
            }

            public void Display()
            {
                Console.WriteLine($"{this.Name} to {this.Description} i ma {this.Weight} kg");
            }
        }
        class Zoo
        {
            private string NameZoo = "Pro zoo";
            private int NumberOfAniamls { get; set; }

            private List<Animal> animals = new List<Animal>();

            public void HAHAHA()
            {
                Console.WriteLine($"{NameZoo} ma {NumberOfAniamls} zwierząt!");
            }
             
            public Zoo(int Number)
            {
                this.NumberOfAniamls = Number;
                NewAniamls(Number);
            }

            public Zoo()
            {
                this.NumberOfAniamls = 30;
                NewAniamls(NumberOfAniamls);
            }

            public void  NewAniamls(int NumberAnimals)
            {
                for (int i = 0; i < NumberAnimals; i++)
                {
                    var Animal = new Animal();
                    animals.Add( Animal );
                }
            }

            public void PokaAnimals()
            {
                for (int i = 0; i < this.animals.Count; i++)
                {
                    Console.Write($"{i + 1} ");
                   this.animals[i].Display();
                }
            }



        }
        static void Main(string[] args)
        {

            var PierwszeZoo = new Zoo();
            PierwszeZoo.HAHAHA();
            PierwszeZoo.PokaAnimals();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            var DrugieZoo = new Zoo(100);
            DrugieZoo.HAHAHA();
            DrugieZoo.PokaAnimals();
        }

    }
}
