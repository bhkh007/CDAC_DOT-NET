﻿
namespace ImplicitVariables
{
    internal class Program
    {
        static void Main5()
        {
            int i = 100;
            var j = 100; //implicit variable
                         //used only for local variables
                         //cant be used for class level vars,fn params and return types
            j = 200;
            //j = "aa";  //error

            //var k="aaa";
            //k = 1234;

            Console.WriteLine(j);
            Console.WriteLine(j.GetType());
        }
    }
}

namespace AnonymousTypes
{
    //anonymous types
    internal class Program
    {
        static void Main1()
        {
            //Class1 obj = new Class1{a= 1, b = "aaa", c = true};

            var obj = new { a = 1, b = "aaa", c = true };
            Console.WriteLine(obj.a);
            Console.WriteLine(obj.b);
            Console.WriteLine(obj.c);

        }
        static void Main2()
        {
            //Class1 o = new Class1{a=10,b="aaa",c=1.2};
            //var o = new {a=10,b="aaa",c=1.2};
            var o = new { Id = 10, Name = "aaa", Salary = 1.2, IsRetired = false };
            var o2 = new { Id = 11, Name = "bbb", Salary = 3.2 };
            Console.WriteLine(o.Id);
            Console.WriteLine(o.GetType());
            Console.WriteLine(o2.GetType());
        }
    }
}

namespace PartialClasses
{
    //PARTIAL CLASSES
    //partial classes must be in the same assembly
    //partial classes must be in the same namespace
    //partial classes must have the same name

    namespace PartialClasses
    {
        public partial class Class1
        {
            public int k;
        }

    }

    namespace PartialMethods
    {
        public class MainClass
        {
            public static void Main4()
            {
                Class1 o = new Class1();
                Console.WriteLine(o.Check());
                Console.ReadLine();
            }
        }
        //Partial methods can only be defined within a partial class.
        //Partial methods must return void.
        //Partial methods can be static or instance level.
        //Partial methods cannnot have out params
        //Partial methods are always implicitly private.
        public partial class Class1
        {
            private bool isValid = true;
            partial void Validate();
            public bool Check()
            {
                //.....
                Validate();
                return isValid;
            }
        }
        public partial class Class1
        {
            partial void Validate()
            {
                //perform some validation code here
                isValid = false;
            }
        }

    }

    namespace ExtensionMethods
    {
        internal class Program
        {
            static void Main()
            {
                int i = 100;

                i = i.Add(5);
                i.Display();//MyExtClass.Display(i);   
                i.ExtMethodForBaseClass();


                string s = "aaa";
                s.Show();
                s.ExtMethodForBaseClass();
            }
            static void Main2()
            {
                int i = 100;
                i = MyExtClass.Add(i, 5);
                MyExtClass.Display(i);

                string s = "aaa";
                MyExtClass.Show(s);
            }
            static void Mains()
            {
                ClsMaths objClsMaths = new ClsMaths();
                Console.WriteLine(objClsMaths.Add(10, 5));
                Console.WriteLine(objClsMaths.Multiply(10, 5));
                Console.WriteLine(objClsMaths.Subtract(10, 5));

            }

        }
        //create a extension method
        //step 1 : create a static method in a static class
        public static class MyExtClass
        {
            public static int Add(this int i, int x)
            {
                return i + x;
            }
            //step 2 : the 1st parameter must be  the Type
            //for which you write an extension method,
            //preceded by the 'this' keyword
            public static void Display(this int i)
            {
                Console.WriteLine(i);
            }
            public static void Show(this string s)
            {
                Console.WriteLine(s);
            }
            //if you define an ext method for the base class,
            //it is also available for the derived class
            public static void ExtMethodForBaseClass(this object o)
            {
                Console.WriteLine(o);
            }

            //if you define an ext method for an interface
            //it is also available for the classes that implement that interface
            public static int Subtract(this IMathOperations objIMath, int a, int b)
            {
                return a - b;
            }
        }

        public interface IMathOperations
        {
            int Add(int a, int b);
            int Multiply(int a, int b);
        }

        public class ClsMaths : IMathOperations
        {
            public int Add(int a, int b)
            {
                return a + b;
            }
            public int Multiply(int a, int b)
            {
                return a * b;
            }
        }

    }
}