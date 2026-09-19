using Microsoft.AspNetCore.Mvc;
using Portfolio.Models;

namespace Portfolio.Controllers
{
    public class ProjectsController : Controller
    {
        private static readonly List<Project> projects = new()
        {
            new Project
            {
                Id = 1,
                Name = "Prelim Quiz 1",
                Description = "A web-based project created for the IT Elective 2 preliminary activity.",
                GitHubLink = "https://github.com/daniellemarcos3/BSIT_31E3_PRELIM_Q1_MARCOS_DANIELLE-ALLYNE",
                ImageUrl = "/images/prelim-quiz1.png"
            },

            new Project
            {
                Id = 2,
                Name = "Midterm Activity 1",
                Description = "An ASP.NET Core MVC project created as part of the IT Elective 2 midterm activities.",
                GitHubLink = "https://github.com/daniellemarcos3/IT_ELECTIVE_2_Midterm_A1_Marcos_Danielle-Allyne",
                ImageUrl = "/images/midterm-activity1.png"
            },

            new Project
            {
                Id = 3,
                Name = "Midterm Quiz 2",
                Description = "A web application project developed for the second midterm quiz.",
                GitHubLink = "https://github.com/daniellemarcos3/IT_ELECTIVE_2_MIDTERM_Q2_Marcos_DanielleAllyne",
                ImageUrl = "/images/midterm-quiz2.png"
            },

            new Project
            {
                Id = 4,
                Name = "Midterm Quiz 3",
                Description = "An ASP.NET Core MVC application created for the third midterm quiz.",
                GitHubLink = "https://github.com/daniellemarcos3/IT_ELECTIVE_2_MIDTERM_Q3",
                ImageUrl = "/images/midterm-q3.png"
            },

            new Project
            {
                Id = 5,
                Name = "Portfolio",
                Description = "A personal portfolio website created using ASP.NET Core MVC to showcase projects and skills.",
                GitHubLink = "https://github.com/daniellemarcos3/Portfolio",
                ImageUrl = "/images/Portfolio.png"
            },

            new Project
            {
                Id = 6,
                Name = "Point of Sales",
                Description = "A simple point-of-sale web application for managing products and shopping cart transactions.",
                GitHubLink = "https://github.com/daniellemarcos3/Point-of-Sales",
                ImageUrl = "/images/point-of-sales.png"
            }
        };

        private static readonly List<Comment> comments = new();

        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("IsLoggedIn") != "true")
            {
                return RedirectToAction("Login", "Account");
            }

            return View(projects);
        }

        public IActionResult Details(int id)
        {
            if (HttpContext.Session.GetString("IsLoggedIn") != "true")
            {
                return RedirectToAction("Login", "Account");
            }

            var project = projects.FirstOrDefault(p => p.Id == id);

            if (project == null)
            {
                return NotFound();
            }

            ViewBag.Comments = comments
                .Where(c => c.ProjectId == id)
                .OrderByDescending(c => c.DatePosted)
                .ToList();

            return View(project);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddComment(
            int projectId,
            string name,
            string message)
        {
            if (HttpContext.Session.GetString("IsLoggedIn") != "true")
            {
                return RedirectToAction("Login", "Account");
            }

            if (!string.IsNullOrWhiteSpace(name) &&
                !string.IsNullOrWhiteSpace(message))
            {
                comments.Add(new Comment
                {
                    Id = comments.Count + 1,
                    ProjectId = projectId,
                    Name = name.Trim(),
                    Message = message.Trim(),
                    DatePosted = DateTime.Now
                });
            }

            return RedirectToAction(
                "Details",
                new { id = projectId });
        }
    }
}