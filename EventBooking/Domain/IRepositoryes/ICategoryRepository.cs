using Domain.Entities;

namespace Domain.Repositoryes;

public interface ICategoryRepository
{
        Task<List<Category>> GetCategoriesAsync();

}
