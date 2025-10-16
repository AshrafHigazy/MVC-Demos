using Demo_S02.Models;
using Microsoft.AspNetCore.Mvc;

namespace Demo_S02.Controllers
{
    public class MoviesController : Controller
    {
        ////https://localhost:5001/Movies/Index
        //[HttpGet]
        //public string Index()
        //{
        //    //context -> DB
        //    return "Hello from Controller";
        //}

        [HttpGet]
        public ContentResult Index()
        {
            ContentResult result = new ContentResult();
            result.Content = "Hello from index";
            result.ContentType = "text/html";
            result.StatusCode = 200;

            return result;
        }

        public RedirectResult GoGoogle()
        {
            RedirectResult result = new RedirectResult("https://www.google.com");

            return result;
        }
        //public ActionResult GetMovie(int id)
        //{
        //    return Content($"Movie id : {id}");
        //}
        public IActionResult GetMovie(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            else if (id < 10)
            {
                return NotFound();
            }
            else
            {
                return Content($"Movie id : {id}");
            }
        }
        //Simple Data
        //Value Providers 
        //Routing and Quary syntex
        public IActionResult GetMovieByName(int id, string name)
        {
            return Content($"Movie id : {id} , name : {name}");
        }
        public IActionResult GetMovieByNameRequestHeader([FromHeader] int id, [FromHeader] string name)
        {
            return Content($"Movie id : {id} , name : {name}");
        }

        //Complex Data
        public IActionResult AddMovieByComplexData(Movie movie)
            => Content($"Movie id : {movie.ID} , name : {movie.Title}");

        //Collection Data
        public IActionResult AddArray(int[] arr) 
            => Content($"Array : {arr[0]}");
    }
}
