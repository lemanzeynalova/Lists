﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{  
   public abstract class Person
   {
        static int id;
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Surname { get; set; }
       
        
        public Person()
        {
            Id = id;
        }
        public enum Gender
        {
            Male,
            Female,
            Other,
        }
           
   }
}

