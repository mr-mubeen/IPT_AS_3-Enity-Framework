using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IPT_ASS_3_ENTITY_FRAMEWORK.Helper
{
    public class customerhelper
    {
        public void insert(int id , string name , string address , int cell)
        {
            customer customers = new customer();
            customers.c_id = id;
            customers.customer_name = name;
            customers.customer_address = address;
            customers.customer_cell = cell;

            var db = new ShoppingEntities();
            db.customers.Add(customers);
            db.SaveChanges();
            db.Dispose();
        }
            
    }
}