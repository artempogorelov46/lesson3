internal class Program {

    public static void Main(string[] args)
    {

        List<Employee> employees = new()
        {
            new Employee("Погорелов Артём Денисович", 1, 46430.42),
            new Employee("Монтус Михаил Иванович", 2, 25335.42),
            new Employee("Дугин Даниил Романович", 2, 15355.42),
            new Employee("Реброва Светлана Вадимовна", 3, 25353.42),
            new Employee("Плетнёва Елизавета Дмитриевна", 3, 46362.42),
            new Employee("Клима Екатерина Михайловна", 1, 46346.42),
            new Employee("Ламтюгина Олеся Ивановна", 4, 36643.42),
            new Employee("Косых Иван Андреевич", 5, 25355.42),
            new Employee("Орехов Владислав Владиславович", 4, 23635.42),
            new Employee("Нерсесян Артур Родионович", 5, 23655.42)
        };

        void test1()
        {
            foreach (var emp in employees)
            {
                Console.WriteLine($"Cотрудник под номером {emp._id} - {emp.Fio}, работающий в отделе " +
                    $"{emp.Department} получает зарплату в размере" +
                    $" {emp.Salary}");
            }
        }
        void test2()
        {
            double sum = 0;
            foreach(Employee emp in employees)
            {
                sum += emp.Salary;
            }
            Console.WriteLine($"Сумма затрат на зарплаты в месяц: {sum}");

        }
        void test3()
        {
                Console.WriteLine($"Человек с самой минимальной зарплатой {employees.Min(e => e.Salary + "рублей: " + e.Fio)} " );
        }
        void test4()
        {
            Console.WriteLine($"Человек с самой максимальной зарплатой {employees.Max(e => e.Salary+ "рублей: " + e.Fio)} ");
        }
        void test5()
        {
            Console.WriteLine($"Среднее значение зарплат: {employees.Average(e => e.Salary)}");
        }

        test1();
        test2();
        test3();
        test4();
        test5();
    }
    
}