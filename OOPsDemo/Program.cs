namespace OOPsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Student student1 = new Student();
            //student1.GetDetails();

            //student1.DisplayDetails();
            //Student student2 = new Student();
            //student2.GetDetails();

            //student2.DisplayDetails();
            //Student student3 = new Student();
            //student3.GetDetails();

            //student3.DisplayDetails();

            //// WAP toi take 5 no;s's and addt them
            //int x, y, z, a, b;
            //Console.WriteLine("Enter No1");
            //x = 
            // We use Array
            // Array of objects
            Student[] students = new Student[10];

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Enter Details of {i + 1} Student");
                students[i] = new Student();
                students[i].GetDetails();
            }
            Console.WriteLine("Company is " + Student.company);
            Student.DisplayBatch();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Details of {i + 1} Student are");
                students[i].DisplayDetails();
            }
        }
    }
}

// CLass > USer Defined Type
// Blueprint based on which multiple objects of same type cud be created
// Data Type > 1. What we can store , What functions can be performed 3. Size in bytes
// int > 12,34,45, + - min max avg , 32 bits// 
// Data Types > 1. Inbuilt / primitive 2. UD Types
// Inbuilt > int char float bool string 
// UD > class struct enum
// class > UDType
// class Student
//{
//    int rn;
//    string name;
//    void Get() { }
//            void DIsplay() {  }
//}

// Int 
// Student 


//int x;
//Student obj;
// Object > instanace or variable of a class
