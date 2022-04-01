using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AnimalShelterClient.Models;

namespace AnimalShelterClient.Controllers
{
  public class AnimalsController : Controller
  {
    public IActionResult Index(string species, string sex, string color, string breed)
    {
      var allAnimals = Animal.GetAnimals(species, sex, color, breed);
      return View(allAnimals);
    }
    [HttpPost]
    public IActionResult Index(Animal animal)
    {
      Animal.Post(animal);
      return RedirectToAction("Index");
    }

    public IActionResult Details(int id)
    {
      var animal = Animal.GetDetails(id);
      return View(animal);
    }

    public IActionResult Edit(int id)
    {
      var animal = Animal.GetDetails(id);
      return View(animal);
    }

    [HttpPost]
    public IActionResult Details(int id, Animal animal)
    {
      animal.AnimalId = id;
      Animal.Put(animal);
      return RedirectToAction("Details", id);
    }

    public IActionResult Delete(int id)
    {
      Animal.Delete(id);
      return RedirectToAction("Index");
    }
  }
}