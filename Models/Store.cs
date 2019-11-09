using System;
using OnyxPlataform.Models;
namespace OnyxPlataform.Models
{
    //definicion de la clase tienda
    public class Store
    {
        public string StoreId{get;set;}
        //definicion de la llava foranea
        public string UserDataId{get;set;}
        
        public string StoreName{get;set;}
        public string StoreDescription{get;set;}
        public string StoreDirection{get;set;}
        public string StoreMotto{get;set;}
        public string StoreName{get;set;}
        //referencia al objeto de la clase User
        public UserData user{get;set;}
    }
}