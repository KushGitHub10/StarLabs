using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kush_Maharaj
{
    public class Basket
    {
        double FinalPrice = 0;
        public List<Shirt> shirts = new List<Shirt>();
        public List<Pants> pants = new List<Pants>();

        public double getTotalPrice()
        {


            foreach (var ValueShirts in shirts)
            {
                FinalPrice += ValueShirts.getdefaultprice();
            }
            foreach (var ValuePants in pants)
            {
                FinalPrice += ValuePants.getdefaultprice();
            }
            return FinalPrice;

        }




    }
}

