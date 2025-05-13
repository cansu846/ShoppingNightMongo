using ShoppingNightMongo.Dtos.CategoryDtos;

namespace ShoppingNightMongo.Services.CategoryServices
{
    public interface ICategoryService
    {
        Task<List<ResultCategoryDto>> GetAllCategoryAsync(); 
        Task CreateCategoryAsync(CreateCategoryDto createCategoryDto); 
        Task DeleteCategoryAsync(string id); 
        Task UpdateCategoryAsync(UpdateCategoryDto updateCategoryDto); 
        Task<GetCategoryByIdDto> GetCategoryByIdAsync(string id); 

    }
}
