using Microsoft.AspNetCore.Mvc;
using APIs_MVC.Models;

namespace APIs_MVC.Controllers
{
  public class HomeController : Controller
  {
    public IActionResult Index()
    {
      var allArticles = Article.GetArticles(EnvironmentVariables.ApiKey);
      return View(allArticles);
    }
  }
}