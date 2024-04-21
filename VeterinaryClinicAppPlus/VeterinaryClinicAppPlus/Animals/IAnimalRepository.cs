namespace VeterinaryClinicAppPlus.Animals; 

public interface IAnimalRepository {
    IEnumerable<Animal> GetAnimals();
    Animal GetAnimal(int idAnimal);
    int CreateAnimal(Animal animal);
    int UpdateAnimal(Animal animal);
    int DeleteAnimal(int idAnimal);
}