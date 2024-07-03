namespace LinqExample2
{
    internal class Program
    {
        static List<Employee> listEmp = new List<Employee>();
        static List<Department> listDept = new List<Department>();
        public static void AddRecs()
        {
            listDept.Add(new Department { DeptNo = 10, DeptName = "SALES" });
            listDept.Add(new Department { DeptNo = 20, DeptName = "MKTG" });
            listDept.Add(new Department { DeptNo = 30, DeptName = "IT" });
            listDept.Add(new Department { DeptNo = 40, DeptName = "HR" });

            listEmp.Add(new Employee { EmpNo = 1, Name = "Vikram", Basic = 10000, DeptNo = 10, Gender = "M" });
            listEmp.Add(new Employee { EmpNo = 2, Name = "Vishal", Basic = 11000, DeptNo = 10, Gender = "M" });

            listEmp.Add(new Employee { EmpNo = 3, Name = "Abhijit", Basic = 12000, DeptNo = 20, Gender = "M" });
            listEmp.Add(new Employee { EmpNo = 4, Name = "Mona", Basic = 11000, DeptNo = 20, Gender = "F" });
            listEmp.Add(new Employee { EmpNo = 5, Name = "Shweta", Basic = 12000, DeptNo = 20, Gender = "F" });

            listEmp.Add(new Employee { EmpNo = 6, Name = "Sanjay", Basic = 11000, DeptNo = 30, Gender = "M" });
            listEmp.Add(new Employee { EmpNo = 7, Name = "Arpan", Basic = 10000, DeptNo = 30, Gender = "M" });

            listEmp.Add(new Employee { EmpNo = 8, Name = "Shraddha", Basic = 11000, DeptNo = 40, Gender = "F" });
        }

        static Employee GetAllEmployees(Employee obj)
        {
            return obj;
        }
        static void Main()
        {
            AddRecs();
            var emps = listEmp.Select(GetAllEmployees);
            var emps2 = listEmp.Select(delegate (Employee obj)
            {
                return obj;
            });
            var emps3 = listEmp.Select(obj => obj);
            //var emps = from emp in listEmp select emp;
            foreach (var item in emps2)
            {
                Console.WriteLine(item);
            }
        }
        static string GetName(Employee obj)
        {
            return obj.Name;
        }
        static void Main2()
        {
            AddRecs();
            //var emps = from emp in listEmp select emp.Name;
            var emps = listEmp.Select(GetName);
            var emps2 = listEmp.Select(delegate (Employee obj)
            {
                return obj.Name;
            });
            var emps3 = listEmp.Select(obj => obj.Name);

            foreach (var item in emps)
            {
                Console.WriteLine(item);
            }
        }
        static void Main3()
        {
            AddRecs();
            var emps = from emp in listEmp select new { emp.Name, emp.EmpNo };
            var emps2 = listEmp.Select(delegate (Employee obj)
            {
                return new { obj.Name, obj.EmpNo };
            });
            var emps3 = listEmp.Select(obj => new { obj.Name, obj.EmpNo });

            foreach (var item in emps)
            {
                Console.WriteLine(item.EmpNo);
                Console.WriteLine(item.Name);
            }
        }

        static bool IsBasicGreaterThan10000(Employee obj)
        {
            return obj.Basic > 10000;
            //if (obj.Basic > 10000)
            //    return true;
            //else
            //    return false;
        }
        static void Main4()
        {
            AddRecs();
            var emps = from emp in listEmp
                       where emp.Basic > 10000
                       select emp;

            var emps2 = listEmp.Where(IsBasicGreaterThan10000);
            var emps3 = listEmp.Where(delegate (Employee obj)
            {
                return obj.Basic > 10000;
            });
            var emps4 = listEmp.Where(obj => obj.Basic > 10000);

            foreach (var emp in emps)
            {
                Console.WriteLine(emp);
            }

            Console.ReadLine();

        }
        static void Main4a()
        {
            AddRecs();

            //var emps1 = listEmp.Where(obj => obj.Basic > 10000);
            //var emps2 = listEmp.Where(obj => obj.Basic > 10000).Select(obj => obj);
            //var emps3 = listEmp.Select(obj => obj).Where(obj => obj.Basic > 10000);


            //var emps2 = listEmp.Where(obj => obj.Basic > 10000).Select(obj => obj.Name);
            //error     //var emps3 = listEmp.Select(obj => obj.Name).Where(obj => obj.Basic > 10000);

            var emps2 = listEmp.Where(obj => obj.Basic > 10000).Select(obj => obj.Basic);
            // var emps3 = listEmp.Select(obj => obj.Basic).Where(obj => obj.Basic > 10000);
            //var emps3 = listEmp.Select(obj => obj.Basic).Where(obj => obj > 10000);



            foreach (var emp in emps2)
            {
                Console.WriteLine(emp);
            }

            Console.ReadLine();

        }
        static void Main5()
        {
            AddRecs();


            var emps = from emp in listEmp
                           //where emp.Basic > 10000
                       orderby emp.Name
                       select emp;

            var empsa = listEmp.OrderBy(emp => emp.Name);

            //var emps = from emp in listEmp
            //           orderby emp.Name descending
            //           select emp;
            var empsb = listEmp.OrderByDescending(emp => emp.Name);

            //var emps = from emp in listEmp
            //           orderby emp.DeptNo ascending, emp.Name descending
            //           select emp;
            //var empsc = listEmp.OrderBy(emp => emp.DeptNo).OrderByDescending(emp => emp.Name); //WRONG
            var empsc = listEmp.OrderBy(emp => emp.DeptNo).ThenByDescending(emp => emp.Name); //WRONG



            foreach (var emp in emps)
            {
                Console.WriteLine(emp);
            }
            Console.ReadLine();

        }
        static void Main6a()
        {
            AddRecs();



            var emps = from emp in listEmp
                       join dept in listDept
                             on emp.DeptNo equals dept.DeptNo
                       select emp;

            var emps1 = from emp in listEmp
                        join dept in listDept
                              on emp.DeptNo equals dept.DeptNo
                        select dept;

            var emps2 = from emp in listEmp
                        join dept in listDept
                              on emp.DeptNo equals dept.DeptNo
                        select new { emp, dept };

            var emps3 = from emp in listEmp
                        join dept in listDept
                              on emp.DeptNo equals dept.DeptNo
                        select new { emp.Name, dept.DeptName };
            foreach (var item in emps2)
            {
                Console.WriteLine(item.emp.Name);
                Console.WriteLine(item.dept.DeptName);

            }
            foreach (var item in emps2)
            {
                Console.WriteLine(item.emp.Name);
                Console.WriteLine(item.dept.DeptName);
            }
            foreach (var item in emps3)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.DeptName);
            }
            Console.ReadLine();
        }
        static void Main6()
        {
            AddRecs();

            //var emps = from emp in listEmp
            //           join dept in listDept
            //                 on emp.DeptNo equals dept.DeptNo
            //           select emp;

            //IEnumerable<TInner> ---> listDept ---> IEnumerable<Department>

            //var emps = from  in 
            //           join  in 
            //                 on equals 
            //           select emp;
            var emps = listEmp.Join(listDept, emp => emp.DeptNo, dept => dept.DeptNo, (emp, dept) => emp);
            var emps2a = listEmp.Join(listDept, emp => emp.DeptNo, dept => dept.DeptNo, (emp, dept) => emp);
            var emps2b = listEmp.Join(listDept, emp => emp.DeptNo, dept => dept.DeptNo, (emp, dept) => dept);
            var emps2c = listEmp.Join(listDept, emp => emp.DeptNo, dept => dept.DeptNo, (emp, dept) => emp.DeptNo);
            var emps2d = listEmp.Join(listDept, emp => emp.DeptNo, dept => dept.DeptNo, (emp, dept) => dept.DeptNo);
            var emps2e = listEmp.Join(listDept, emp => emp.DeptNo, dept => dept.DeptNo, (emp, dept) => new { emp, dept });
            var emps2f = listEmp.Join(listDept, emp => emp.DeptNo, dept => dept.DeptNo, (emp, dept) => new { emp.Name, dept.DeptName });

            foreach (var item in emps2e)
            {
                Console.WriteLine(item.emp.Name);
                Console.WriteLine(item.dept.DeptName);

            }
            foreach (var item in emps2f)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.DeptName);
            }
        }
    }

    public class Employee
    {
        public int EmpNo { get; set; }
        public string Name { get; set; }
        public decimal Basic { get; set; }
        public int DeptNo { get; set; }
        public string Gender { get; set; }
        public override string ToString()
        {
            string s = Name + "," + EmpNo.ToString() + "," + Basic.ToString() + "," + DeptNo.ToString();
            return s;
        }
    }
    public class Department
    {
        public int DeptNo { get; set; }
        public string DeptName { get; set; }
    }

}