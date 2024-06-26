namespace Assignment01
{
    internal class Employee
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.name = "Ashwin";
            emp.empNo = 101;
            emp.basic = 50000;
            emp.deptNo = 5;
            Console.WriteLine("Employee Name: " + emp.name);
            Console.WriteLine("Employee no: " + emp.empNo);
            Console.WriteLine(emp.basic);
            Console.WriteLine("Dept no: " + emp.deptNo);

        }

        private String name;

        public String Name
        {
            set
            {
                if (value != null)
                    name = value;
            }


            get { return name; }
        }

        private int empNo;

        public int EmpNo
        {
            set
            {
                if ((empNo = value) != 0)
                    empNo = value;
            }

            get { return empNo; }
        }

        private decimal basic;

        public decimal Basic
        {
            set
            {
                if (value > 0 && value < 100000)
                    basic = value;
                else basic = 0;
            }
            get { return basic; }
        }

        private short deptNo;

        public short DeptNo
        {
            set
            {
                if (value >= 0)
                    value = deptNo;
                else value = 0;
            }

            get { return deptNo; }

        }
    }
}
