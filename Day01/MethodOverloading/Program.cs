using MethodOverloadingInteger;
using System;

namespace MethodOverloading
{
    internal class App
    {
        

        public static void Main(string[] args) 
        { 
          
            App1 obj = new App1();
            obj.Statement();
            obj.Statement("Here ");

            Addition help = new Addition();
           
            
            Console.Write(help.add(5,5,5));
            Console.Write(help.add(6, 6));
        }
    }
    public class App1
    {
        public void Statement()
        {
            Console.WriteLine("Statement of parameterless method is called");
        }
        public void Statement(String s)
        {
            Console.WriteLine(s+ "Statement of parameterized method is called");
        }
    }

    public class Addition
    {
        public int add(int a, int b)
        {
            return a + b;
        }

        public int add(int a, int b, int c)
        {
            return a + b + c;
        }
    }
}

namespace MethodOverloadingInteger
{


    
}