using Real_Estate_Dapper_Api.Dtos.ToDoListDots;

namespace Real_Estate_Dapper_Api.Repositories.ToDoListRepositories;

public interface IToDoListRepository
{
    Task<List<ResultToDoListDto>> GetAllToDoListAsync();
    void CreateToDoList(CreateToDoListDto ToDoListDto);
    void DeleteToDoList(int id);
    void UpdateToDoList(UpdateToDoListDto ToDoListDto);
    Task<GetByIDToDoListDto> GetToDoList(int id);
}