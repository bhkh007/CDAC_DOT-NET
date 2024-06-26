using System;

namespace ConstructorsAndObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Constructors cons = new Constructors();

        }
    }

    public class Constructors
    {
        public Constructors()
        {
            Console.WriteLine("Constructor is called");
        }
    }
}
