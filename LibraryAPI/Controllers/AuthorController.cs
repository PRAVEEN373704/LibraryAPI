using LibraryAPI.Data;
using LibraryAPI.Model.Response;
using LibraryManagement.Model.Entities;
using Microsoft.AspNetCore.Mvc;

namespace LibraryAPI.Controllers
{

    [Route("Author/api")]
    public class AuthorController : Controller
    {

        private ApplicationDBContext dbContext;

        public AuthorController(ApplicationDBContext dBContext_)
        {
            this.dbContext = dBContext_;
        }


        [HttpPost("AuthorEntry")]
        public IActionResult Author([FromBody]AuthorRequest request)
        {

            var _authorModel = new Author()
            {
                Name = request.Name,
                Bio = request.Bio
            };

            dbContext._author.Add(_authorModel);
            dbContext.SaveChanges();


            BaseResponse response = new BaseResponse();
            response.SuccessCode = 1;
            response.Message = "Success";


            return Ok(response);
        }


        [HttpGet("Authorlist")]
        public IActionResult GetAuthor()
        {


            var resp = dbContext._author.ToList();

            BaseResponse response = new BaseResponse();
            response.SuccessCode = 1;
            response.Message = "Success";

            return Ok(resp);
        }


        [HttpGet("Get_authorItem")]
        public IActionResult FilterBook([FromQuery] BookFilterRequest request)
        {


            var resp = dbContext._author.Find(request.id);

            BaseResponse response = new BaseResponse();
            response.SuccessCode = 1;
            response.Message = "Success";

            return Ok(resp);
        }
    }
}
