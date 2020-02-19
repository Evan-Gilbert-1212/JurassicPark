using System;
using System.Collections.Generic;
using System.Linq;

namespace JurassicPark
{
  public class DinosaurManager
  {
    //Dinosaur Manager class
    public List<Dinosaur> DinosaurList { get; set; } = new List<Dinosaur>();

    public void AddDinosaur(Dinosaur dinosaur)
    {
      //Record time of Dinosaur acquisition
      dinosaur.DateAcquired = DateTime.Now;

      //Add Dinosaur to List
      DinosaurList.Add(dinosaur);

      //Display "Saved" message
      Console.WriteLine();
      Console.WriteLine("Dinosaur added successfully!");
      Console.WriteLine();
    }

    public void ViewDinosaurs()
    {
      var sortedDinosaurList = DinosaurList.OrderByDescending(Dinosaur => Dinosaur.DateAcquired).ToList();

      foreach (var dinosaur in sortedDinosaurList)
      {
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine($"Dinosaur Name: {dinosaur.Name}");
        Console.WriteLine($"Dinosaur Diet Type: {dinosaur.DietType}");
        Console.WriteLine($"Dinosaur Weight: {dinosaur.Weight}");
        Console.WriteLine($"Dinosaur Enclosure #: {dinosaur.EnclosureNumber}");
        Console.WriteLine($"Date Acquired: {dinosaur.DateAcquired}");
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
      }
    }

    public void RemoveDinosaur(string dinosaurToRemove)
    {
      DinosaurList.RemoveAll(dinosaur => dinosaur.Name == dinosaurToRemove);

      Console.WriteLine();
      Console.WriteLine($"All dinosaurs named {dinosaurToRemove} have been removed from the park.");
      Console.WriteLine();
    }

    public void TransferDinosaur(string dinosaurToTransfer, int newEnclosureNumber)
    {
      if (DinosaurList.Count > 0)
      {
        DinosaurList.Find(dinosaur => dinosaur.Name == dinosaurToTransfer).EnclosureNumber = newEnclosureNumber;

        Console.WriteLine();
        Console.WriteLine("Dinosaur transferred successfully.");
        Console.WriteLine();
      }
    }

    public void DisplayHeaviestDinosaurs()
    {
      var sortedDinosaurList = DinosaurList.OrderByDescending(Dinosaur => Dinosaur.Weight).ToList();

      Console.WriteLine();
      Console.WriteLine("The 3 heaviest dinosaurs in the park are:");

      for (var i = 0; i <= 2; i++)
      {
        Console.WriteLine($"{sortedDinosaurList[i].Name} weighing {sortedDinosaurList[i].Weight} lbs.");
      }

      Console.WriteLine();
    }

    public void DisplayDietSummary()
    {
      var carnivoreTotal = DinosaurList.Count(dinosaur => dinosaur.DietType == "CARNIVORE");
      var herbivoreTotal = DinosaurList.Count(dinosaur => dinosaur.DietType == "HERBIVORE");

      Console.WriteLine();
      Console.WriteLine($"You have {carnivoreTotal} Carnivore(s) in the park.");
      Console.WriteLine($"You have {herbivoreTotal} Herbivore(s) in the park.");
      Console.WriteLine();
    }
  }
}