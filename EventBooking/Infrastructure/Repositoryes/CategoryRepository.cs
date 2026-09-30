using Domain.Entities;
using Domain.Repositoryes;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositoryes;

public class CategoryRepository(AppDbContext appDbContext) : ICategoryRepository
{
    private readonly AppDbContext context=appDbContext;
    public Task<List<Category>> GetCategoriesAsync()
    {
        return context.Categories.ToListAsync();
    }

}

