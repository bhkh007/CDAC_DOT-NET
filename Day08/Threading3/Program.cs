﻿//ThreadPool
namespace ThreadingExamples3
{
    class MainClass
    {
        static void PoolFunc1(object o)
        {
            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine("First Thread " + i.ToString() + o.ToString());
            }
        }
        static void PoolFunc2(object o)
        {
            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine("Second Thread " + i.ToString());
            }
        }
        static void Main()
        {

            //ThreadPool.QueueUserWorkItem(new WaitCallback(PoolFunc1), "aaa");
            ThreadPool.QueueUserWorkItem(PoolFunc1, "aaa");
            ThreadPool.QueueUserWorkItem(new WaitCallback(PoolFunc2));

            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine("Main Thread " + i.ToString());
            }
            int workerthreads, iothreads;

            //ThreadPool.GetAvailableThreads(out workerthreads, out iothreads);
            ////ThreadPool.SetMinThreads()
            ////ThreadPool.SetMaxThreads
            //ThreadPool.GetMinThreads(out workerthreads, out iothreads);
            ThreadPool.GetMaxThreads(out workerthreads, out iothreads);
            Console.WriteLine(workerthreads);
            Console.WriteLine(iothreads);

            Console.ReadLine();
        }
    }
}