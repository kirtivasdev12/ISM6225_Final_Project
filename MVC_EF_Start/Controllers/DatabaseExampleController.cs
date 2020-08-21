using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_EF_Start.DataAccess;
using MVC_EF_Start.Models;

namespace MVC_EF_Start.Controllers
{
    public class DBController : Controller
    {
        public AppDBContext dbContext;

        public DBController(AppDBContext context)
        {
            dbContext = context;
        }
        public IActionResult Index()
        {


            //Student S = new Student();
            //S.Name = "John";

            //Course C = new Course();
            //C.Name = "DIS";

            //Enrolment E = new Enrolment();
            //E.student = S;
            //E.course = C;

            //dbContext.Enrolments.Add(E);
            //dbContext.SaveChanges();
            return View();
        }
    }
}