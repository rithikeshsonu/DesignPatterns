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


var res = aWords;