using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using UniversityRegistrar.Models;
using System.Collections.Generic;
using System.Linq;

namespace UniversityRegistrar.Controllers
{
  public class DepartmentController : Controller
  {
    private readonly UniversityRegistrarContext _db;
    public DepartmentController(UniversityRegistrarContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Department> model = _db.Departments
                                    .OrderBy(department => department.DepartmentName)
                                    .ToList();
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

    public ActionResult Details(int id)
    {
      Department thisDepartment = _db.Departments
                                  .Include(department => department.Students)
                                  // .ThenInclude(department => department.Courses)
                                  .FirstOrDefault(department => department.DepartmentId == id);
      return View(thisDepartment);
    }
  }
}