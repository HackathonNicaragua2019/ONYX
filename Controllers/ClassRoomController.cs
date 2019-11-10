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
    public class ClassRoomController : Controller
    {
        //readonly data
        public readonly AplicationDbContext _Context;
        //constructores
        public ClassRoomController(AplicationDbContext context){
            _Context=context;
        }

        //index
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Detalle()
        {
            return View("Detalle");
        }

        //creacion de un classroom
        //funcion que crea los datos
        [HttpGet]
        public IActionResult Create(string ID)
        {
            ClassRoom temp=new ClassRoom();
            temp.UserDataId=ID;
            Random random= new Random();
            temp.ClassRoomId=Convert.ToString(random.Next(1,1000)+random.Next(1,12200));

            return View("Create", temp);
        }
        //funcion que agrega el ClassRoomo a la base de datos
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ClassRoom temp)
        {
            if(ModelState.IsValid){
                _Context.ClassRoomList.Add(temp);
               await  _Context.SaveChangesAsync();
            }
            return View("Index",await _Context.ClassRoomList.ToListAsync());
        }
        //funcion que edita un classroom
        [HttpGet]
        public async Task<IActionResult> Edit(string id)
        {
            if(id==null){
                return NotFound();
            }
            ClassRoom temp=await _Context.ClassRoomList.FindAsync(id);
            if(temp==null){
                return NotFound();
            }
            return View(temp);
        }
        //funcion que edita en post los datos
         [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id,    ClassRoom temp)
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
                return View("Index",await _Context.ClassRoomList.ToListAsync());
            }
            return View("Index",await _Context.ClassRoomList.ToListAsync());
            
        }
        //funcion que elimina los datos
         public async Task<IActionResult> Delete(string id)
        {
            ClassRoom temp= await _Context.ClassRoomList.FindAsync(id);
            if(temp==null){
                return NotFound();
            }
            _Context.Remove(temp);
           await _Context.SaveChangesAsync();
            
            return View("Index",await _Context.ClassRoomList.ToListAsync());
        }
    }
}