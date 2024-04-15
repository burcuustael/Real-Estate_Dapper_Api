using Real_Estate_Dapper_Api.Dtos.ContactDtos;

namespace Real_Estate_Dapper_Api.Repositories.ContactRepositories;

public interface IContactRepository
{
    Task<List<ResultContactDto>> GetAllContactAsync();
    Task<List<Last4ContactResultDto>> GetLast4Contact();
    void CreateContact(CreateContactDto createContactDto);
    void DeleteContact(int id);
    Task<GetByIDContactDto> GetContact(int id);
}