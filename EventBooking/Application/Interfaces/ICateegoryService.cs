using Application.DTOs.Categories;
using Application.Responses;

namespace Application.Interfaces;

public interface ICategoryService
{
    Task<ApiResponse<List<CategoryDto>>> GetCategoriesAsync();
}