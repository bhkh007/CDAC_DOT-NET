﻿

namespace OperatorOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Emp o1 = new Emp { EmpNo = 1, Basic = 10000, DeptNo = 10, Name = "Vikram" };
            Emp o2 = new Emp { EmpNo = 2, Basic = 20000, DeptNo = 20, Name = "Pradeep" };

            o1 = o1 + 5;
            //o1 = Emp.operator+(o1,5) --- .net (csharp)
            //o1 = o1.operator+(5) --c++

            Emp o3;
            //o3 = o1 * o2;
            //o3 = Emp.operator*(o1,o2)

            Console.WriteLine(o1.DeptNo);

            int i = 10;
            i = i + 5;

        }
    }
    public class Emp
    {
        public static Emp operator +(Emp o1, int i)
        {
            Emp retval = new Emp();
            retval.EmpNo = o1.EmpNo;
            retval.Basic = o1.Basic;
            retval.Name = o1.Name;
            retval.DeptNo = o1.DeptNo + i;

            return retval;
        }
        public int EmpNo { get; set; }
        public string Name { get; set; }
        public decimal Basic { get; set; }
        public int DeptNo { get; set; }
        public override string ToString()
        {
            return $"Empno={EmpNo}, Name={Name}, Basic={Basic}, DeptNo={DeptNo}";
        }
    }

}