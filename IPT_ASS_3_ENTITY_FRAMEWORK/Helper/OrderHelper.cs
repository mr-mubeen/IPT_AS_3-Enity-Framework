using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IPT_ASS_3_ENTITY_FRAMEWORK.Helper
{
    public class OrderHelper
    {
        public void insert(DateTime date ,int pro_id , int c_id)
        {
            order o = new order();
            o.o_date = date;
            o.p_id = pro_id;
            o.c_id = c_id;

            var db = new ShoppingEntities();
            db.orders.Add(o);
            db.SaveChanges();
            db.Dispose();
        }
    }
}