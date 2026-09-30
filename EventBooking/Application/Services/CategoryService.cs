using Application.DTOs.Categories;
using Application.Interfaces;
using Application.Responses;
using Domain.Interfaces;
using System.Net;

namespace Application.Services;

public class CategoryService(ICategoryRepository categoryRepository): ICategoryService
{
    private readonly ICategoryRepository repository = categoryRepository;

    public async Task<ApiResponse<List<CategoryDto>>> GetCategoriesAsync()
    {
        var res = await repository.GetCategoriesAsync();
        var Categories = res.Select(x=> new CategoryDto()
        {
            Id = x.Id,
            Name = x.Name
        }).ToList();
        return new ApiResponse<List<CategoryDto>>(HttpStatusCode.OK, "List of categoires", Categories);
    }
}