using System;
using OnyxPlataform.Models;
namespace OnyxPlataform.Models
{
    public class ClassRoom
    {
        public string ClassRoomId{get;set;}
        //definicion de la llava foranea
        public string UserDataId{get;set;}

        public string ClassRoomName{get;set;}
        public string ClassRoomDirections{get;set;}
        public string ClassRoomDescriptions{get;set;}
        //referencia hacia un objeto de la clase userdata
        public UserData user{get;set;}

    }    
}