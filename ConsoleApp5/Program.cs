using System.Xml.Linq;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>(1);

            for (int i = 0; i < 1; i++)
            {

                Console.WriteLine("Введите имя сотрудника");
                string name = Console.ReadLine();
                Console.WriteLine("Введите должность сотрудника");
                string post = Console.ReadLine();

                List<int> salarys = new List<int>(12);
                for (int j = 0; j< 12; j++)
                {
                    Console.WriteLine($"Введите зарплату за {j + 1} месяц");
                    int value = Convert.ToInt32(Console.ReadLine());
                    salarys.Add(value);
                }

                employees.Add(new Employee(name, post, salarys));

                foreach (int sal in salarys)
                {
                    Console.WriteLine(sal);
                }
            }
            foreach (Employee employee in employees)
                Console.WriteLine($"{employee.Name}, {employee.Post}, {employee.Salary}");

            //int max = 0;
            //Console.WriteLine($"Сотрудник с самой высокой зарплатой");
            //foreach (Employee p in employees)
            //{
            //    if (p.Salary > max)
            //        p.Salary = max;
            //    Console.WriteLine(p.Salary);
            //}
        }
    }
    //class Pokemon
    //{
    //    private int _health;
    //    private string _name;
    //    public int Health
    //    {
    //    set
    //    {
    //        if (value >= 0 && value < 100)
    //        {
    //            _health = value;
    //        }
    //    }
    //    get
    //    {
    //        return _health;
    //    }
    //    }
    //    public string Name
    //    {
    //    get
    //        {
    //            return Name;
    //        }
    //    }

    //    public Pokemon (int health)
    //    {
    //        Health = health;
    //        Name = name;
    //        Level = level;
    //    }
    //}
    class Employee
    {
        public string Name;
        public string Post;
        public List<int> Salary;
        public Employee(string name, string post, List <int> salary)
        {
            Name = name;
            Post = post;
            Salary = salary;
        }
        static int Get_Salary(int salary)
        {
            int srednee = salary / 12;
            return srednee;
        }
        static int Get_salarys(int salary)
        {
            foreach (int sal in salary)
                int ord_salary = Console.WriteLine(sal);
            return ord_salary;
        }
    }
}