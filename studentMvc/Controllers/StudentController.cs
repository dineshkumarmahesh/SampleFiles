using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccessLibrary.Repository;
using SampleFiles.Model;

namespace studentMvc.Controllers
{
    public class studentController : Controller
    {
        // GET: studentController
        StudentRepository obj = new StudentRepository();
        public ActionResult List()
        {
            return View("List", new List<StudentInformation>(obj.SelectSP()));
        }

        // GET: studentController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: studentController/Create
        public ActionResult InsertRecord()
        {
            return View("select", new StudentInformation());
        }

        // POST: studentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(StudentInformation modelInfo)
        {
            try
            {
                obj.InsertSP(modelInfo);
                return RedirectToAction(nameof(List));
            }
            catch
            {
                return View();
            }
        }

        // GET: studentController/Edit/5
        public ActionResult Edit(string entername)
        {
            var result = obj.SelectSP(entername);
            return View("update",result);
        }

        // POST: studentController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(string entername,A StudentInformation)
        {
            try
            {
                StudentInformation.entername = entername;
                obj.updateSP(StudentInformation);
                return RedirectToAction(nameof(List));
            }
            catch
            {
                return View();
            }
        }

        // GET: studentController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: studentController/Delete/5
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
