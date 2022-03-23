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
Console.WriteLine(employee1);

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
Console.WriteLine(employee2);