// See https://aka.ms/new-console-template for more information
using DetailingCenterDbLib;

Console.WriteLine("Hello, World!");

Employee employee = new Employee()
{
    Name = "Alina",
    Surname = "Макарова"
};
Repository repository = new Repository();
repository.SaveEmployee(employee);