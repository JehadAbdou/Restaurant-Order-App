using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class Order
    {
        private Drinks drink;
        private Sides side;
        private Desserts dessert;
        private Dishes dish;
        private PortinSize size;
        private int NumOfPortions;
        private DateTime date = DateTime.Now;

        public Dishes Dish
        {
            get { return dish; }
            set { dish = value; }
        }
        public Drinks Drink
        {
            get { return drink; }
            set { drink = value; }
        }
        public Sides Side
        {
            get { return side; }
            set { side = value; }
        }
        public Desserts Dessert
        {
            get { return dessert; }
            set { dessert = value; }
        }
        public PortinSize Size
        {
            get { return size; }
            set { size = value; }

        }
        public int Count
        {
            get { return NumOfPortions; }
            set { NumOfPortions = value; }
        }
        public DateTime Date
        {
            get { return date; }

        }
        public Order() { }
        public Order(Dishes Dish) : this(Dish, Drinks.NoDrink, Sides.NoSide, Desserts.NoDessert)
        {

        }
        public Order(Dishes Dish, Drinks Drink) : this(Dish, Drink, Sides.NoSide, Desserts.NoDessert)
        {

        }


        public Order(Dishes Dish, Drinks Drink, Sides Side) : this(Dish, Drink, Side, Desserts.NoDessert)
        {

        }



        public Order(Dishes Dish, Drinks Drink, Sides Side, Desserts Dessert)
        {
            this.dish = Dish;
            this.drink = Drink;
            this.side = Side;
            this.dessert = Dessert;

        }





    }
}
