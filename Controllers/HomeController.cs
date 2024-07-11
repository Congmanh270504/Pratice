using Microsoft.AspNetCore.Mvc;
using Pratice.Models;
using System.Diagnostics;
using Pratice.Models;
namespace Pratice.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<Book> bookList = new List<Book>();
            bookList.Add(new Book("Lẽ Nào Em Không Biết", 622200, "th (1).jpg", "Robbert", "ccc"));
            bookList.Add(new Book("Em là nhất", 55000, "th (2).jpg", "Robbert", "ccc"));
            bookList.Add(new Book("Khuôn viên ngôn từ", 71250, "th (3).jpg", "Robbert", "ccc"));
            bookList.Add(new Book("Người truyền ký ức", 49640, "th (4).jpg", "Robbert", "ccc"));
            bookList.Add(new Book("Đạo tình", 50000, "th (5).jpg", "Robbert", "ccc"));
            bookList.Add(new Book("Yêu", 30000, "th (6).jpg", "Robbert", "ccc"));
            bookList.Add(new Book("Kỳ án ánh trăng", 115000, "th (7).jpg", "Robbert", "ccc"));
            bookList.Add(new Book("Cuộc sống không giới hạn", 74000, "th (8).jpg", "Robbert", "ccc"));
            return View(bookList);
        }
        public IActionResult Item(int index)
        {
            List<Book> bookList = new List<Book>();
            bookList.Add(new Book("Lẽ Nào Em Không Biết", 622200, "th (1).jpg", "Robbert", "ccc"));
            bookList.Add(new Book("Em là nhất", 55000, "th (2).jpg", "Robbert", "ccc"));
            bookList.Add(new Book("Khuôn viên ngôn từ", 71250, "th (3).jpg", "Robbert", "ccc"));
            bookList.Add(new Book("Người truyền ký ức", 49640, "th (4).jpg", "Robbert", "ccc"));
            bookList.Add(new Book("Đạo tình", 50000, "th (5).jpg", "Robbert", "ccc"));
            bookList.Add(new Book("Yêu", 30000, "th (6).jpg", "Robbert", "ccc"));
            bookList.Add(new Book("Kỳ án ánh trăng", 115000, "th (7).jpg", "Robbert", "ccc"));
            bookList.Add(new Book("Cuộc sống không giới hạn", 74000, "th (8).jpg", "Robbert", "ccc"));
            ViewBag.id = bookList[index];
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
