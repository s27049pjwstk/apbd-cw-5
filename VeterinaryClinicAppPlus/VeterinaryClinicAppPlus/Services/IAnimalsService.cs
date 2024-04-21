using VeterinaryClinicAppPlus.Models;

namespace VeterinaryClinicAppPlus.Services;

public interface IAnimalsService {
    IEnumerable<Animal> GetAnimals(string? orderBy);
    Animal? GetAnimal(int idAnimal);
    int CreateAnimal(Animal animal);
    int UpdateAnimal(Animal animal);
    int DeleteAnimal(int idAnimal);
}