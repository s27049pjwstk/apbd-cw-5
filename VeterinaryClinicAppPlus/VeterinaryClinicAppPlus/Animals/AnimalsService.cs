namespace VeterinaryClinic.Animals;

public class AnimalsService : IAnimalsService {
    private readonly IAnimalRepository _animalRepository;

    public AnimalsService(IAnimalRepository animalRepository) {
        _animalRepository = animalRepository;
    }

    public IEnumerable<Animal> GetAnimals() {
        return _animalRepository.GetAnimals();
    }

    public Animal? GetAnimal(int idAnimal) {
        return _animalRepository.GetAnimal(idAnimal);
    }

    public int CreateAnimal(Animal animal) {
        return _animalRepository.CreateAnimal(animal);
    }

    public int UpdateAnimal(Animal animal) {
        return _animalRepository.UpdateAnimal(animal);
    }

    public int DeleteAnimal(int idAnimal) {
        return _animalRepository.DeleteAnimal(idAnimal);
    }
}