using Parcial.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using System.Reflection;

namespace Parcial.Controllers
{
    public class FormularioController : Controller
    {

        public static List<Formulario> formularioList = new List<Formulario>();
        public IActionResult Index()
        {

            return View(formularioList);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Create(Formulario pag)
        {
            try
            {
                formularioList.Add(pag);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }


        /* [HttpPost]
         public IActionResult Create(IDtributaria tarea)
         {
             tarea.Id = tributaria.Count + 1;
             tarea.Id = tributaria.Count + 1;
             tributaria.Add(tarea);
             return RedirectToAction("Index");
         }*/
    }
}
