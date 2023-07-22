using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsDemo
{
    internal class GenericCollectionsDemo
    {
        static void Main()
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(9);
            foreach(int num in list)
            {
                Console.WriteLine(num);

            }
            Console.WriteLine("POS IS " + list.IndexOf(9));
            list.RemoveAt(list.IndexOf(9));

            Stack<string> stack = new Stack<string>();
            stack.Push("ajay");

            Queue<float> queue = new Queue<float>();
            queue.Enqueue(10.8f);

             Dictionary<int, int>   ht = new Dictionary<int, int>();
             ht[10] = 100;




        }
    }
}
