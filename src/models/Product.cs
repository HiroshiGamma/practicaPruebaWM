using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.src.models
{
    public class Product
    {
        public int Id{get;set;} 

        public int Codigo {get;set;}
        public String Nombre {get;set;}= string.Empty;
        public int Stock {get;set;} 

        public String Categoria {get;set;} = string.Empty;



    }
}