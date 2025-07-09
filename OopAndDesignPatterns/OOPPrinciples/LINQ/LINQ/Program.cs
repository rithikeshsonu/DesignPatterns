using LINQ;

int[] numbers = [1, 2, 3, 4, 5, 6, 6, 7, 7, 8, 9, 10];
List<int> evens = numbers.Where(x => x % 2 == 0).ToList();
var greaterThan5 = numbers.Where(x => x > 5);
var squares = numbers.Select(x => x * x);
var maximumNumber = numbers.Max();
var minimumNumber = numbers.Min();
var sumOfAllNumbers = numbers.Sum();
var countNumsGreaterThan5 = numbers.Count(x => x > 5);
var ascending = numbers.Order();
var descending = numbers.OrderByDescending(x => x);
var unique = numbers.Distinct().ToList();
var firstEven = numbers.First(x => x % 2 == 0);
var isAnyNumberGreaterThan20 = numbers.Any(x => x > 1);
var IsAllNumbersPositive = numbers.All(x => x > 0);
string[] words = ["Apple", "Banana", "Avocado", "Mango"];
var aWords = words.Where(x => x.StartsWith('A')).ToList();
var grouped = words.GroupBy(x => x.Length);
var first3 = words.Take(3);
var skip2 = words.Skip(2);

List<string> list1 = ["A", "B"];
List<string> list2 = ["B", "C"];

var intersect = list1.Intersect(list2);
var union = list1.Union(list2);
var except = list1.Except(list2);

//✅ Level 3: LINQ with Custom Objects (21–30)
List<Student> students = new()
{
    new Student { Id = 1, Name = "Amit", Marks = 80 },
    new Student { Id = 2, Name = "Rita", Marks = 95 },
    new Student { Id = 3, Name = "John", Marks = 45 },
    new Student { Id = 4, Name = "Sam", Marks = 70 },    
    new Student { Id = 5, Name = "Ram", Marks = 70 },

};
//21.Get students with marks > 60.
var passed = students.Where(x => x.Marks > 60);
//22.Get student names only.
var studentNames = students.Select(x => x.Name).ToList();
//23.Order students by marks.
var orderByMarksAscending = students.OrderBy(x => x.Marks);
var orderByMarksDescending = students.OrderByDescending(x => x.Marks);
//24.Group students by pass/fail.
var groupStudentsByPassFail = students.GroupBy(x => x.Marks >= 60 ? "Pass" : "Fail");

//25.Get student with highest marks.
var studentWithHighestMarks = students.OrderByDescending(x => x.Marks).FirstOrDefault();
//26.Count how many students failed.
var failedStudentsCount = students.Count(x => x.Marks < 60);

//27.Get average marks.
var averageMarks = students.Average(x => x.Marks);

//28.Check if all students passed.
var IsAllStudentsPassed = students.All(x => x.Marks >= 60);

//29.Get student names in uppercase.
var studentNamesInUpperCase = students.Select(x =>  x.Name.ToUpperInvariant()).ToList();

//30.Get distinct marks.
var distinctMarks = students.Select(x => x.Marks).Distinct();

//✅ Level 4: Advanced Scenarios(31–40)
//31.Get top 3 students.
var top3Students = students.OrderByDescending(x => x.Marks).Take(3).ToList();

//32.Get second highest scorer.
var secondHighestScorer = students.OrderByDescending(x => x.Marks).Skip(1).FirstOrDefault();

List<ClassInfo> classes = new()
{
    new ClassInfo { StudentId = 1, ClassName = "A" },
    new ClassInfo { StudentId = 2, ClassName = "B" },
    new ClassInfo { StudentId = 4, ClassName = "C" }
};

//33.Join students and classes.
var joinStudentsAndClasses = students.Join(classes,
    s => s.Id,
    d => d.StudentId,
    (s, d) => new { s.Name, d.ClassName }).ToList();

//34.Group students by first letter of name.
var groupStudentsByFirstLetterOfName = students.GroupBy(x => x.Name[0]);

//35.Select ANONYMOUS TYPE: name and grade.
var result = students.Select(x => new
{
    x.Name,
    Grade = x.Marks >= 60 ? "Pass" : "Fail"
});
//36.Get last student alphabetically.

var lastStudentAlphabetically = students.OrderByDescending(x => x.Name).FirstOrDefault();
//37.Find if a student named "John" exists.
var checkIfNameExists = students.Any(x => x.Name == "John");

//38.Find index of a student with marks 70.
var indexOfStudent = students.FindIndex(x => x.Marks == 70);

//39.Chunk students into groups of 2.
var chunks = students.Select((s, i) => new {s, Index = i}).GroupBy(x => x.Index/2).Select(g => g.Select(x => x.s).ToList()).ToList();

