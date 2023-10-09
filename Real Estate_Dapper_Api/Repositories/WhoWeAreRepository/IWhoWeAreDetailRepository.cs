using RealEstate_Dapper_Api.Dtos.WhoWeAreDetailDtos;

namespace Real_Estate_Dapper_Api.Repositories.WhoWeAreRepository
{
    public interface IWhoWeAreDetailRepository
    {
        Task<List<ResultWhoWeAreDetailDto>> GetAllWhoWeAreDetailAsync();
        void CreateWhoWeAreDetail(CreateWhoWeAreDetailDto createWhoWeAreDetailDto);
        void DeleteWhoWeAreDetail(int id);
        void UpdateWhoWeAreDetail(UpdateWhoWeAreDetailDto updateWhoWeAreDetailDto);
        Task<GetByIDWhoWeAreDetailDto> GetWhoWeAreDetail(int id);
    }
}
