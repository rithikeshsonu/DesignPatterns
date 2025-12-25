namespace LINQ
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Department { get; set; } = string.Empty ;
        public string City { get; set; } = string.Empty;
        public decimal Salary { get; set; }
        public DateTime JoinDate { get; set; }
    }
    public class Employees
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DepartmentId { get; set; }
        public decimal Salary { get; set; }
        public DateTime JoinDate { get; set; }
    }

    public class Departments
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
