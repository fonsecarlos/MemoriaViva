using System;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using MemoriaViva.Models;

namespace MemoriaViva.Controllers
{
    [Authorize]
    public class OperacionalController : Controller
    {
               
        
        [HttpGet]
        public ViewResult Login()
        {

            return View();
        }

        [HttpPost]
        public ViewResult Login(int id)
        {


            return View();
        }
       

       


       
    }
}