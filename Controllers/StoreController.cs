using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OnyxPlataform.Controller
{
    public class StoreController : Controller
    {
        //readonlydata
        public readonly ApplicationDbContex _Context;
        //constructor del controlador
        public IActionResult Index()
        {
            
            return View();
        }
    }
}