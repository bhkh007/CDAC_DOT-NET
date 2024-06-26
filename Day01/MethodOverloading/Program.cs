
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

            Addition addition = new Addition();
           
            
            Console.WriteLine(addition.add(5,5,5));
            Console.WriteLine(addition.add(6, 6));
            Console.WriteLine(addition.add());

            Console.WriteLine(addition.add(7, 7));
            
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
        /*public int add(int a, int b)
        {
            return a + b;
        }*/

        public int add(int a, int b, int c)
        {
            return a + b + c;
        }

        public int add(int a=0,int b=0,int c = 0,int d=0)
        {
            return a + b + c+ d;
        }

        public int add(int a, int b, int c, int d = 0,int e =0)
        {
            return a + b + c + d;
        }

        /*public int add(int a=0, int b=0, int c, int d, int e) //gives error cause first two param are initialized
        {
            return a + b + c + d;   //param initialize should be from right to left
        }*/


    }
}

