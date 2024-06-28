namespace Arrays
{
    internal class Program
    {
        static void Main()
        {
            Employee[] arrEmps = new Employee[5];

            //arrEmps[0] = new Employee();
            //arrEmps[1] = new Employee();
            //arrEmps[2] = new Employee();
            //arrEmps[3] = new Employee();
            //arrEmps[4] = new Employee();

            for (int i = 0; i < arrEmps.Length; i++)
            {
                //arrEmps[i] = new Employee();
                //arrEmps[i].EmpNo
                Console.WriteLine(i);
            }
        }


        static void Main5()
        {
            //jagged
            int[][] arr = new int[4][];

            /*for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new int[x];
            }*/

            arr[0] = new int[3]; // arr[0][0] arr[0][1] arr[0][2]
            arr[1] = new int[4]; // arr[1][0] arr[1][1] arr[1][2] arr[1][3]
            arr[2] = new int[2];//  arr[2][0] - arr [2][1]
            arr[3] = new int[3];//  arr[3][0] arr[3][1] arr[3][2]

            
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write("enter value for subscript [{0}][{1}] : ", i, j);
                    arr[i][j] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine();
                Console.WriteLine();
            }
            

            Console.WriteLine();
            Console.WriteLine();
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.WriteLine("value for subscript {0},{1} is {2}  ", i, j, arr[i][j]);

                }
            }
            Console.ReadLine();

        }


            static void Main4()
        {
            int[,] arr = new int[5, 3];
            //Console.WriteLine(arr.Length);
            //Console.WriteLine(arr.Rank);
            //Console.WriteLine(arr.GetLength(0));
            //Console.WriteLine(arr.GetLength(1));
            //Console.WriteLine(arr.GetUpperBound(1));

            //arr[0,0]  arr[0,1]   arr[0,2]
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    //Console.Write($"enter value for index {i},{j} : "); //string interpolation
                    Console.Write($"enter value for student index {i}, subject index {j} : "); //string interpolation
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.WriteLine($"value for index arr[{i},{j}] is {arr[i, j]} "); //string interpolation
                }
            }
        }


        static void Main3(string[] args)
        {

            int[] arr = new int[5] { 10, 20, 30, 40, 50 };
            int[] arr2 = { 10, 20, 30, 40, 50, 60 };

            //Array.Clear(arr);
            int position = Array.IndexOf(arr, 30);
            int position1 = Array.IndexOf(arr, 35);
            int position2 = Array.LastIndexOf(arr, 50);
            int position3 = Array.BinarySearch(arr2, 60);
            //if(position <0)//not found

            Array.Copy(arr, arr2, arr.Length);
            Array.ConstrainedCopy(arr, 0, arr2, 0, arr.Length);

            Array.Sort(arr);
            Array.Reverse(arr);

            Console.WriteLine(position);
            Console.WriteLine(position1);
            Console.WriteLine(position2);
            Console.WriteLine(position3);
        }

        static void Main2(string[] args)
        {

            int[] arr = new int[5];
            //arr[0]..arr[4]
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("enter value for index " + i); //string concatenation
               // Console.WriteLine("enter value for index {0}", i); //placeholder
                //Console.Write($"enter value for index {i} : "); //string interpolation
                //arr[i] = int.Parse(Console.ReadLine());
                arr[i] = Convert.ToInt32(Console.ReadLine());//same meaning  as line above
            }
            foreach (int item in arr)
            {
                Console.WriteLine(item);
            }
        }
        static void Main1(string[] args)
        {
            int[] arr = { 10,90,70,60,50};
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
                
            }
            Console.WriteLine();

            Array.Sort(arr);
            foreach (int item in arr)
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
