using System;
using OnyxPlataform.Models;
namespace OnyxPlataform.Models
{
    public class BuyUser
    {
        //definicion de llavfe foranea
        public string UserDataId{get;set;}
        public string BuyUserId{get;set;}
        //referencia a los objetos
        public UserData user{get;set;}
    }
}