namespace DefaultImplentationOfInterfaces1
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            Class1 objClass1 = new Class1();
            //if you give a def imple code, it is not available from objClass1
            //objClass1.Select(); //NOT AVAILABLE


            //call the def imple code
            (objClass1 as IDbFunctions).Select();
        }
    }
    public interface IDbFunctions
    {
        void Insert();
        void Update();
        void Delete();
        void Select()
        {
            Console.WriteLine("default implementation code of Select");
        }
    }
    public class Class1 : IDbFunctions
    {
        public void Display()
        {
            Console.WriteLine("display from class1");
        }
        public void Delete()
        {
            Console.WriteLine("idb.delete from class1");
        }
        public void Insert()
        {
            Console.WriteLine("idb.Insert from class1");
        }
        public void Update()
        {
            Console.WriteLine("idb.update from class1");
        }
    }
}

namespace DefaultImplentationOfInterfaces2
{
    internal class Program
    {
        static void Main2(string[] args)
        {
            Class1 objClass1 = new Class1();
            //if class1 implements Select also, then it is available from objClass1
            objClass1.Select(); //AVAILABLE

            //calls code from Class1
            (objClass1 as IDbFunctions).Select();
        }
    }
    public interface IDbFunctions
    {
        void Insert();
        void Update();
        void Delete();
        void Select()
        {
            Console.WriteLine("default implementation code of Select");
        }
    }
    public class Class1 : IDbFunctions
    {
        public void Display()
        {
            Console.WriteLine("display from class1");
        }
        public void Delete()
        {
            Console.WriteLine("idb.delete from class1");
        }
        public void Insert()
        {
            Console.WriteLine("idb.Insert from class1");
        }
        public void Update()
        {
            Console.WriteLine("idb.update from class1");
        }
        public void Select()
        {
            Console.WriteLine("idb.select from class1");
        }
    }
}


namespace DefaultImplentationOfInterfaces3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 objClass1 = new Class1();
            //if class1 implements Select explicitly, Method 1 is not available
            //objClass1.Select(); //NOT AVAILABLE

            //calls code from Class1
            (objClass1 as IDbFunctions).Select();
        }
    }
    public interface IDbFunctions
    {
        void Insert();
        void Update();
        void Delete();
        void Select()
        {
            Console.WriteLine("default implementation code of Select");
        }
    }
    public class Class1 : IDbFunctions
    {
        public void Display()
        {
            Console.WriteLine("display from class1");
        }
        public void Delete()
        {
            Console.WriteLine("idb.delete from class1");
        }
        public void Insert()
        {
            Console.WriteLine("idb.Insert from class1");
        }
        public void Update()
        {
            Console.WriteLine("idb.update from class1");
        }

        //if there are multiple copies of select, use explicit implementation
        void IDbFunctions.Select()
        {
            Console.WriteLine("idb.select from class1");
        }
    }
}