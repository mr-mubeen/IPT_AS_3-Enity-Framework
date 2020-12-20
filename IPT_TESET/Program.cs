using IPT_ASS_3_ENTITY_FRAMEWORK.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPT_TESET
{
    class Program
    {
        static void Main(string[] args)
        {

            customerhelper customerhel = new customerhelper();
            customerhel.insert(1, "Ali", "Karachi", 1234534);

            producthelper pro1 = new producthelper();
            pro1.insert("Nike Shoes", 3000);

            OrderHelper o1 = new OrderHelper();
            o1.insert(DateTime.Now, 1, 1);

        }
    }
}
