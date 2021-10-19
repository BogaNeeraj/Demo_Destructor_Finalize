using System;

namespace Demo_Distructor_Finalize
{
    class Program : MyClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demo initializer");
            MyClass obj1 = new MyClass();
            obj1.Display_msg();
            obj1.Dispose();

            // MyClass obj2 = new MyClass("secrete messege");
             //obj2.Display_msg();


        }
    }
}