//40.Flatten a list of lists.
List<List<int>> nested = new() { new() { 1, 2 }, new() { 3, 4 } };
var flat = nested.SelectMany(x => x).ToList();

//✅ Level 5: Miscellaneous & Tricky(41–50)

//41.Reverse a list using LINQ.
var reverse = numbers.Reverse().ToList();

//42.Convert a list to dictionary (Id → Name).
var dict = students.ToDictionary(x => x.Id, x => x.Name);


//43.Get element at index 2 safely.
var elementAtSecondIndex = numbers.Skip(2).FirstOrDefault();

//44.Get frequency of each number.
var frequency = numbers.GroupBy(x => x).Select(
    g => new 
    {
        Number = g.Key, 
        Count = g.Count()
    }).ToList();

//45.Compare two lists for equality.
var areListsEqual = list1.OrderBy(x => x).SequenceEqual(list2.OrderBy(x => x));

//46.Find duplicates in a list.
var duplicatesInList = numbers.GroupBy(x => x).Where(g => g.Count() > 1).Select(x => x.Key);

//47.Find the longest word.

var longestWord = words.OrderByDescending(x => x.Length).FirstOrDefault();

//48. Get distinct characters in a word list.
var distinctChars = words.SelectMany(x => x).Distinct().ToList();

//49.Group numbers by even and odd.
var groupNumbersByOddAndEven = numbers.GroupBy(x => x % 2 == 0 ? "Even" : "Odd").ToList();

//50.Convert list of strings to comma-separated string.
string csv = string.Join(',' , words);


//🔍 Scenario - Based LINQ Interview Questions

//1.Find employees who have not submitted timesheets
List<int> allEmployees = new() { 1, 2, 3, 4, 5 };
List<int> submittedEmployees = new() { 2, 4, 5 };

List<int> notSubmittedEmployees = allEmployees.Except(submittedEmployees).ToList();

//🔸 3.Find duplicate names in a list of strings
List<string> names = new() { "John", "Jane", "John", "Alex", "Alex" };
var duplicateNames = names.GroupBy(n => n)
                            .Where(g => g.Count() > 1)
                            .Select(x => x.Key)
                            .ToList();

List<Employee> employees = new()
{
    new Employee { Id = 1, Name = "Amit", Department = "IT", City = "Mumbai", Salary = 75000, JoinDate = DateTime.Now.AddDays(-90) },
    new Employee { Id = 2, Name = "Priya", Department = "HR", City = "Delhi", Salary = 60000, JoinDate = DateTime.Now.AddDays(-30) },
    new Employee { Id = 3, Name = "Raj", Department = "IT", City = "Mumbai", Salary = 85000, JoinDate = DateTime.Now.AddDays(-15) },
    new Employee { Id = 4, Name = "Sonal", Department = "Finance", City = "Pune", Salary = 70000, JoinDate = DateTime.Now.AddDays(-45) },
    new Employee { Id = 5, Name = "John", Department = "IT", City = "Bangalore", Salary = 92000, JoinDate = DateTime.Now.AddDays(-120) },
    new Employee { Id = 6, Name = "Meena", Department = "HR", City = "Delhi", Salary = 64000, JoinDate = DateTime.Now.AddDays(-75) },
    new Employee { Id = 7, Name = "Ali", Department = "Finance", City = "Chennai", Salary = 72000, JoinDate = DateTime.Now.AddDays(-10) },
    new Employee { Id = 8, Name = "Ravi", Department = "Sales", City = "Pune", Salary = 55000, JoinDate = DateTime.Now.AddDays(-5) },
    new Employee { Id = 9, Name = "Neha", Department = "Sales", City = "Bangalore", Salary = 58000, JoinDate = DateTime.Now.AddDays(-60) },
    new Employee { Id = 10, Name = "Sara", Department = "IT", City = "Hyderabad", Salary = 80000, JoinDate = DateTime.Now.AddDays(-20) }
};

//🔸 2.Return departments with more than 3 employees
var departmentsWithMoreThan3Employees = employees.GroupBy(x => x.Department).Where(g => g.Count() > 3).ToList();

//🔸 4.Find top N earners from employee list
var top4Earners = employees.OrderByDescending(x => x.Salary).Take(4).ToList();

//🔸 8.Retrieve employees with the 2nd highest salary
var employeeWith2ndHighestSalary = employees.OrderByDescending(x => x.Salary).Skip(1).Select(x => x.Name).First();

//🔸 15.Get names of employees joined in last 30 days
var employeesJoinedInLast30Days = employees.Where(x => (DateTime.Now - x.JoinDate).Days <= 30).ToList();

//🔸 18.From list of employees, find the department with the highest average salary
var departmentWithHighestSalary = employees.GroupBy(x => x.Department)
                                           .Select(g => new
                                            {   
                                                Department = g.Key,
                                                AvgSalary = g.Average(e => e.Salary),
                                            })
                                           .OrderByDescending(x => x.AvgSalary).First();

