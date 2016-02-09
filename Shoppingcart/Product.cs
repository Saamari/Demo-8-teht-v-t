using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoppingcart
{
    class Product
    {
        public string Milk {get;set;}
        public string Beer { get; set; }

        public override string ToString()
        {
            return Milk + " " + Beer + " " ;
        }
    }
}
