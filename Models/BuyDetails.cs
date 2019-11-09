using System;
using OnyxPlataform.Models;
namespace OnyxPlataform.Models
{
    public class BuyDetails 
    {
        public string BuyDetailsId{get;set;}
        //referencias llave foranea
        public string ProductId{get;set;}
        
        public int BuyDetailsQuantity{get;set;}
        public double BuyDetailsTotalPrice{get;set;}
        public double BuyDetailsDiscount{get;set;}

        //definicion de referncias a los objetos
        public Product product{get;set;}
    }
}