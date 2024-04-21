using System.Data.SqlClient;

namespace VeterinaryClinic.Animals;

public class AnimalRepository : IAnimalRepository {
    private IConfiguration _configuration;
    //fixme tu dodac faktyczny connecting z bazą

    public AnimalRepository(IConfiguration configuration) {
        _configuration = configuration;
    }

    public static List<Animal> DATABASE = new List<Animal> {
        new Animal {
            IdAnimal = 1,
            Name = "Max",
            Category = "Dog",
            Weight = "20kg",
            Color = "Brown",
            IndexNumber = 12345
        },
        new Animal {
            IdAnimal = 2,
            Name = "Whiskers",
            Category = "Cat",
            Weight = "5kg",
            Color = "White",
            IndexNumber = 67890
        },
        new Animal {
            IdAnimal = 3,
            Name = "Buddy",
            Category = "Dog",
            Weight = "15kg",
            Color = "Black",
            IndexNumber = 13579
        }
    };

    public IEnumerable<Animal> GetAnimals() {
        return DATABASE;
    }

    public Animal GetAnimal(int idAnimal) {
        return DATABASE.FirstOrDefault(a => a.IdAnimal == idAnimal);
    }

    public int CreateAnimal(Animal animal) {
        var maxId = DATABASE.Max(a => a.IdAnimal);
        animal.IdAnimal = maxId + 1;
        DATABASE.Add(animal);
        return animal.IdAnimal;
    }

    public int UpdateAnimal(Animal animal) {
        var animalToUpdate = DATABASE.FirstOrDefault(a => a.IdAnimal == animal.IdAnimal);
        if (animalToUpdate != null) {
            animalToUpdate.Name = animal.Name;
            animalToUpdate.Category = animal.Category;
            animalToUpdate.Weight = animal.Weight;
            animalToUpdate.Color = animal.Color;
            animalToUpdate.IndexNumber = animal.IndexNumber;
            return 1;
        }

        return 0;
    }

    public int DeleteAnimal(int idAnimal) {
        var animalToRemove = DATABASE.FirstOrDefault(a => a.IdAnimal == idAnimal);
        if (animalToRemove != null) {
            DATABASE.Remove(animalToRemove);
            return 1;
        }

        return 0;
    }
}