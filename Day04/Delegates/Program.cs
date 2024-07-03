
namespace Delegates1
{
    //step 1 : create a delegate class having the same signature
    //as the function to call
    public delegate void Del1();

    //Object
    //Delegate
    //MulticastDelegate
    //Del1

    public delegate int DelAdd(int a, int b);
    internal class Programs
    {
        static void Main1()
        {

            //step 2 : declare a delegate reference.
            //create a delegate object and pass function name as a parameter
            Del1 objDel = new Del1(Display);

            //step 3 : call the function via the delegate reference
            objDel();
        }
        static void Main2()
        {
            Del1 objDel = Display;
            objDel();

            objDel = Show;
            objDel();

        }
        static void Main3()
        {
            Del1 objDel = Display;
            objDel();

            Console.WriteLine();
            objDel += Show;
            objDel();

            Console.WriteLine();
            objDel += Display;
            objDel();

            Console.WriteLine();
            objDel -= Display;
            objDel();

            Console.WriteLine();
            objDel -= Show;
            objDel();

            //Console.WriteLine();
            //objDel -= Display;
            //objDel();


        }
        static void Main4()
        {
            DelAdd o1 = Add;
            Console.WriteLine(o1(10, 5));
        }

        //TO DO - try calling functions with return values as multi cast delegates
        static void Display()
        {
            Console.WriteLine("display");
        }
        static void Show()
        {
            Console.WriteLine("Show");
        }

        static int Add(int a, int b)
        {
            return a + b;
        }

        static void Main5()
        {
            Del1 o1 = Class1.Display;
            o1();
            Class1 o2 = new Class1();
            o1 = o2.Show;
        }

        static void Main6()
        {
            Del1 objDel = (Del1)Delegate.Combine(new Del1(Display), new Del1(Show), new Del1(Display));
            objDel();

            Console.WriteLine();
            //objDel = (Del1)Delegate.Remove(objDel, new Del1(Display));
            objDel = (Del1)Delegate.RemoveAll(objDel, new Del1(Display));
            objDel();
        }

    }

    public class Class1
    {
        public static void Display()
        {
            Console.WriteLine("display");
        }
        public void Show()
        {
            Console.WriteLine("Show");
        }
    }
}


namespace Delegates2
{
    public delegate int DelAdd(int a, int b);

    internal class Program
    {
        static int Add(int a, int b)
        {
            return a + b;
        }
        static int Subtract(int a, int b)
        {
            return a - b;
        }
        static int Multiply(int a, int b)
        {
            return a * b;
        }
        static void Main()
        {
            Console.WriteLine(CallMathOperation(Add, 1, 2));
            Console.WriteLine(CallMathOperation(Subtract, 5, 3));
            Console.WriteLine(CallMathOperation(Multiply, 2, 3));
        }
        //pass function to be called as a parameter

        static int CallMathOperation(DelAdd objMathOperation, int a, int b)//objMathOperation=Multiply
        {
            return objMathOperation(a, b);
        }
    }


}