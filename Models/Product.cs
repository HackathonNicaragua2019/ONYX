using System;
using OnyxPlataform;
namespace OnyxPlataform.Models
{
    public class Product
    {
        public string ProductID{get;set;}
        //llave foranea */
        public string CatalogueId{get;set;}

        public string ProductSerialNumber{get;set;}
        public double ProductPrice{get;set;}
        public string ProductColor{get;set;}
        public string ProductWeight{get;set;}

        //referencia al objeto
        public Catalogue catalogue{get;set;}
    }
}