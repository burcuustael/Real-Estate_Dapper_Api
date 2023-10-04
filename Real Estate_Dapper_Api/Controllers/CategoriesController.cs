﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Real_Estate_Dapper_Api.Dtos.CategoryDtos;
using Real_Estate_Dapper_Api.Repositories.CategoryRepository;

namespace Real_Estate_Dapper_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryRepository _categoryRepository;
        public CategoriesController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        [HttpGet]

        public async Task<IActionResult> CategoryListAsync()
        {
            var values = await _categoryRepository.GetAllCategoryAsync();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateCategory(CreateCategoryDto createCategoryDto)
        {
            _categoryRepository.CreateCategory(createCategoryDto);
            return Ok("Kategori Başarılı Bir Şekilde Eklendi");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            _categoryRepository.DeleteCategory(id);
            return Ok("Kategori Başarılı Bir Şekilde Silindi");
        }

    }
}