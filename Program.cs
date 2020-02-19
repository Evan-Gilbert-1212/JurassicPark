using System;
using System.Collections.Generic;

namespace JurassicPark
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();
      Console.WriteLine("Welcome to Jurassic Park Dinosaur Manager!");
      Console.WriteLine();

      var isRunning = true;

      var dinosaurManager = new DinosaurManager();

      while (isRunning)
      {
        Console.WriteLine("What task would you like to perform? You can:");
        Console.WriteLine("(VIEW) all dinosaurs in the park");
        Console.WriteLine("(ADD) a new dinosaur to the park");
        Console.WriteLine("(REMOVE) a dinosaur from the park");
        Console.WriteLine("(TRANSFER) a dinosaur to a new enclosure");
        Console.WriteLine("(HEAVIEST) see the 3 heaviest dinosaurs in the park");
        Console.WriteLine("(DIET) see the summary of all dinosaurs diets");
        Console.WriteLine("(QUIT) exit the program");

        var userResponse = Console.ReadLine().ToLower();

        while (userResponse != "view" && userResponse != "add" && userResponse != "remove" && userResponse != "transfer"
               && userResponse != "heaviest" && userResponse != "diet" && userResponse != "quit")
        {
          Console.WriteLine("Please enter a valid task. Available tasks are:");
          Console.WriteLine("(VIEW), (ADD), (REMOVE), (TRANSFER), (HEAVIEST), (DIET), (QUIT).");

          userResponse = Console.ReadLine().ToLower();
        }

        switch (userResponse)
        {
          case "view":
            dinosaurManager.ViewDinosaurs();
            break;
          case "add":
            Console.WriteLine("What is the dinosaurs name?");
            var dinosaurName = Console.ReadLine();

            Console.WriteLine("What is the dinosaurs diet? (CARNIVORE) or (HERBIVORE)?");
            var dinosaurDiet = Console.ReadLine().ToUpper();

            while (dinosaurDiet != "CARNIVORE" && dinosaurDiet != "HERBIVORE")
            {
              Console.WriteLine("Please enter a valid diet type. Valid diet types are: (CARNIVORE) and (HERBIVORE).");

              dinosaurDiet = Console.ReadLine().ToUpper();
            }

            Console.WriteLine("What is the dinosaurs weight?");
            var dinosaurWeight = Console.ReadLine();
            var intDinosaurWeight = 0;

            while (!Int32.TryParse(dinosaurWeight, out intDinosaurWeight))
            {
              Console.WriteLine("Please enter a valid weight. The weight should be a whole number (in lbs).");

              dinosaurWeight = Console.ReadLine();
            }

            Console.WriteLine("What enclosure number will the dinosaur be held in?");
            var dinosaurEnclosure = Console.ReadLine();
            var intDinosaurEnclosure = 0;

            while (!Int32.TryParse(dinosaurEnclosure, out intDinosaurEnclosure))
            {
              Console.WriteLine("Please enter a valid enclosure number. Enclosure number should be a whole number.");

              dinosaurEnclosure = Console.ReadLine();
            }

            var newDinosaur = new Dinosaur()
            {
              Name = dinosaurName,
              DietType = dinosaurDiet,
              Weight = intDinosaurWeight,
              EnclosureNumber = intDinosaurEnclosure,
            };

            dinosaurManager.AddDinosaur(newDinosaur);

            break;
          case "remove":
            Console.WriteLine("Please type the NAME of the dinosaur you want to remove from the park.");

            var dinosaurToRemove = Console.ReadLine();

            dinosaurManager.RemoveDinosaur(dinosaurToRemove);

            break;
          case "transfer":
            Console.WriteLine("TRANSFER LOGIC TO BE ADDED");
            break;
          case "heaviest":
            Console.WriteLine("HEAVIEST LOGIC TO BE ADDED");
            break;
          case "diet":
            Console.WriteLine("DIET LOGIC TO BE ADDED");
            break;
          case "quit":
            isRunning = false;
            break;
        }
      }

      Console.WriteLine();
      Console.WriteLine("Thank you for using Jurassic Park Dinosaur Manager!");
      Console.WriteLine();
    }
  }
}
