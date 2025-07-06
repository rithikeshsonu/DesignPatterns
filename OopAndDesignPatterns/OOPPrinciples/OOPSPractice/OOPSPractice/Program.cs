using OOPSPractice.Exercises;

#region Encapsulation - BankAccount
var account = new BankAccount();
account.Deposit(1000);
account.Withdraw(500);
Console.WriteLine($"Balance: {account.GetBalance()}");
#endregion

#region Abstraction - Employee
var emp1 = new FullTimeEmployee { Name = "Bob", MonthlySalary = 20000 };
var emp2 = new PartTimeEmployee { Name = "Jack", HourlyRate = 10, HoursWorked = 4 };
emp1.GetDetails();
Console.WriteLine($"Full Time Employee Salary: {emp1.CalculateSalary()}");
emp2.GetDetails();
Console.WriteLine($"Part time Employee Salary: {emp2.CalculateSalary()}");
#endregion

#region Shape - InheritanceAndPolyMorphism
Shape s = new Shape();
s.Draw();
Shape s2 = new Circle();
s2.Draw();
Shape s3 = new Rectangle();
s3.Draw();
Shape s4 = new Triangle();
s4.Draw();

List<Shape> shapes =
[
    new Shape(),
    new Circle(),
    new Triangle(),
    new Rectangle(),
];
foreach (var item in shapes)
{
    item.Draw();
}
#endregion

#region Interface-IDriveable
IDriveable carDrive = new Car();
carDrive.Start();
carDrive.Stop();
IDriveable bikeDrive = new Bike();
bikeDrive.Start();
bikeDrive.Stop();
#endregion

#region Constructor-OverLoading - Book
Book b1 = new Book("Clean code", "Uncle bob", 20.10, "1111");
Console.WriteLine($"{b1.Title} By {b1.Author}");
#endregion

#region OverLoading-OverRiding
Calculator calculator = new();
Console.WriteLine(calculator.Add(1, 2));
Console.WriteLine(calculator.Add(2.4, 4));
Logger fileLogger = new FileLogger();
fileLogger.Log();
#endregion