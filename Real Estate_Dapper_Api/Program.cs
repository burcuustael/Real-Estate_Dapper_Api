using Real_Estate_Dapper_Api.Hubs;
using Real_Estate_Dapper_Api.Models.DapperContext;
using Real_Estate_Dapper_Api.Repositories.BottomGridRepositories;
using Real_Estate_Dapper_Api.Repositories.CategoryRepository;
using Real_Estate_Dapper_Api.Repositories.ContactRepositories;
using Real_Estate_Dapper_Api.Repositories.EmployeeRepositories;
using Real_Estate_Dapper_Api.Repositories.EstateAgentRepositories.DashboardRepositories.ChartRepositories;
using Real_Estate_Dapper_Api.Repositories.EstateAgentRepositories.DashboardRepositories.LastProductsRepositories;
using Real_Estate_Dapper_Api.Repositories.EstateAgentRepositories.DashboardRepositories.StatisticRepositories;
using Real_Estate_Dapper_Api.Repositories.ProductRepository;
using Real_Estate_Dapper_Api.Repositories.ServiceRepository;
using Real_Estate_Dapper_Api.Repositories.StatisticsRepositories;
using Real_Estate_Dapper_Api.Repositories.ToDoListRepositories;
using Real_Estate_Dapper_Api.Repositories.WhoWeAreRepository;
using RealEstate_Dapper_Api.Repositories.PopularLocationRepositories;
using RealEstate_Dapper_Api.Repositories.TestimonialRepositories;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddTransient<Context>();
builder.Services.AddTransient<ICategoryRepository, CategoryRepository>();
builder.Services.AddTransient<IProductRepository,ProductRepository>();
builder.Services.AddTransient<IWhoWeAreDetailRepository,WhoWeAreDetailRepository>();
builder.Services.AddTransient<IServiceRepository,ServiceRepository>();
builder.Services.AddTransient<IBottomGridRepository,BottomGridRepository>();
builder.Services.AddTransient<IPopularLocationRepository,PopularLocationRepository>();
builder.Services.AddTransient<ITestimonialRepository, TestimonialRepository>();
builder.Services.AddTransient<IEmployeeRepository, EmployeeRepository>();
builder.Services.AddTransient<IStatisticsRepository, StatisticsRepository>();
builder.Services.AddTransient<IServiceRepository,ServiceRepository>();
builder.Services.AddTransient<IContactRepository,ContactRepository>();
builder.Services.AddTransient<IToDoListRepository, ToDoListRepository>();
builder.Services.AddTransient<IStatisticRepository, StatisticRepository>();
builder.Services.AddTransient<IChartRepository, ChartRepository>();
builder.Services.AddTransient<ILast5ProductsRepository,Last5ProductsRepository >();

builder.Services.AddCors(opt =>
{
    opt.AddPolicy("CorsPolicy", builder =>
    {
        builder.AllowAnyHeader()
            .AllowAnyMethod()
            .SetIsOriginAllowed((host) => true)
            .AllowCredentials();
    });
});
builder.Services.AddHttpClient();
builder.Services.AddSignalR();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("CorsPolicy");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapHub<SignalRHub>("/signalrhub");

app.Run();
