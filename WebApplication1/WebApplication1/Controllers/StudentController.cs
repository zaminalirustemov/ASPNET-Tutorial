using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            Students student1 = new Students { Id = 1, Name = "Zaminali", Surname = "Rustemov" };
            Students student2 = new Students { Id = 2, Name = "Ali", Surname = "Ibrahimov" };
            Students student3 = new Students { Id = 3, Name = "Nicat", Surname = "Abdullayev" };
            Students student4 = new Students { Id = 4, Name = "Namiq", Surname = "Mikayilov" };

            List<Students> students = new List<Students>();
            students.Add(student1);
            students.Add(student2);
            students.Add(student3);
            students.Add(student4);

            return View(students);
        }

        public IActionResult Detail(int id)
        {
            Students student1 = new Students { Id = 1, Name = "Zaminali", Surname = "Rustemov" };
            Students student2 = new Students { Id = 2, Name = "Ali", Surname = "Ibrahimov" };
            Students student3 = new Students { Id = 3, Name = "Nicat", Surname = "Abdullayev" };
            Students student4 = new Students { Id = 4, Name = "Namiq", Surname = "Mikayilov" };

            List<Students> students = new List<Students>();
            students.Add(student1);
            students.Add(student2);
            students.Add(student3);
            students.Add(student4);

            Students wantedstudent = students.FirstOrDefault(std => std.Id == id);
            
            return View(wantedstudent);
        }
    }
}
