using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestProjectForm.Models;
using System.IO;

using Newtonsoft.Json;

namespace TestProjectForm.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet]
        public ActionResult Postdata()
        {

          

            return View();
        }
        [HttpPost]
        [ActionName ("Postdata")]
        public ActionResult Adddata(Employee emp)
        {

             List<Employee> emlist = new List<Employee>();

            emlist.Add(new Employee()
            {
                Empfname=emp.Empfname,
                Emplname=emp.Emplname
               

            });

           
            string path = Server.MapPath("~/app_data/db.json");


            var jsondata = JsonConvert.SerializeObject(emlist);
             if(ModelState.IsValid)
            {
                System.IO.File.AppendAllText(path, jsondata);

                ViewBag.cnf = "Employee details added successfully";
                ModelState.Clear();
              
            }

         
           

            


            return View();
        }

       
    }
}