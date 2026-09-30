using Application.DTOs.Categories;
using Application.Interfaces;
using Application.Responses;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[ApiController]
[Route("api/[controller]")]

public class CategoryController(ICategoryService categoryService): ControllerBase
{
    private readonly ICategoryService service = categoryService;
    
    [HttpGet]
    public async Task<ApiResponse<List<CategoryDto>>> GetCategoriesAsync()
    {
        return await service.GetCategoriesAsync();
    }
}