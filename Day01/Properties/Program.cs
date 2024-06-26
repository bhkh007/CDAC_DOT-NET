using System.Security.Cryptography;

namespace Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Properties props = new Properties();
            props.I = 101;
            Console.WriteLine(props.I);
        }
    }


    //Why Properties : for validations
    // to write code as setter getter but call them as variable
    // do not use setter getter in DOT Net
    public class Properties
    {
        private int i;
        public int I
        {
            set
            {
                if (value > 100)
                    i = value;
                else
                    Console.WriteLine(i = 0);
            }

            get { return i; }

        }
    }
}
