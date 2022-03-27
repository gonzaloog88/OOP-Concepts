using OOP_Concepts;

Console.WriteLine("OOP Concepts");
Console.WriteLine("============");
//try
//{
//    Console.WriteLine(new Date(2024, 2, 29));
//    Console.WriteLine(new Date(1974, 9, 23));
//    Console.WriteLine(new Date(1985, 11, 30));
//}
//catch (Exception error)
//{
//    Console.WriteLine(error.Message);
//}

Employee employee1 = new SalaryEmployee()
{
   Id = 1010,
   FirstName = "Rosa Imelda",
   LastName = "González Rodríguez",
   BirthDate = new Date(2000, 04, 28),
   HiringDate = new Date(2022, 03, 01),
   IsActive = true,
   Salary = 10000M
};
//Console.WriteLine(employee1);

Employee employee2 = new CommissionEmployee()
{
   Id = 1020,
   FirstName = "Juán José",
   LastName = "Rodríguez Galicia",
   BirthDate = new Date(1988, 04, 04),
   HiringDate = new Date(2022, 03, 02),
   IsActive = true,
   Sales = 500000M,
   CommissionPercentaje = 0.03F
};
//Console.WriteLine(employee2);

Employee employee3 = new HourlyEmployee()
{
   Id = 1030,
   FirstName = "Alicia",
   LastName = "García Cervantes",
   BirthDate = new Date(1970, 06, 21),
   HiringDate = new Date(2022, 03, 03),
   IsActive = true,
   HourValue = 50.0M,
   Hours = 123.5F
};
//Console.WriteLine(employee3);

Employee employee4 = new BaseCommissionEmployee()
{
   Id = 1040,
   FirstName = "Gonzalo",
   LastName = "Ortega García",
   BirthDate = new Date(1988, 02, 19),
   HiringDate = new Date(2022, 03, 04),
   IsActive = true,
   Base = 1200M,
   Sales = 100000,
   CommissionPercentaje = 0.05F
};
//Console.WriteLine(employee4);

ICollection<Employee> employees = new List<Employee>()
{
   employee1, employee2, employee3, employee4
};

decimal payroll = 0;
foreach (Employee employee in employees)
{
   Console.WriteLine(employee);
   payroll += employee.GetValueToPay();
}

Console.WriteLine("                                 =====================");
Console.WriteLine($"TOTAL                             {$"{payroll:C2}",20}");

Invoice invoice1 = new Invoice()
{
   Description = "iPhone13",
   Id = 1,
   Price = 17000M,
   Quantity = 2
};

Invoice invoice2 = new Invoice()
{
   Description = "Posta Premium",
   Id = 2,
   Price = 32000M,
   Quantity = 17.5F
};

Console.WriteLine(invoice1);
Console.WriteLine(invoice2);