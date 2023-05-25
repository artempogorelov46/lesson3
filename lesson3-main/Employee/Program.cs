internal class Program {

    public static void Main(string[] args)
    {
        Console.WriteLine("Введите номер задания: 1-6 - задания первого дня, 7-9, задания второго дня");
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
        void test6()
        {   foreach(var emp in employees)
            {
                Console.WriteLine($"ФИО сотрудника: {emp._id} {emp.Fio}");
            }
            
        }
        void test7()
        {
            Console.WriteLine("Введите процент на который увеличится зарплата работников: ");
            double percent = double.Parse(Console.ReadLine()); // метод не статичный потому что они обьявляются вне             
                                                               // тела static void Main, и в таком случае не будет виден List employee
            double salary;
            foreach ( var emp in employees)
            {
                salary = emp.Salary + (emp.Salary / percent);
        
                Console.WriteLine($"Теперь зарплата сотрудника {emp.Fio} составляет: {salary} рублей");
            }
         
        }
      void test9()
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
        

        int choice = Int32.Parse(Console.ReadLine());
       
        switch (choice)
        {  
            case 1:
                test1();
                break;
            case 2:
                test2();
                break;
            case 3:
                test3();
                break;
            case 4:
                test4();
                break;
            case 5:
                test5();
                break;
            case 6:
                test6();
                break;
            case 7:
                test7();
                break;
            case 8:
                Console.WriteLine("Введите номер метода: ");
                int cho = Int32.Parse(Console.ReadLine());
                switch(cho){
                    case 1:
                   
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                }
                break;
            case 9:
                test9();
                break;
            case 10:

                break;
          
        }
    }
}