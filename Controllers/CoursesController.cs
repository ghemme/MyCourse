using Microsoft.AspNetCore.Mvc;

namespace MyCourse.Controllers
{  //   QUESTA E' LA CLASSE CHE PRENDE TUTTO CIO' A CUI ASSOCIAMO CONTROLLER
    public class CoursesController:Controller  //controller  courses
    {
        public IActionResult Index()  //action, va in quella dove ci sono tutti i dati richiesti
        {
             return Content("Sono Index");
        }

        public IActionResult Detail(string id) //deve restituire il dettaglio di un corso
        {

            return Content($"sono ID, ho ricevuto l'ID {id}");
        }           
    }
}