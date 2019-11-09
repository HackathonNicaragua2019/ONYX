using System;
using OnyxPlataform;
namespace OnyxPlataform.Models
{
    public class Course
    {
        public string CourseId{get;set;}
        //llave foranea
        public string ClassRoomId{get;set;}

        public string CourseName{get;set;}
        public string CourseInitialDate{get;set;}
        public string CourseFinalDate{get;set;}
        public string CourseDescription{get;set;}
        public int CourseCapacity{get;set;}
        //referencia de un dato de la clase ClassRomm
        public ClassRoom clasroom{get;set;}

    }
}