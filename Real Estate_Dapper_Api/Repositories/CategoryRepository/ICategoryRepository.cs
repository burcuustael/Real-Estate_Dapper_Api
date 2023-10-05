﻿using Real_Estate_Dapper_Api.Dtos.CategoryDtos;

namespace Real_Estate_Dapper_Api.Repositories.CategoryRepository
{
    public interface ICategoryRepository
    {
        Task<List<ResultCategoryDto>> GetAllCategoryAsync();
        void CreateCategory(CreateCategoryDto categoryDto);
        void DeleteCategory(int id);
        void UpdateCategory(UpdateCategoryDto updateCategoryDto);
        Task<GetByIDCategoryDto> GetCategory(int id);
    }
}
