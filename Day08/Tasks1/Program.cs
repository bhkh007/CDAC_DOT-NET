namespace WorkingWithTasks
{
    internal class Program
    {
        static void Main1()
        {
            //Task t1 = new Task(new Action(Func1));
            Task t1 = new Task(Func1);
            t1.Start();
            Console.WriteLine("main code");
            if (!t1.IsCompleted)
                t1.Wait();
            //Console.ReadLine();
        }
        static void Func1()
        {
            for (int i = 0; i < 10000; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
//calling a method with void return type using taskobj.Start
namespace Example1
{
    class Program
    {
        static void Main()
        {
            Task t1 = new Task(Func1);

            //Action objAction1 = Func1;
            //Task t1 = new Task(objAction1);
            //Task t3 = new Task(new Action(Func1));

            Action objAction2 = Func2;
            Task t2 = new Task(objAction2);

            t1.Start();
            t2.Start();

            Console.ReadLine();
        }
        static void Func1()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("first Func called from {0},{1}", Thread.CurrentThread.ManagedThreadId, i);
            }
        }
        static void Func2()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("second Func called from {0},{1}", Thread.CurrentThread.ManagedThreadId, i);
            }
        }
    }
}