using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Registrar.Models;
using System.Collections.Generic;
using System.Linq;

namespace Registrar.Controllers
{
    public class DepartmentsController : Controller
    {
      private readonly RegistrarContext _db;

      public DepartmentsController(RegistrarContext db)
      {
        _db = db;
      }

      public ActionResult Index()
      {
        List<Department> model = _db.Departments.ToList();
        return View(model);
      }

      public ActionResult Create()
      {
        return View();
      }

      [HttpPost]
      public ActionResult Create(Department department)
      {
        _db.Departments.Add(department);
        _db.SaveChanges();
        return RedirectToAction("Index");
      }
      // public ActionResult Edit(int id)
      // {
      //   var thisCourse = _db.Courses.FirstOrDefault(course => course.CourseId == id);
      //   return View(thisCourse);
      // }

      public ActionResult Details(int id)
    {     
        var thisDepartment = _db.Departments.FirstOrDefault(department => department.DepartmentId == id);
            
        return View(thisDepartment);
    }

    }
}