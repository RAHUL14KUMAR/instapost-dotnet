using instapostBusinesslayer.Service.Implementation;
using instapostBusinesslayer.Service.Interface;
using instapostBusinesslayer.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace instapost.controller
{
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly CategorySInterface cs;
        public CategoryController(CategorySInterface cs)
        {
            this.cs = cs;
        }

        [HttpPost]
        [Route("addCategory")]
        public async Task<IActionResult> addCategory(CategoryModel cm)
        {
            var data = await cs.CreateCategory(cm);
            return Ok(data);
        }

        [HttpGet]
        [Route("category")]
        public async Task<IActionResult> GetCategoryById(long id)
        {
            var data = await cs.GetCategoryById(id);
            return data != null ? Ok(data) : NotFound(new { message = $"Category with ID {id} not found" });
        }

        [HttpGet]
        [Route("category/all")]
        public async Task<IActionResult> getAllCategory()
        {
            var res = await cs.GetAllCategory();
            return Ok(res);
        }
    }
}