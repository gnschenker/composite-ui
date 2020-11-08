using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using web.Models;

namespace web.Controllers
{
    public class HomeController : Controller
    {
        private static readonly IList<CommentModel> _comments;

        static HomeController()
        {
            _comments = new List<CommentModel>
            {
                new CommentModel
                {
                    Id = 1,
                    Author = "John Doe",
                    Text = "Hello **ReactJS.NET** World!"
                },
                new CommentModel
                {
                    Id = 2,
                    Author = "Pete Bogassian",
                    Text = "This sunset `is the one` I was looking for"
                },
                new CommentModel
                {
                    Id = 3,
                    Author = "Sue Jordan",
                    Text = "This Hotel is *another* **disapointment**"
                },
            };
        }

        public IActionResult Index()
        {
            return View();
        }

        [Route("comments")]
        [ResponseCache(Location = ResponseCacheLocation.None, NoStore = true)]
        public ActionResult Comments()
        {
            return Json(_comments);
        }

        [Route("comments/new")]
        [HttpPost]
        public ActionResult AddComment(CommentModel comment)
        {
            // Create a fake ID for this comment
            comment.Id = _comments.Count + 1;
            _comments.Add(comment);
            return Content("Success :)");
        }
    }
}