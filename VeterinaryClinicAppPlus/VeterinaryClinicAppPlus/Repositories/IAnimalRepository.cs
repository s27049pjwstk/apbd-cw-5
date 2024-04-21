using VeterinaryClinicAppPlus.Models;

namespace VeterinaryClinicAppPlus.Repositories;

public interface IAnimalRepository {
    IEnumerable<Animal> GetAnimals(string? orderBy);
    Animal GetAnimal(int idAnimal);
    int CreateAnimal(Animal animal);
    int UpdateAnimal(Animal animal);
    int DeleteAnimal(int idAnimal);
}