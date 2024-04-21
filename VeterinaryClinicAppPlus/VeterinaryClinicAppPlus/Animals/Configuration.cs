namespace VeterinaryClinicAppPlus.Animals;

public static class Configuration {
    public static void RegisterEndpointsForAnimals(this IEndpointRouteBuilder app) {
        //... GET /api/v1/animals
        app.MapGet("/api/v1/animals", (IAnimalsService service) => TypedResults.Ok(service.GetAnimals()));

        //... POST /api/v1/animals
        app.MapPost("/api/v1/animals", (Animal animal, IAnimalsService service) => TypedResults.Created("", service.CreateAnimal(animal)));
        
        //... GET /api/v1/animals/{id}
        app.MapGet("/api/v1/animals/{id}", (int id, IAnimalsService service) => TypedResults.Ok(service.GetAnimal(id)));

        //... PUT /api/v1/animals/{id}
        app.MapPut("/api/v1/animals/{id}", (int id, Animal animal, IAnimalsService service) => {
            animal.IdAnimal = id;
            service.UpdateAnimal(animal);
            return TypedResults.NoContent();
        });

        //... DELETE /api/v1/animals/{id}
        app.MapDelete("/api/v1/animals/{id}", (int id, IAnimalsService service) => {
            service.DeleteAnimal(id);
            return TypedResults.NoContent();
        });
        
    }
}