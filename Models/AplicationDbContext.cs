using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OnyxPlataform.Models;

namespace OnyxPlataform.Models
{
    public class AplicationDbContext : DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options) { }
        
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