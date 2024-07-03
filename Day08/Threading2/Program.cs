namespace ThreadingExamples2
{
    internal class Program
    {
        static void Main()
        {
            Thread t1 = new Thread(new ParameterizedThreadStart(Func1));
            Thread t2 = new Thread(Func2);
            t1.Start("aaa");

            //string[] arr = new string[] { "Hello", "World" };
            //t1.Start(arr);
            t2.Start("bbb");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Main : " + i);
            }
        }

        //1. Tuple/ValueTuple
        //2. create a class/struct and pass an obj of class/struct
        //3. pass an array/collection

        //4. dont pass anything. create an anon method/lambda/local func and access variables declared outside directly
       
        
        static void Func1(object obj)
        {
            //string[] arr = (string[])obj;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("First : " + i + obj.ToString());
            }

        }
        static void Func2(object obj)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Second : " + i + obj.ToString());
            }

        }

    }
}