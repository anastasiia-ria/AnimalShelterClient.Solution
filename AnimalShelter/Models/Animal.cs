using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace AnimalShelterClient.Models
{
  public class Animal
  {
    public int AnimalId { get; set; }
    public string Name { get; set; }
    public string Sex { get; set; }
    public int Age { get; set; }
    public string Color { get; set; }
    public string Breed { get; set; }
    public string Species { get; set; }
    public string Image { get; set; }
    public static List<Animal> GetAnimals(string species, string sex, string color, string breed)
    {
      var apiCallTask = ApiHelper.GetAll(species, sex, color, breed);
      var result = apiCallTask.Result;
      var resultParse = JObject.Parse(result);
      JArray newResult = null;

      foreach (KeyValuePair<string, JToken> kvp in resultParse)
      {
        if (kvp.Key == "data")
        {
          newResult = (JArray)kvp.Value;
        }
      }

      List<Animal> animalList = JsonConvert.DeserializeObject<List<Animal>>(newResult.ToString());

      return animalList;
    }
    public static Animal GetDetails(int id)
    {
      var apiCallTask = ApiHelper.Get(id);
      var result = apiCallTask.Result;

      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      Animal animal = JsonConvert.DeserializeObject<Animal>(jsonResponse.ToString());
      return animal;
    }
    public static void Post(Animal animal)
    {
      string jsonAnimal = JsonConvert.SerializeObject(animal);
      var apiCallTask = ApiHelper.Post(jsonAnimal);
    }

    public static void Put(Animal animal)
    {
      string jsonAnimal = JsonConvert.SerializeObject(animal);
      var apiCallTask = ApiHelper.Put(animal.AnimalId, jsonAnimal);
    }

    public static void Delete(int id)
    {
      var apiCallTask = ApiHelper.Delete(id);
    }
  }
}