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
bool isSuccess = repository.TryGetEmployees(out Employee[] employees);

Console.WriteLine("Hello, World!");