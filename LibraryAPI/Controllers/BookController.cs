using LibraryAPI.Data;
using LibraryAPI.Model.Response;
using LibraryManagement.Model.Entities;
using Microsoft.AspNetCore.Mvc;

namespace LibraryAPI.Controllers
{

    [Route("Books/api")]
    public class BookController : Controller
    {
       
        private ApplicationDBContext dbContext;

        public BookController(ApplicationDBContext dBContext_)
        {
            this.dbContext = dBContext_;
        }

        [HttpPost("BookEntry")]
        public IActionResult BookEntry([FromBody] BookRequest request)
        {
            var _bookres = new Book()
            {
                Title   = request.Title,
                Description = request.Description,
                PublicationYear = request.PublicationYear,
                AuthorId = request.AuthorId,
                CategoryId = request.CategoryId

            };

            dbContext._book.Add(_bookres);
            dbContext.SaveChanges();

            BaseResponse response = new BaseResponse();
            response.SuccessCode = 1;
            response.Message = "Success";

            return Ok(response);
        }


        [HttpGet("Booklist")]
        public IActionResult GetBook()
        {


            var resp = dbContext._book.ToList();
            
            BaseResponse response = new BaseResponse();
            response.SuccessCode = 1;
            response.Message = "Success";

            return Ok(resp);
        }


        [HttpGet("GetBookItem")]
        public IActionResult FilterBook([FromQuery] BookFilterRequest request)
        {


            var resp = dbContext._book.Find(request.id);

            BaseResponse response = new BaseResponse();
            response.SuccessCode = 1;
            response.Message = "Success";

            return Ok(resp);
        }
    }
}
