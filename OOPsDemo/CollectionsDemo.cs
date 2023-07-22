using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsDemo
{
    internal class CollectionsDemo
    {
        static void Main()
        {
            //Byte[] num = new Byte[10];
            // Collection
            // ArrayList Stack Queue HashSet SortedList
            ArrayList list = new ArrayList(); // Collections are dynamic
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);

            //foreach(int i in list)
            //{
            //    if(i==100)
            //    {
            //        Console.WriteLine();
            //    }

            //}
            //for(int i=0;i<list.Count;i++)
            //{
            //    Console.WriteLine(list[i]);
            //}
            // foreach loop is used to iterate thru a collection or an array
            // foreach(type range_variable in array/collection)
            foreach(int num in list)
                Console.WriteLine(num);
            list.Insert(2, 100);
            Console.WriteLine("after inserting 100");
            foreach (int num in list)
                Console.WriteLine(num);
            list.Remove(4);
            Console.WriteLine("after Removing 4");
            foreach (int num in list)
                Console.WriteLine(num);
            list.RemoveAt(0);
            Console.WriteLine("after Removing element from poosition 0");
            foreach (int num in list)
                Console.WriteLine(num);

            Console.WriteLine("Stack");
            Stack stack = new Stack();
            stack.Push(100);
            stack.Push(200);
            stack.Push(300);
            Console.WriteLine("Elements of Stack");
            foreach (int num in stack)
                Console.WriteLine(num);
            stack.Pop();
            Console.WriteLine("Elements of Stack after calling Pop function");
            foreach (int num in stack)
                Console.WriteLine(num);
            

            Console.WriteLine("Queue");
            Queue queue= new Queue();
            queue.Enqueue(1000);
            queue.Enqueue(2000);
            Console.WriteLine("Elements of Queue");
            foreach (int num in queue)
                Console.WriteLine(num);
            queue.Dequeue();
            Console.WriteLine("Elements of Queue after calling Deque function");
            foreach (int num in queue)
                Console.WriteLine(num);

            // Want to do dynamic search, we use HashSet, that stores values
            // using key & value
            Hashtable ht = new Hashtable();
            // HashSet[key]=value;
            ht[1] = 100;
            ht[2] = 80;
            ht[100] = 89;
            ht[100] = 90;
            Console.WriteLine("HASHTABLE");

            Console.WriteLine(ht[2]);
            Console.WriteLine(ht[100]);

            Console.WriteLine("Marks of all students are");
            foreach(int key in ht.Keys)
                Console.WriteLine(ht[key]);







        }
    }
}
