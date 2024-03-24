// See https://aka.ms/new-console-template for more information
using DetailingCenterDbLib;
using static System.Net.Mime.MediaTypeNames;



Employee employee = new Employee()
{
    Name = "Тимур",
    Surname = "Дудин",
    Patronymic = "Александрович",
    Phone = "897587332525",
    Education = "Среднее проффесиональное",
    Position = "Директор",
    Salary = "100000"
};
Repository repository = new Repository();
repository.SaveEmployee(employee);
bool isSuccess = repository.TryGetEmployeesFromDB(out Employee[] employees);

repository.DeleteEmployee(employees[1]);

Console.WriteLine("Hello, World!");