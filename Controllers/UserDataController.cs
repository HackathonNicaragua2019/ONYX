using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using OnyxPlataform.Models;
using System.Security.Claims;

namespace OnyxPlataform.Controllers
{
    public class UserDataController : Controller
    {
        //readonly data
        public readonly AplicationDbContext _Context;
        //constructor
        public UserDataController(AplicationDbContext context){
            _Context=context;
        }
        //index de usuarios
        public async Task<IActionResult> Index()
        {
            var list= await _Context.UserDataList.ToListAsync();
            return View(list);
        }
        //creacion de  los datos
        //funcion que crea los datos
        [HttpGet]
        public IActionResult Create(String id)
        {
            UserData temp=new UserData();
            //temp.UserDataID=ID;
            temp.UserDataID=id;

            return View("Create", temp);
        }
        //funcion que agrega el UserDatao a la base de datos
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(UserData temp)
        {
            if(ModelState.IsValid){
                _Context.UserDataList.Add(temp);
               await  _Context.SaveChangesAsync();
            }
            return View("Index",await _Context.UserDataList.ToListAsync());
        }
        //funcion que edita un Usuario
        [HttpGet]
        public async Task<IActionResult> Edit(string id)
        {
            if(id==null){
                return NotFound();
            }
            UserData temp=await _Context.UserDataList.FindAsync(id);
            if(temp==null){
                return NotFound();
            }
            return View(temp);
        }
        //funcion que edita en post los datos
         [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id,    UserData temp)
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
                return View("Index",await _Context.UserDataList.ToListAsync());
            }
            return View("Index",await _Context.UserDataList.ToListAsync());
            
        }
        //funcion que elimina los datos
        public async Task<IActionResult> Delete(string id)
        {
            UserData temp= await _Context.UserDataList.FindAsync(id);
            if(temp==null){
                return NotFound();
            }
            _Context.Remove(temp);
           await _Context.SaveChangesAsync();
            
            return View("Index",await _Context.UserDataList.ToListAsync());
        }
    }
}