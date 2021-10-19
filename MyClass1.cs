using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Distructor_Finalize
{
    public class MyClass : IDisposable
    {
        public void Display_msg()
        {
            Console.WriteLine("inside Display method()");
        }

       public  MyClass()
        {
            Console.WriteLine("Default constructor");

        }
       public  MyClass(string msg)
        {
            Console.WriteLine("parameterized constructor with method");
        }


       // public override string ToString() => GetType().Name;
        //~MyClass() => Console.WriteLine($"the {ToString()} finalizer is executing.");

        public void Dispose()
        {
            Console.WriteLine("freeing up resources using Dispose");

            GC.SuppressFinalize(this);
        }
        
        
    }
}
