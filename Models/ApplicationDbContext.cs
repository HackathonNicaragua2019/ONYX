using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using OnyxPlataform.Models;

namespace OnyxPlataform.Models
{
    public class AplicationDbContext : IdentityDbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            
        }
        
        //definicion de las tablas
        public DbSet<UserData> UserDataList { get; set;}
        public DbSet<Store> StoreList { get; set; }
        public DbSet<ClassRoom> ClassRoomList { get; set; }
        public DbSet<Catalogue> CatalogueList { get; set; }
        public DbSet<BuyDetails> BuyDetailsList { get; set; }
        public DbSet<Course> CourseList { get; set; }
        public DbSet<Product> ProductList { get; set; }
        public DbSet<Buy> BuyList { get; set; }
        public DbSet<BuyUser> BuyUserList { get; set; }
    }
}