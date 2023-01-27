using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVCClinica.Data;
using MVCClinica.Models;
using System.Linq;
using System.Security.Policy;

namespace MVCClinica.Controllers
{
    public class MedicoController : Controller
    {

        private readonly DBClinicaMVCContext context;


        public MedicoController(DBClinicaMVCContext context)
        {
            this.context = context;

        }

        private Medico TraerUno(int id)
        {
            return context.Medicos.Find(id);
        }



        [HttpGet]
        public IActionResult Index()
        {

            var medicos = context.Medicos.ToList();

            return View(medicos);
        }

        [HttpGet]
        public ActionResult Create()
        {

            Medico medico = new Medico();

            return View(medico);
        }


        [HttpPost]
        public ActionResult Create(Medico medico)
        {

            if (ModelState.IsValid)
            {
                context.Medicos.Add(medico);

                context.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(medico);
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var medico = TraerUno(id);

            if (medico == null)
            {
                return NotFound();
            }
            else
            {
                return View(medico);
            }
        }

        [HttpPost]
        public ActionResult DeleteConfirmed(int id)
        {

            var medico = TraerUno(id);

            if (medico == null)
            {
                return NotFound();
            }
            else
            {
                context.Medicos.Remove(medico);

                context.SaveChanges();

                return RedirectToAction("Index");
            }

        }


        [HttpGet]
        public ActionResult Details(int id)
        {

            Medico medico = TraerUno(id);

            if (medico == null)
            {
                return NotFound();
            }
            else
            {
                return View(medico);
            }

        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var medico = TraerUno(id);

            if (medico == null)
            {
                return NotFound();
            }
            else
            {
                return View(medico);
            }
        }

        [HttpPost]
        public ActionResult EditConfirmed(Medico medico)
        {

            if (ModelState.IsValid)
            {
                context.Entry(medico).State = EntityState.Modified;

                context.SaveChanges();

                return RedirectToAction("Index");
                
            }
            else
            {
                return View(medico);
            }

        }


    }
}
