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
    public class CourseController : Controller
    {
        //readonly data
        public readonly AplicationDbContext _Context;
        //controller
        public CourseController(AplicationDbContext context){
            _Context=context;
        }
        //index
        public async Task<IActionResult> Index()
        {
            var list= await _context.CourseList.ToListAsync();
            return View(list);
        }
        //creacion de un Course
        //funcion que crea los datos
        [HttpGet]
        public IActionResult Create(string ID)
        {
            Course temp=new Course();
            temCourseId=ID;
            Random random= new Random();
            temp.CourseId=Convert.ToString(random.Next(1,1000)+random.Next(1,12200));

            return View("Create", temp);
        }
        //funcion que agrega el Courseo a la base de datos
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Course temp)
        {
            if(ModelState.IsValid){
                _Context.CourseList.Add(temp);
               await  _Context.SaveChangesAsync();
            }
            return View("Index",await _Context.CourseList.ToListAsync());
        }
        //funciuon que edita los datos 
         [HttpGet]
        public async Task<IActionResult> Edit(string id)
        {
            if(id==null){
                return NotFound();
            }
                 Course temp=await _Context.CourseList.FindAsync(id);
            if(temp==null){
                return NotFound();
            }
            return View(temp);
        }
        //funcion que edita en post los datos
         [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id,  Course temp)
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
                return View("Index",await _Context.CourseList.ToListAsync());
            }
            return View("Index",await _Context.CourseList.ToListAsync());
            
        }
        //funcion que elimina el dato
         public async Task<IActionResult> Delete(string id)
        {
            Course temp= await _Context.CourseList.FindAsync(id);
            if(temp==null){
                return NotFound();
            }
            _Context.Remove(temp);
           await _Context.SaveChangesAsync();
            
            return View("Index",await _Context.CourseList.ToListAsync());
        }
    }
}