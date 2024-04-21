namespace VeterinaryClinic.Animals;

public interface IAnimalsService {
    IEnumerable<Animal> GetAnimals();
    Animal? GetAnimal(int idAnimal);
    int CreateAnimal(Animal animal);
    int UpdateAnimal(Animal animal);
    int DeleteAnimal(int idAnimal);
}