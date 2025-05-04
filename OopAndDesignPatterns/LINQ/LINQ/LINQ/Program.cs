var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

//var result = from num  in numbers
//            where num > 3
//            select num;

var result = numbers.ToList();
var NumsGreaterThan3 = numbers.Where(x => x > 3).ToList(); //Used to filter a sequence based on a predicate.
var evenNums = numbers.Where(x => x % 2 == 0).ToList();
var oddNums = numbers.Where(x => x % 2 != 0).ToList();
var squares = numbers.Select(x => x * 2).ToList(); //Projects each element of a sequence into a new form.
var orderedByAsc = numbers.OrderBy(x => x > 5).ToList();
var orderedByDesc = numbers.OrderByDescending(x => x  ).ToList();

var firstOrDefault = numbers.FirstOrDefault(x => x % 2 == 0); //Returns the first value or default value of declared datatype
var groupedNumbers = numbers.GroupBy(x => x % 2 == 0).Select(group => new {Key = group.Key, Values = group.ToList()}).ToList();
foreach (var num in orderedByAsc)
{
    Console.Write($"{num} ");
}