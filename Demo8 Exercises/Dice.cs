using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo8_Exercises
{
    class Dice
    {


        Random rng = new Random();
        public int Throw()
        {

            
            return rng.Next(6) +1 ;
        }
    }
}
