using Real_Estate_Dapper_Api.Dtos.ProductDtos;

namespace Real_Estate_Dapper_Api.Repositories.EstateAgentRepositories.DashboardRepositories.LastProductsRepositories;

public interface ILast5ProductsRepository
{
    Task<List<ResultLast5ProductWithCategoryDto>> GetLast5ProductAsync(int id);
}