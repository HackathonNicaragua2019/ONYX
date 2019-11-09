using System;
using OnyxPlataform.Models;
namespace OnyxPlataform.Models
{
    public class Buy
    {
        public string BuyId{get;set;}
        //llave foranea
        public string StoreId{get;set;}
        //llave forane
        public string CatalogueId{get;set;}
        //llave foranea
        public string BuyDetailsId{get;set;}

        public string BuyDate{get;set;}
        public string BuyDateDeliver{get;set;}

     //referencias a los objetos
        public Store store{get;set;}
        public Catalogue catalogue{get;set;}
        public BuyDetails buydetails{get;set;}
    }
}