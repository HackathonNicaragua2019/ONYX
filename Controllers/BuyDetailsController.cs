using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OnyxPlataform.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
namespace OnyxPlataform.Controllers
{
    public class BuyDetailsController : Controller
    {
        //readonly
        public readonly AplicationDbContext _Context;
        //constructor
        public BuyDetailsController(AplicationDbContext context){
            _Context=context;
        }
        //Index
        public async Task<IActionResult> Index()
        {
            var list=await _Context.BuyDetailsList.ToListAsync();
            return View(list);
        }
        //index de compra por cada Usuario

    }
}