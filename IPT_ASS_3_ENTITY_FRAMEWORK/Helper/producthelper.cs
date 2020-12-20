using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IPT_ASS_3_ENTITY_FRAMEWORK.Helper
{
    public class producthelper
    {

        public void insert(string name, int price)
        {
            product pro = new product();
            pro.p_name = name;
            pro.price = price;

            var db = new ShoppingEntities();
            db.products.Add(pro);
            db.SaveChanges();
            db.Dispose();
        }

    }
}