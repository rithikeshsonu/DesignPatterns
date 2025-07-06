


using LINQ;
using System.Reflection.Emit;

int[] numbers = [1, 2, 3, 4, 5, 6, 6, 7, 7, 8, 9, 10];
var evens = numbers.Where(x => x % 2 == 0).ToList();
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
