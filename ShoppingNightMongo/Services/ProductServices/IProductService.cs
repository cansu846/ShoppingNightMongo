using ShoppingNightMongo.Dtos.ProductDtos;

namespace ShoppingNightMongo.Services.ProductServices
{
    public interface IProductService
    {
        Task<List<ResultProductDto>> GetAllProductAsync(); 
        Task CreateProductAsync(CreateProductDto createProductDto); 
        Task DeleteProductAsync(string id); 
        Task UpdateProductAsync(UpdateProductDto updateProductDto); 
        Task<GetProductByIdDto> GetProductByIdAsync(string id); 

    }
}
