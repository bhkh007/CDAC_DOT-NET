//calling methods with return type 
namespace Example4
{
    class Program
    {
        static void Main()
        {
            Task<int> t1 = new Task<int>(Func1);
            t1.Start();
            Task<int> t2 = new Task<int>(Func2, "passed value");
            t2.Start();

            Task<int> t3 = Task.Factory.StartNew<int>(Func1);
            Task<int> t4 = Task.Factory.StartNew<int>(Func2, "passed value");

            Task<int> t5 = Task.Run<int>(Func1);

            Console.WriteLine("other code here");

            //if(!t1.IsCompleted)
            //    t1.Wait(); //waiting call
            Console.WriteLine(t1.Result); //waiting call
            Console.WriteLine(t2.Result); //waiting call
            Console.WriteLine(t3.Result); //waiting call
            Console.WriteLine(t4.Result); //waiting call
            Console.WriteLine(t5.Result); //waiting call

        }
        static int Func1()
        {
            int i;
            for (i = 0; i < 1000000; i++)
            {
                Console.WriteLine("first Func called {0}", i);
            }
            return i;
        }
        static int Func2(object obj)
        {
            int i;
            for (i = 0; i < 20; i++)
            {
                Console.WriteLine("second Func called {0},{1}", i, obj.ToString());
            }
            return i;
        }
    }
}


