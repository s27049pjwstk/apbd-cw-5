using System.ComponentModel.DataAnnotations;

namespace VeterinaryClinicAppPlus.Animals;

public class Animal {
    public int IdAnimal { get; set; }
    [Required] [MaxLength(200)] public string Name { get; set; }
    [Required] [MaxLength(200)] public string Category { get; set; }
    [Required] [MaxLength(200)] public string Weight { get; set; }
    [Required] [MaxLength(200)] public string Color { get; set; }
    [Required] [MaxLength(200)] public int IndexNumber { get; set; }
}