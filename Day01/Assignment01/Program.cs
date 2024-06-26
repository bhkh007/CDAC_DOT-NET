namespace Assignment01
{
    internal class Employee
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.name = "Ashwin";
            emp.empNo = 101;
            Console.WriteLine("Employee Name: " +emp.name);
            Console.WriteLine("Employee no: "+emp.empNo);
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
                if((empNo = value) != 0)
                    empNo = value;
            }

            get { return empNo; }
        }
    }
}
