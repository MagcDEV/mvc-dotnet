using Microsoft.AspNetCore.Mvc;
using mvc_dotnet.Data;
using mvc_dotnet.Models;

namespace mvc_dotnet.Controllers
{
    [Route("[controller]")]
    public class CategoryController : Controller
    {
        private readonly ILogger<CategoryController> _logger;
        private readonly AddDbContext _dbContext;

        public CategoryController(ILogger<CategoryController> logger, AddDbContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            IEnumerable<Category> categories = _dbContext.Categories;
            return View(categories);
        }
        
        [Route("Create")]
        public IActionResult Create()
        {
            return View();
        }


        // [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        // public IActionResult Error()
        // {
        //     return View("Error!");
        // }
    }
}