using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tutorial6.Models;
namespace Tutorial6.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AnimalsController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        var animals = Database.Animals;
        return Ok(animals);
    }
    
    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var animal = Database.Animals.FirstOrDefault(x => x.Id == id);
        return Ok(animal);
    }
    [HttpPost]
    // POST api/animals
    /*{
        "id": 11,
        "name": "TestAnimal",
        "category": "TestCategory",
        "weight": 3.2,
        "color": "test-color"
    }*/
    public IActionResult Add(Animal animal)
    {
        Database.Animals.Add(animal);
        return Created();
    }

    [HttpPut("{id}")]
    public IActionResult Update(int id, Animal animal)
    {
        int index = Database.Animals.FindIndex(a => a.Id == id);
        if (index == -1)
        {
            return NotFound();
        }

        Database.Animals[index] = animal;
        return Ok();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var animal = Database.Animals.FirstOrDefault(x => x.Id == id);
        Database.Animals.Remove(animal);
        return Ok();
    }
    
    [HttpGet("name/{name}")]
    public IActionResult GetByName(String name)
    {
        var animal = Database.Animals.FirstOrDefault(x => x.Name == name);
        return Ok(animal);
    }
}