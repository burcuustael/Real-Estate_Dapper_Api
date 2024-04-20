using Real_Estate_Dapper_Api.Dtos.ChartDtos;

namespace Real_Estate_Dapper_Api.Repositories.EstateAgentRepositories.DashboardRepositories.ChartRepositories;

public interface IChartRepository
{
    Task<List<ResultChartDto>> Get5CityForChart();
}