using RepositoryApp.Interfaces.Manager;
using RepositoryApp.Manager;
using RepositoryApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace RepositoryApp.Controllers
{
    public class StudentController : Controller
    {
        IStudentManager _studentManager=new StudentManager();
        // GET: Student
        public ActionResult Index()
        {
            var student = _studentManager.GetAll();
            return View(student);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Student student)
        {
            if (ModelState.IsValid)
            {
                if(_studentManager.IsExisting(student.RegNo))
                {
                    ViewBag.mgs = "RegNo Already Exist";
                    return View(student);
                }

                if (_studentManager.IsExistings(student.Email))
                {
                    ViewBag.mgs = "Email is Already Exist";
                    return View(student);
                }
                bool isSaved = _studentManager.Add(student);
                if (isSaved)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    ViewBag.mgs = "Student save Failed";
                }
            }
            return View(student);
        }
        public ActionResult Edit(int id)
        {
            var student = _studentManager.GetById(id);
            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }
        [HttpPost]
        public ActionResult Edit(Student student)
        {
            if(ModelState.IsValid)
            {
                bool isUpdate = _studentManager.Update(student);
                if (isUpdate)
                {
                    return RedirectToAction("Index");
                }
            }
            return View(student);
        }
        public ActionResult Details(int id)
        {
            var student = _studentManager.GetById(id);
            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }

        public ActionResult Delete(int id)
        {
            var student=_studentManager.GetById(id);
            if(student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }
        [HttpPost]
        public ActionResult Delete(Student student)
        {
                bool isDelete = _studentManager.Delete(student);
                if (isDelete)
                {
                    return RedirectToAction("Index");
                }              
            return View(student);
        }
    }
}  