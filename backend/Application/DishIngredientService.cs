using Application.Interfaces.Repositories;
using Application.Validators;
using Application.Validators.Dishes;
using AutoMapper;
using Domain;

namespace Application;

public class DishIngredientService: IDishIngredientService
{
    private readonly IDishIngredientRepository _repository;
    private readonly IMapper _mapper;
    
    public DishIngredientService(IMapper mapper, IDishIngredientRepository repository)
    {
        _mapper = mapper;
        _repository = repository;
    }
    
    public GetDishDto AddDishIngredient(PostDishIngredientDto dto)
    {
        return _repository.AddDishIngredient(_mapper.Map<DishIngredient>(dto));
    }
}