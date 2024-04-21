using Microsoft.AspNetCore.Mvc;
using VeterinaryClinicAppPlus.Models;
using VeterinaryClinicAppPlus.Services;

namespace VeterinaryClinicAppPlus.Controllers;

[Route("api/v1/")]
[ApiController]
public class AnimalController : Controller {
    private IAnimalsService _animalService;

    public AnimalController(IAnimalsService animalService) {
        _animalService = animalService;
    }

    [HttpGet("animals")]
    public IActionResult GetAnimals(string? orderBy) {
        var animals = _animalService.GetAnimals(orderBy);
        return Ok(animals);
    }

    [HttpPost]
    public IActionResult CreateAnimal(Animal animal) {
        try {
            _animalService.CreateAnimal(animal);
            return Ok();
        } catch (Exception e) {
            return BadRequest(e.Message);
        }
    }

    [HttpPut]
    public IActionResult UpdateAnimal(Animal animal) {
        try {
            _animalService.UpdateAnimal(animal);
            return Ok();
        } catch (Exception e) {
            return BadRequest(e.Message);
        }
    }

    [HttpDelete]
    public IActionResult DeleteAnimal(int idAnimal) {
        try {
            _animalService.DeleteAnimal(idAnimal);
            return Ok();
        } catch (Exception e) {
            return BadRequest(e.Message);
        }
    }
}