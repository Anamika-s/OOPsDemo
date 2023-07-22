using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsDemo
{
    internal class CollectionsLimitaions
    {
        static void Main()
        {
            ArrayList list = new ArrayList(); // Collections are dynamic
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add("ajay");
             
            list.Add(90.7f);
            list.Add(100);
            list.Add(1111);
            // Boxing  > converting value to reference type
            // UnBoxing > coneverting refe to value type
            foreach (var num in list)
                Console.WriteLine(num);
            Hashtable ht = new Hashtable();
            ht[1] = 100;
            ht["ajay"] = 100;
            ht["deepak"] = "Delhi";


        }
    }
}