namespace EmployeeWageComputation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to EmployeeWageComputation!");
            const int IS_PRESENT = 1;
            Random random = new Random();
            int employeeInput=random.Next(0, 2);
            Console.WriteLine("Randome value:{0}", employeeInput);
            if (employeeInput==IS_PRESENT) 
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }   
        }
    }
}