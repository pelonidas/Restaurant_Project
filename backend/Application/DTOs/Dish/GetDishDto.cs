using Application.DTOs.Ingredient;
using Domain;

namespace Application.DTOs;

public class GetDishDto
{
    public int Price { get; set; }
    public string Name { get; set; }
    public string Description { get; set; } 
    public string WeekDay { get; set; }
    public ICollection<GetIngredientDto> Ingredients { get; set; }
}