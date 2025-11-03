using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RegistroComunitario.Data;
using RegistroComunitario.Models;

namespace RegistroComunitario.Controllers
{
    public class VecinosController1 : Controller
    {
        // GET: VecinosController1
        public ActionResult Index()
        {
            return View();
        }

        // GET: VecinosController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: VecinosController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VecinosController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: VecinosController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: VecinosController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: VecinosController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: VecinosController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
