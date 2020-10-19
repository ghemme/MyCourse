using Microsoft.AspNetCore.Mvc;

namespace MyCourse.Controllers
{
    public class HomeController:Controller
    {
       public IActionResult Index()  //action, va in quella dove ci sono tutti i dati richiesti
        {
             return Content("Sono Index della home");
        }
        
    }
}