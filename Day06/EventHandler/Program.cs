
namespace EventHandling1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 objClass1 = new Class1();
            objClass1.InvalidP1 += objClass1_InvalidP1;

            objClass1.P1 = 200;
        }
        static void objClass1_InvalidP1()
        {
            Console.WriteLine("event handled here");
        }

        static void Main1()
        {
            Class1 objClass1 = new Class1();
            //objClass1.InvalidP1 += ObjClass1_InvalidP1;
            //objClass1.InvalidP1 += Handler2;
            objClass1.P1 = 200;
            Console.WriteLine(objClass1.P1);

        }

        private static void ObjClass1_InvalidP1()
        {
            Console.WriteLine("event handled here");
        }
        private static void Handler2()
        {
            Console.WriteLine("event handled here - handler2");
        }
    }


    //step1 : create a delegate class that matches the event handling signature
    public delegate void InvalidP1EventHandler();

    public class Class1
    {
        //step 2 : declare the event of the delegate type
        //event is a delegate reference
        public event InvalidP1EventHandler InvalidP1;

        private int p1;
        public int P1
        {
            get
            {
                return p1;
            }
            set
            {
                if (value < 100)
                    p1 = value;
                else
                {
                    //step 3 : raise the event
                    if (InvalidP1 != null)
                        InvalidP1();
                }
            }
        }

    }
}
namespace EventHandling2
{
    internal class Program
    {


        static void Main1()
        {
            Class1 objClass1 = new Class1();
            objClass1.InvalidP1 += ObjClass1_InvalidP1;
            objClass1.P1 = 200;
        }

        private static void ObjClass1_InvalidP1(int InvalidValue)
        {
            Console.WriteLine("invalid value was " + InvalidValue);
        }
    }


    //step1 : create a delegate class that matches the event handling signature
    public delegate void InvalidP1EventHandler(int InvalidValue);

    public class Class1
    {
        //step 2 : declare the event of the delegate type
        //event is a delegate reference
        public event InvalidP1EventHandler InvalidP1;

        private int p1;
        public int P1
        {
            get
            {
                return p1;
            }
            set
            {
                if (value < 100)
                    p1 = value;
                else
                {
                    //step 3 : raise the event
                    if (InvalidP1 != null)
                        InvalidP1(value);
                }
            }
        }

    }
}