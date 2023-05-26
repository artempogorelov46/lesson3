internal class Program {

    public static void Main(string[] args)
    {
        Console.WriteLine("Введите номер задания: 1-6 - задания первого дня, 7, 8 (1-6) 9, задания второго дня");
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

        void EmployeeInfo()
        {
            foreach (var emp in employees)
            {
                Console.WriteLine($"Cотрудник под номером {emp._id} - {emp.Fio}, работающий в отделе " +
                    $"{emp.Department} получает зарплату в размере" +
                    $" {emp.Salary}");
            }
        }
        void SalarySum()
        {
            double sum = 0;
            foreach(Employee emp in employees)
            {
                sum += emp.Salary;
            }
            Console.WriteLine($"Сумма затрат на зарплаты в месяц: {sum}");

        }
        void EmployeerMinSalary()
        {
                Console.WriteLine($"Человек с самой минимальной зарплатой {employees.Min(e => e.Salary + "рублей: " + e.Fio)} " );
        }
        void EmployeerMaxSalary()
        {
            Console.WriteLine($"Человек с самой максимальной зарплатой {employees.Max(e => e.Salary+ "рублей: " + e.Fio)} ");
        }
        void SalaryAverage()
        {
            Console.WriteLine($"Среднее значение зарплат: {employees.Average(e => e.Salary)}");
        }
        void EmployeesFIO()
        {   foreach(var emp in employees)
            {
                Console.WriteLine($"ФИО сотрудника: {emp._id} {emp.Fio}");
            }
            
        }
        void SalaryIndex()
        {
            Console.WriteLine("Введите процент на который увеличится зарплата работников: ");
            double percent = double.Parse(Console.ReadLine()); 
                                                              
            double salary;
            foreach ( var emp in employees)
            {
                salary = emp.Salary + (emp.Salary / percent);
        
                Console.WriteLine($"Теперь зарплата сотрудника {emp.Fio} составляет: {salary} рублей");
            }
         
        }
        void MinSalaryDeparment()
        {
            Console.WriteLine("Введите номер отдела: ");
           double dep_choice = Double.Parse(Console.ReadLine());
            foreach (var emp in employees)
            {
                if(emp.Department == dep_choice)
                {
                    Console.WriteLine($" {emp.Fio}  {emp.Salary}");
                }
            }
        }
        void MaxSalaryDepartment()
        {
            Console.WriteLine("Введите номер отдела: ");
            int dep_choice = Int32.Parse(Console.ReadLine());
            foreach (var emp in employees)
            {
                if (emp.Department == dep_choice)
                {
                    Console.WriteLine($" ");
                }
            }
        }
      void SalaryLessThanNumber()
        {
            Console.WriteLine("Введите число:");
            double expected_salary = double.Parse(Console.ReadLine());
            
            foreach (var emp in employees)
            {  if(emp.Salary < expected_salary)
                Console.WriteLine($"Cотрудник под номером {emp._id} - {emp.Fio}, работающий в отделе " +
                    $"{emp.Department} получает зарплату в размере" +
                    $" {emp.Salary}");
            }
        }
        void SalaryMoreThanNumber()
        {
            Console.WriteLine("Введите число:");
            double expected_salary = double.Parse(Console.ReadLine());

            foreach (var emp in employees)
            {
                if (emp.Salary > expected_salary)
                    Console.WriteLine($"Cотрудник под номером {emp._id} - {emp.Fio}, работающий в отделе " +
                        $"{emp.Department} получает зарплату в размере" +
                        $" {emp.Salary}");
            }
        }

        int choice = Int32.Parse(Console.ReadLine());
       
        switch (choice)
        {  
            case 1:
                EmployeeInfo();
                break;
            case 2:
                SalarySum();
                break;
            case 3:
                EmployeerMinSalary();
                break;
            case 4:
                EmployeerMaxSalary();
                break;
            case 5:
                SalaryAverage();
                break;
            case 6:
               EmployeesFIO();
                break;
            case 7:
                SalaryIndex();
                break;
            case 8:
                MinSalaryDeparment();
                break;
            case 9:
                MaxSalaryDepartment();
                break;
            case 10:
                break;
            case 11:
                break;
            case 12:
                break;
            case 13:
                break;
            case 14:
                SalaryLessThanNumber(); 
                break;
            case 15:
                SalaryMoreThanNumber();
                break;
          
        }
    }
}