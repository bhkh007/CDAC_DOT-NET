namespace Interfaces1
{
    internal class Program
    {
        static void Main1()
        {
            Class1 objClass1 = new Class1();
            objClass1.Display();
            //method 1 
            objClass1.Insert();
            objClass1.Delete();

            //method 2
            IDbFunctions oIDb;
            oIDb = objClass1;
            oIDb.Insert();
            oIDb.Delete();

            //method 3
            ((IDbFunctions)objClass1).Insert();
            ((IDbFunctions)objClass1).Delete();

            //method 4
            (objClass1 as IDbFunctions).Insert();
            (objClass1 as IDbFunctions).Delete();
        }
    }

    public interface IDbFunctions
    {
        void Insert();
        void Update();
        void Delete();
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



namespace Interfaces2
{
    internal class Program
{
    static void Main1()
    {
        Class1 objClass1 = new Class1();
        objClass1.Display();
        //method 1 
        objClass1.Insert();
        objClass1.Write();
        objClass1.Read();
          
            
            //method 2
            IDbFile oIDf;
        oIDf = objClass1;
        oIDf.Write();
        oIDf.Delete();
        oIDf.Read();

            //method 3
            ((IDbFile)objClass1).Read();
        ((IDbFile)objClass1).Write();

        //method 4
        (objClass1 as IDbFile).Read();
        (objClass1 as IDbFile).Write();
    }
}

public interface IDbFunctions
{
    void Insert();
    void Update();
    void Delete();
}

    public interface IDbFile
    {
        void Write();
        void Read();
        void Delete();
    }

    public class Class1 : IDbFunctions, IDbFile
{
    public void Display()
    {
        Console.WriteLine("display from class1");
    }
     void IDbFunctions.Delete()
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

        public void Write()
        {
            throw new NotImplementedException();
        }

        public void Read()
        {
            throw new NotImplementedException();
        }

        void IDbFile.Delete()
        {
            Console.WriteLine("idb.delete from class1");
        }
    }
}



namespace Interfaces3
{
    internal class Program
    {
        static void Main1()
        {
            Class1 o = new Class1();
            Class2 o2 = new Class2();
            //method 1
            o.Insert();
            o2.Insert();

            //method 2
            IDbFunctions oIDb;
            oIDb = o;
            oIDb.Insert();

            oIDb = o2;
            oIDb.Insert();


            //method 3
            ((IDbFunctions)o).Insert();

            //method 4
            (o as IDbFunctions).Insert();
        }
        static void Main()
        {
            Class1 o1 = new Class1();
            Class2 o2 = new Class2();
            InsertMethod(o1);
            InsertMethod(o2);
            Console.ReadLine();
        }
        static void InsertMethod(IDbFunctions oIDb) //can receive an object of any class that implements IDbFunctions
        {
            oIDb.Insert();
        }
    }
    public interface IDbFunctions
    {
        void Insert();
        void Update();
        void Delete();
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
    public class Class2 : IDbFunctions
    {
        public void Show()
        {
            Console.WriteLine("show from class1");
        }
        public void Delete()
        {
            Console.WriteLine("idb.delete from class2");
        }
        public void Insert()
        {
            Console.WriteLine("idb.Insert from class2");
        }
        public void Update()
        {
            Console.WriteLine("idb.update from class2");
        }
    }

}