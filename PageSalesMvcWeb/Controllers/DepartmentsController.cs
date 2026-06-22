using Microsoft.AspNetCore.Mvc;
using PageSalesMvcWeb.Models;
using System.Collections.Generic;
using PageSalesMvcWeb.Models;


namespace PageSalesMvcWeb.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> list = new List<Department>();
            list.Add(new Department { Id = 1, Name = "Eletronics" });
            list.Add(new Department { Id = 2, Name = "Fashion" });

            return View(list);
        }
    }
}
