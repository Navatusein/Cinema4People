using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.ModelDB
{
    public class ProductDb
    {
        public int Id  { get; set; } 
        public string Name { get; set; }
        public float Price { get; set; }
        public int Quantity { get; set; }
        public string PathImage { get; set; }

    }
}
