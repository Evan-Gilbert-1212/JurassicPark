using System;
using System.Collections.Generic;

namespace JurassicPark
{
  public class DinosaurManager
  {
    //Dinosaur Manager class
    public List<Dinosaur> DinosaurList { get; set; } = new List<Dinosaur>();

    public void AddDinosaur(Dinosaur dinosaur)
    {
      //Define ID of Dinosaur
      dinosaur.ID = DinosaurList.Count;

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
      foreach (var dinosaur in DinosaurList)
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
  }
}