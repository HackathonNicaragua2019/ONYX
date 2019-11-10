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
    public class StoreController : Controller
    {
        //readonlydata
        public readonly AplicationDbContext _Context;
        //constructor del controlador
        public StoreController(AplicationDbContext context){
            _Context=context;
        }

        public async Task<IActionResult> Index()
        {
            var list=await _Context.StoreList.ToListAsync();
            return View(list);
        }
        //vista de una tyienda en especiofico
        public async Task<IActionResult> ShowStore(string Id)
        {
            Store temp=await _Context.StoreList.FindAsync(Id);
            List<Catalogue> list=new List<Catalogue>();
            foreach (var item in _Context.CatalogueList)
            {
                if(item.StoreId==temp.StoreId){
                    list.Add(item);
                }
                ViewBag.productList=list;
            }
            if(ViewBag.productList==null){
                return NotFound();
            }
            return View(temp);
        }
        //creacion de una Tienda
        [Authorize]
        [HttpGet]
        public IActionResult Create(string ID)
        {
            Store temp=new Store();
            temp.UserDataId=ID;
            Random random= new Random();
            temp.StoreId=Convert.ToString(random.Next(1,1000)+random.Next(1,12200));

            return View("Create", temp);
        }
        //funcion que agrega el Storeo a la base de datos
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Store temp)
        {
            if(ModelState.IsValid){
                _Context.StoreList.Add(temp);
               await  _Context.SaveChangesAsync();
            }
            return View("Index",await _Context.StoreList.ToListAsync());
        }

        //funcion que edita una tienda
        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Edit(string id)
        {
            if(id==null){
                return NotFound();
            }
            Store temp=await _Context.StoreList.FindAsync(id);
            if(temp==null){
                return NotFound();
            }
            return View(temp);
        }
        //funcion que edita en post los datos
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, Store temp)
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
                return View("Index",await _Context.StoreList.ToListAsync());
            }
            return View("Index",await _Context.StoreList.ToListAsync());
            
        }
        //funcion que elimina un tienda
        [Authorize]
        public async Task<IActionResult> Delete(string id)
        {
            Store temp= await _Context.StoreList.FindAsync(id);
            if(temp==null){
                return NotFound();
            }
            _Context.Remove(temp);
           await _Context.SaveChangesAsync();
            
            return View("Index",await _Context.StoreList.ToListAsync());
        }
    
    }
}