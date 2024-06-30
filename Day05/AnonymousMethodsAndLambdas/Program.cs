
namespace AnonymousMethodsAndLambdas1
{
    internal class Program
    {
        static void Main1()
        {
            int i = 100;
            Action o1 = delegate ()
            {
                //anon methods can also return an anon type
                //anon methods can access variables defined in the outer method
                Console.WriteLine(++i);
                Console.WriteLine("anon method");
            };
            o1();

            Func<int, int, int> o2 = delegate (int a, int b)
            {
                return a + b;
            };
            Console.WriteLine(o2(10, 20));
        }
        //static int Add(int a, int b)
        //{
        //    return a + b;
        //}
    }

}
namespace AnonymousMethodsAndLambdas2
{
    internal class Program
    {
        static void Main()
        {
            Func<int, int> o1 = GetDouble;
            Console.WriteLine(o1(10));

            Func<int, int> o2 = delegate (int a)
            {
                return a * 2;
            };
            Console.WriteLine(o2(10));

            //Func<int, int> o3 = (a) => a * 2;
            Func<int, int> o3 = a => a * 2;
            Console.WriteLine(o3(10));

            Func<string> o4 = () => DateTime.Now.ToLongTimeString();
            Console.WriteLine(o4());

            Func<int, int, int> o5 = (a, b) => a + b;
            Console.WriteLine(o5(10, 5));

            Predicate<int> o6 = i => i % 2 == 0;
            Console.WriteLine(o6(10));

            Func<int, bool> o7 = i =>
            {
                if (i % 2 == 0)
                    return true;
                else
                    return false;
            };
            Console.WriteLine(o7(10));

            Action o8 = () => Console.WriteLine("Display");
            Action o9 = () =>
            {
                Console.WriteLine("Display");
                Console.WriteLine("Display2");
            };

        }
        static void Display()
        {
            Console.WriteLine("Display");
        }
        static void Display2()
        {
            Console.WriteLine("Display");
            Console.WriteLine("Display2");
        }
        static string GetCurrentTime()
        {
            return DateTime.Now.ToLongTimeString();
        }
        static int Add(int a, int b)
        {
            return a + b;
        }
        static bool IsEven1(int i)
        {
            if (i % 2 == 0)
                return true;
            else
                return false;
        }
        static bool IsEven(int i)
        {
            return i % 2 == 0;
            //if (i % 2 == 0)
            //    return true;
            //else
            //    return false;
        }
        static int GetDouble(int a)
        {
            return a * 2;
        }
    }

}