using LINQ;

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

var res = 2;