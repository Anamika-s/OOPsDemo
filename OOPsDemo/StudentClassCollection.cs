using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsDemo
{
    internal class StudentClassCollection
    {static void Main()
        {
            //Student[] list = new Student[10];
            //ArrayList list = new ArrayList();
            //Student student1 = new Student();
            //student1.GetDetails();

            //list.Add(student1);
            //Student student2 = new Student();
            //student2.GetDetails();
            //list.Add(student2);
            List<Student> list = new List<Student>();
            string ch = "y";
            while (ch == "y")
            {
                Student student = new Student();
                student.GetDetails();
                list.Add(student);
                Console.WriteLine("Add more?");
                ch = Console.ReadLine();
            }

            //list.Add(100);
            foreach(Student student in list)
            {
                student.DisplayDetails();
            }
            list.RemoveAt(2);


            int pos = 0;
            foreach (Student student in list)
            {
                if (student.id == 1)
                {
                    pos = list.IndexOf(student);
                    break;
                }
            }
        
         list.RemoveAt(pos);

            Dictionary<int, Student> records = new Dictionary<int, Student>();
            Student student1 = new Student();
            student1.GetDetails();
            records[1] = student1;
            Student student2 = new Student();
            student2.GetDetails();
            records[2] = student2;
            records.Remove(2);





        }
    }
}
