using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class OrdersList
    {
        private Order order;
        private BindingList<Order> ordersList;


        public OrdersList()
        {
            ordersList = new BindingList<Order>();
        }


        public BindingList<Order> List
        {
            get { return ordersList; }
        }

        public void AddOrder(Order order)
        {
            if (order != null)
                ordersList.Add(order);


        }
        public void DelOrder(int index)
        {
            if ((index >= 0) && (order != null))
            {
                ordersList.RemoveAt(index);
            }


        }
        public Order GetOrder(int index)
        {
            order = ordersList[index];

            return order;
        }








    }
}
