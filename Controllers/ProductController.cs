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
    public class ProductController : Controller
    {
        //definicion de un contexto de la base de datos
        private readonly AplicationDbContext _Context;
        //definicion del constructor de la base de datos
        public ProductController(AplicationDbContext context){
            _Context=context;
        }
        //Index de todos los productos
        public async Task<IActionResult> Index()
        {
            var Lists=await _Context.ProductList.ToListAsync();
            return View(Lists);
        }
        //index de los productos de una tienda
        public async Task<IActionResult> IndexStore(string storeid)
        {
            List<Product> pList=new List<Product>();
            foreach (var item in _Context.ProductList)
            {
                if(item.catalogue.StoreId==storeid){
                    pList.Add(item);
                }
            }
            return View(pList);
        }
        //funcion que elimina un producto
           public async Task<IActionResult> Delete(string id)
        {
            Product temp= await _Context.ProductList.FindAsync(id);
            if(temp==null){
                return NotFound();
            }
            _Context.Remove(temp);
           await _Context.SaveChangesAsync();
            
            return View("Index",await _Context.ProductList.ToListAsync());
        }
        //funcion que crea un producto
           [HttpGet]
        public IActionResult Create(string ID)
        {
            Product temp=new Product();
            temp.CatalogueId=ID;
            Random random= new Random();
            temp.ProductID=Convert.ToString(random.Next(1,1000)+random.Next(1,12200));

            return View("Create", temp);
        }
        //funcion que agrega el producto a la base de datos
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Product temp)
        {
            if(ModelState.IsValid){
                _Context.ForumList.Add(temp);
               await  _Context.SaveChangesAsync();
            }
            return View("Index",await _Context.ProductList.ToListAsync());
        }
    }
}