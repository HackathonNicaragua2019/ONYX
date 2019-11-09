using System;
using OnyxPlataform.Models;
namespace OnyxPlataform.Models
{
    //definicion de la clase catalogo
    public class Catalogue
    {
        public string CatalogueID{get;set;}
        //definicion de la llava foranea
        public string StoreId{get;set;}
        
        public string CatalogueProductName{get;set;}
        public string CatalogueProductModel{get;set;}
        public string CatalogueProductBrand{get;set;}
        public string CatalogueProductBuilder{get;set;}
        public string CatalogueProductType{get;set;}
        public string CatalogueProductDescription{get;set;}
        //referencia a un o0bjeto de la clase store
        public Store store{get;set;}
    }
}