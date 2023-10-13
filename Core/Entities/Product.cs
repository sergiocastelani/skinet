using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Product
    {
        //used as PK by default
        public int Id { get; set; }
        public string Name { get; set; }
    }
}