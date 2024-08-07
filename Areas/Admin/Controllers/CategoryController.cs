using Microsoft.AspNetCore.Mvc;
using WebBanHang.Data;

namespace WebBanHang.Areas.Admin.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;

        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var item = _db.Categories;
            return View(item);
        }
        public ActionResult Add()
        {
            return View();
        }
    }
}
