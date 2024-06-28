using System.Collections;

namespace Collections
{
    internal class Program
    {
        static void Mains()
        {
            Stack<int> stack = new Stack<int>();

            Queue<int> queue = new Queue<int>();
        }



        static void Main()
        {
            SortedList<int, string> list = new SortedList<int, string>();
            list.Add(10, "Vikram");
            list.Add(40, "Ananya");
            list.Add(20, "Shweta");
            list.Add(30, "Harsh");

            foreach (KeyValuePair<int, string> item in list)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
            }

        }




        //generic collections
        static void Main5()
        {
            List<int> list = new List<int>();
            list.Add(1);

            foreach (int item in list)
            {
                Console.WriteLine(item);
            }
            List<Employee> emps = new List<Employee>();
            emps.Add(new Employee { EmpNo = 1, Name = "aaa" });
            emps.Add(new Employee { EmpNo = 2, Name = "bbb" });
            emps.Add(new Employee { EmpNo = 3, Name = "ccc" });
            foreach (Employee item in emps)
            {
                Console.WriteLine(item.Name);
            }
        }



        static void Main4()
        {
            Stack s = new Stack();
            s.Push(10);

            Console.WriteLine(s.Peek());
            Console.WriteLine(s.Pop());

            Queue q = new Queue();
            q.Enqueue(10);

            Console.WriteLine(q.Peek());
            Console.WriteLine(q.Dequeue());

        }


        static void Main3()
        {
            //Hashtable objDictionary = new Hashtable();
            SortedList objDictionary = new SortedList();
            objDictionary.Add(10, "Vikram");
            objDictionary.Add(40, "Ananya");
            objDictionary.Add(20, "Shweta");
            objDictionary.Add(30, "Harsh");

            objDictionary[10] = "changed value"; //update
            objDictionary[50] = "new value"; //added

            //bool isPresent = objDictionary.Contains(key);
            //bool isPresent = objDictionary.ContainsKey(key);
            //bool isPresent = objDictionary.ContainsValue(value);

            // objDictionary.GetKey(index)
            IList keys = objDictionary.GetKeyList();
            IList values = objDictionary.GetValueList();

            //objDictionary.IndexOfKey(key)
            //objDictionary.IndexOfValue(value)

            //objDictionary.Keys
            //objDictionary.Values

            //objDictionary.Remove(key)
            //objDictionary.RemoveAt(index)


            foreach (DictionaryEntry item in objDictionary)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
            }

        }



        static void Main2()
        {
            ArrayList objArrayList = new ArrayList();
            Console.WriteLine($"Count is {objArrayList.Count}, Capacity is {objArrayList.Capacity}");

            objArrayList.Add(1);
            Console.WriteLine($"Count is {objArrayList.Count}, Capacity is {objArrayList.Capacity}");
            objArrayList.Add(2);
            Console.WriteLine($"Count is {objArrayList.Count}, Capacity is {objArrayList.Capacity}");
            objArrayList.Add(3);
            Console.WriteLine($"Count is {objArrayList.Count}, Capacity is {objArrayList.Capacity}");
            objArrayList.Add(4);
            Console.WriteLine($"Count is {objArrayList.Count}, Capacity is {objArrayList.Capacity}");
            objArrayList.Add(5);
            Console.WriteLine($"Count is {objArrayList.Count}, Capacity is {objArrayList.Capacity}");
            objArrayList.Add(6);
            Console.WriteLine($"Count is {objArrayList.Count}, Capacity is {objArrayList.Capacity}");
            objArrayList.Add(7);
            Console.WriteLine($"Count is {objArrayList.Count}, Capacity is {objArrayList.Capacity}");
            objArrayList.Add(8);
            Console.WriteLine($"Count is {objArrayList.Count}, Capacity is {objArrayList.Capacity}");
            objArrayList.Add(9);
            Console.WriteLine($"Count is {objArrayList.Count}, Capacity is {objArrayList.Capacity}");

            objArrayList.TrimToSize();
            Console.WriteLine($"After Trim Count is {objArrayList.Count}, Capacity is {objArrayList.Capacity}");

        }



        static void Main1()
        {
            ArrayList objArrayList = new ArrayList();
            objArrayList.Add("Vikram");
            objArrayList.Add(10);

            //object = int  ---> boxing
            //int x = arrlst[0] unboxing

            objArrayList.Add(true);
            objArrayList.Add(1.23);

            objArrayList.Insert(0, "new");

            //objArrayList.AddRange(objArrayList2);
            //objArrayList.InsertRange(0,objArrayList2);

            objArrayList.Remove(10);
            objArrayList.RemoveAt(0);  //index
                                       //objArrayList.RemoveRange(index, count);
                                       //objArrayList.RemoveRange(0, 3);

            //IndexOf, LastIndexOf, BinarySearch

            //objArrayList.Clear
            //objArrayList.Clone ---TO DO - read up on Cloning in .net

            //object[] arr = new object[objArrayList.Count];
            //objArrayList.CopyTo(arr); //copies to an array

            //object[] arr2 = objArrayList.ToArray();

            ArrayList o2 = objArrayList.GetRange(0, 3);


            //objArrayList - 10,20,30,40,50,60
            //o2 - 100,200,300
            //after - 100,200,300,40,50,60
            objArrayList.SetRange(0, o2);

            objArrayList[0] = "changed value";
            //objArrayList.this[0] = "changed value";
            Console.WriteLine(objArrayList[0]);
            //Console.WriteLine(objArrayList.this[0]);

            Console.WriteLine(objArrayList.Count);
            foreach (object item in objArrayList)
            {
                Console.WriteLine(item);
            }

        }
    }

    public class Employee
    {
        public int EmpNo { get; set; }
        public string Name { get; set; }

    }
}
