using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kush_Maharaj
{
    public abstract class product//parents class
    {
        public string name;
        public string size;

        public string propName
        {
            get { return name; }
            set { name = value; }

        }

        public string propSize
        {
            get { return size; }
            set { size = value; }

        }

        public product()
        {

            propSize = " ";
            propName = " ";

        }

        public product(string S, string N)
        {

            propSize = S;
            propName = N;

        }


        //GET DefaultPrice abstract method
        public abstract double getdefaultprice();

    }




    //shirt inherits from product
    public class Shirt : product
    {

        public Shirt()
        {

        }
        public Shirt(string name, string size) : base(name, size)
        {

        }
        public override double getdefaultprice()
        {
            double price = 0;
            if (size == "S")
            {
                price = 10;
            }
            else if (size == "M")
            {
                price = 20;
            }
            else if (size == "L")
            {
                price = 30;
            }
            return price;
        }


    }

    //Tshirt inherits from shirt
    public class Tshirt : Shirt
    {

        public Tshirt() : base()
        {

        }
        public Tshirt(string name, string size) : base(name, size)
        {

        }

        public override double getdefaultprice()
        {
            return base.getdefaultprice();
        }


    }
    public class Golfer : Shirt
    {

        public Golfer() : base()
        {

        }
        public Golfer(string name, string size) : base(name, size)
        {

        }

        public override double getdefaultprice()
        {
            return base.getdefaultprice() * 2;

        }

    }

    public class Pants : product
    {
        public Pants()
        {

        }
        public Pants(string name, string size) : base(name, size)
        {

        }
        public override double getdefaultprice()
        {
            double price = 0;
            if (size == "S")
            {
                price = 10;
            }
            else if (size == "M")
            {
                price = 20;
            }
            else if (size == "L")
            {
                price = 30;
            }
            return price;
        }

    }

    public class Jeans : Pants
    {
        public Jeans() : base()
        {

        }
        public Jeans(string name, string size) : base(name, size)
        {

        }
        public override double getdefaultprice()
        {
            return base.getdefaultprice();
        }

    }
    public class FormalPants : Pants
    {
        public FormalPants() : base()
        {

        }
        public FormalPants(string name, string size) : base(name, size)
        {

        }
        public override double getdefaultprice()
        {
            return base.getdefaultprice() + 30;
        }
    }

}