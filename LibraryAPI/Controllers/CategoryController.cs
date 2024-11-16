using LibraryAPI.Data;
using LibraryAPI.Model.Response;
using LibraryManagement.Model.Entities;
using Microsoft.AspNetCore.Mvc;

namespace LibraryAPI.Controllers
{

    [Route("Category/api")]
    public class CategoryController : Controller
    {

        private ApplicationDBContext dbContext;

        public CategoryController(ApplicationDBContext dBContext_)
        {
            this.dbContext = dBContext_;
        }


        [HttpPost("Category")]
        public IActionResult CategoryEntry([FromBody] CategoryRequest request)
        {

            var _categry = new Category()
            {
                Name = request.Name,
                Description = request.Description,
            };


            dbContext._category.Add(_categry);
            dbContext.SaveChanges();

            BaseResponse response = new BaseResponse();
            response.SuccessCode = 1;
            response.Message = "Success";
            return Ok(response);
        }



        [HttpGet("_categorylist")]
        public IActionResult GetBook()
        {


            var resp = dbContext._category.ToList();

            BaseResponse response = new BaseResponse();
            response.SuccessCode = 1;
            response.Message = "Success";

            return Ok(resp);
        }


        [HttpGet("Get_categoryItem")]
        public IActionResult FilterBook([FromQuery] BookFilterRequest request)
        {


            var resp = dbContext._category.Find(request.id);

            BaseResponse response = new BaseResponse();
            response.SuccessCode = 1;
            response.Message = "Success";

            return Ok(resp);
        }
    }
}
