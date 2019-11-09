using System;
using Collecttion.Generic;
using OnyxPlataform.Models;

namespace OnyxPlataform.Models
{
    //definicion de la clase de usuario con todos sus campos
    public class UserData
    {
        public string UserDataID{get;set}
        public string UserDataFirstName{get;set;}
        public string UserDataLastName{get;set;}
        public string UserDataCreditCard{get;set;}
        public string UserDataCreditCardPin{get;set;}
        public string UserDataPostalCode{get;set;}
        public string UserDataDirection{get;set;}

    }
    
}