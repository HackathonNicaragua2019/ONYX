using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnyxPlataform.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace OnyxPlataform.Controllers
{
    public class CatalogueController : Controller
    {
        //dato readonly
        public readonly AplicationDbContext _Context;
        //constructor
        public CatalogueController(AplicationDbContext Context){
            _Context=Context;
        }
        //index de los controladores
        public async Task<IActionResult> Index()
        {
            var list= await _Context.CatalogueList.ToListAsync();
            return View(list);
        }
        //funcion que crea los datos
        [HttpGet]
        public IActionResult Create(string ID)
        {
            Catalogue temp=new Catalogue();
            temp.CatalogueID=ID;
            Random random= new Random();
            temp.CatalogueID=Convert.ToString(random.Next(1,1000)+random.Next(1,12200));

            return View("Create", temp);
        }
        //funcion que agrega el Catalogueo a la base de datos
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Catalogue temp)
        {
            if(ModelState.IsValid){
                _Context.CatalogueList.Add(temp);
               await  _Context.SaveChangesAsync();
            }
            return View("Index",await _Context.CatalogueList.ToListAsync());
        }
         //funcion que edita una tienda
        [HttpGet]
        public async Task<IActionResult> Edit(string id)
        {
            if(id==null){
                return NotFound();
            }
            Catalogue temp=await _Context.CatalogueList.FindAsync(id);
            if(temp==null){
                return NotFound();
            }
            return View(temp);
        }
        //funcion que edita en post los datos
         [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, Catalogue temp)
        {
            if(id==null){
                return NotFound();
            }
            if(ModelState.IsValid){
                try{
                    _Context.Update(temp);
                }catch(DbUpdateConcurrencyException){
                    throw;
                }
                return View("Index",await _Context.CatalogueList.ToListAsync());
            }
            return View("Index",await _Context.CatalogueList.ToListAsync());
            
        }
        //funcion que elimina un Calogo
         public async Task<IActionResult> Delete(string id)
        {
            Catalogue temp= await _Context.CatalogueList.FindAsync(id);
            if(temp==null){
                return NotFound();
            }
            _Context.Remove(temp);
           await _Context.SaveChangesAsync();
            
            return View("Index",await _Context.CatalogueList.ToListAsync());
        }
    }
}