using System;

namespace OOP
{
    class Basic_Program
    {
        static void Main(string[] args)
        {
            Animal whiskers = new Animal()
            {
                Name = "Whiskers",
                Sound = "Meao"
            };

            Dog Grover = new Dog()
            {
                Name = "Grover",
                Sound = "Woof",
                Sound2 = "Grrrr"
            };

            Animal spot = new Dog()
            {
                Name = "Spot",
                Sound = "Wooofff",
                Sound2 = "Grrrrrr"
            };

            spot.MakeSound();
            Grover.Sound = "Woooooffff";
            whiskers.MakeSound();
            Grover.MakeSound();

            whiskers.SetAnimalIDInfo(12345, "Sally Smoth");
            Grover.SetAnimalIDInfo(12346, "Paul Brown");

            whiskers.GetAnimalIDInfo();
            Grover.GetAnimalIDInfo();

            Animal.AnimalHealth getHealth = new Animal.AnimalHealth();

            Console.WriteLine("Is This animal healthty {0}", getHealth.HealthyWeight(11, 146));

            Console.ReadLine();
        }
    }
}
