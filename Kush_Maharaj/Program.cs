using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kush_Maharaj
{
    class Program
    {
        static void Main(string[] args)
        {
            var basket = new Basket();



            var tshirt = new Tshirt();
            tshirt.name = "DC Comics";
            tshirt.size = "L";
            basket.shirts.Add(tshirt);

            var golfer = new Golfer();
            golfer.name = "Marvel";
            golfer.size = "M";
            basket.shirts.Add(golfer);



            var jeans = new Jeans();
            jeans.name = "DC Comics";
            jeans.size = "L";
            basket.pants.Add(jeans);



            var formalPants = new FormalPants();
            formalPants.name = "Marvel";
            formalPants.size = "M";
            basket.pants.Add(formalPants);
            Console.WriteLine($"Your total price is R{basket.getTotalPrice()}");
            Console.Read();
        }
    }
}
