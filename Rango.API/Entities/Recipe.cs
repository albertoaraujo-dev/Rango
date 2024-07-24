using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Rango.API.Entities;

public class Recipe
{
    [Key]
    public int Id { get; set; }
    [Required]
    [MaxLength(200)]
    public required string Name { get; set; }
    public ICollection<Ingredient> Ingredients { get; set; } = [];
    public Recipe()
    {
        
    }

    [SetsRequiredMembers]
    public Recipe(int id, string name)
    {
        Id = id;
        Name = name;
    }
}