//🔸 19.Get employee names starting with a vowel
var employeeNamesStartingWithVowel = employees.Where(x => "AEIOUaeiou".Contains(x.Name[0])).ToList();

//🔸 20.Find the most common city employees belong to
var mostCommonCityInEmployees = employees
                            .GroupBy(x => x.City)
                            .OrderByDescending(x => x.Count())
                            .FirstOrDefault()?.Key;


//✅ Practical LINQ Questions with Answers
//🔸 1.Get names of employees in 'IT' department, ordered by salary descending
var namesOfEmployeesInITDept = employees.Where(x => x.Department == "IT").OrderByDescending(x => x.Salary).Select(x => x.Name).ToList();

//🔸 2.Find the average salary of employees in each department
var averageSalaryInEachDept = employees.GroupBy(x => x.Department).Select(g => new
{
    Department = g.Key,
    AverageSalary = g.Average(a => a.Salary)
}).ToList();

//🔸 3.Find employees who joined in the last 60 days
var employeesJoinedInLast60Days = employees.Where(x => (DateTime.Now - x.JoinDate).Days <= 60).ToList();

//🔸 4.Find the department with the highest number of employees
var deptWithHighestNoOfEmployees = employees.GroupBy(x => x.Department).OrderByDescending(x => x.Count()).Select(g => new
{
    Department = g.Key,
    Count = g.Count()
}).First();

//🔸 5.List all distinct departments
var distinctDepartments = employees.Select(x => x.Department).Distinct().Order().ToList();

//🔸 6.Check if any employee earns more than ₹90,000
var employeeWithSalary90000 = employees.Where(x => x.Salary > 90000).Count() > 0;
bool employeeWithSalary9000UsingAny = employees.Any(x => x.Salary > 90000);

//🔸 7.Get the names of employees whose names start with 'S'
var employeeNamesStartingWithS = employees.Where(e => e.Name.StartsWith('S')).Select(x => x.Name).ToList();

//🔸 8.Group employees by city and count
var employeesByCityAndCount = employees.GroupBy(x => x.City).Select(g => new
{
    City = g.Key,
    Count = g.Count()
}).ToList();


//🔸 9.Find the employee(s) with the second highest salary
var empWith2ndHighestSalary = employees.Select(x => x.Salary).OrderByDescending(x => x).Distinct().Skip(1).FirstOrDefault();
var secondHighestSalariedEmployee = employees.Where(x => x.Salary == empWith2ndHighestSalary).ToList();

//🔸 10.Find total salary paid in each city
var totalSalaryInEachCity = employees.GroupBy(x => x.City).Select(g => new
{
    City = g.Key,
    Salary = g.Sum(x => x.Salary),
}).ToList();

//🔸 11.Find employees whose salary is above average
var averageSalary = employees.Average(x => x.Salary);
var employeesWithSalaryAboveAverage = employees.Where(x => x.Salary > averageSalary).Select(x => x.Name). ToList();

//🔸 12.Get employee count by department, only for departments with more than 1 employee
var departmentsWithMoreThan1Employee = employees
                                    .GroupBy(x => x.Department)
                                    .Where(g => g.Count() > 1)
                                    .Select(g => new{
                                        Department = g.Key,
                                        Count = g.Count()
                                    })
                                    .ToList();

//🔸 13.Print employee names joined after Jan 22, 2025

var employeesJoinedAfterJan12024 = employees.Where(x => x.JoinDate > new DateTime(2025, 1, 22)).Select(x=>x.Name).ToList();

//🔸 14.Return the name of the most recent joinee
var mostRecentJoinee = employees.OrderByDescending(x => x.JoinDate).Select(x => x.Name).FirstOrDefault();

//🔸 15.Get a list of cities where no one from 'Finance' department is working
var CitiesWithNoEmployeesInFinance = employees
                                .Where(x => x.Department != "Finance")
                                .Select(x => x.City)
                                .Distinct()
                                .ToList();


//🔸 16.Display top 3 highest paid employees per department
var top3HighestPaidPerDept = employees.GroupBy(x => x.Department).Select(g => new
{
    Dept = g.Key,
    Emps = g.Take(3).OrderByDescending(x=>x.Salary).ToList(),
}) .ToList();

var top3HighestPaidPerDeptUsingSelectMany = employees
                                            .GroupBy(x=> x.Department)
                                            .SelectMany(g => g
                                                .OrderByDescending(x => x.Salary)
                                                .Take(3))
                                            .ToList();

//🔸 17.Create a dictionary of Department → List of Employees
var deptDict = employees.GroupBy(x => x.Department).ToDictionary(g => g.Key, g => g.ToList());