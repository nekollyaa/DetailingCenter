// See https://aka.ms/new-console-template for more information
using DetailingCenterDbLib;



Employee employee = new Employee()
{
    Name = "Виктор",
    Surname = "Макаров"
};
Repository repository = new Repository();
repository.SaveEmployee(employee);
bool isSuccess = repository.TryGetEmployees(out Employee[] employees);

Console.WriteLine("Hello, World!");