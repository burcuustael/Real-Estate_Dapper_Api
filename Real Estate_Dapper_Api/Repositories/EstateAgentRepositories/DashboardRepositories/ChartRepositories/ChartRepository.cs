using Dapper;
using Real_Estate_Dapper_Api.Dtos.ChartDtos;
using Real_Estate_Dapper_Api.Models.DapperContext;

namespace Real_Estate_Dapper_Api.Repositories.EstateAgentRepositories.DashboardRepositories.ChartRepositories;

public class ChartRepository : IChartRepository
{
    private readonly Context _context;

    public ChartRepository(Context context)
    {
        _context = context;
    }

    public async Task<List<ResultChartDto>> Get5CityForChart()
    {
        string query = "Select top(5) City,Count(*) as 'CityCount' From Product GROUP BY City order by CityCount desc ";

        using (var connection = _context.CreateConnection())
        {
            var values = await connection.QueryAsync<ResultChartDto>(query);
            return values.ToList();
        }

    }
}