using System;

namespace ConsoleApp
{
    // 3. Person class
    class Person
    {
        public int Pid { get; set; }
        public string Pname { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

        public Person(int pid, string pname, int age, string gender)
        {
            Pid = pid;
            Pname = pname;
            Age = age;
            Gender = gender;
        }
    }

    // 4. Interface for multiple inheritance
    interface ICustomer
    {
        void SetDetails(int customerId, string customerName);
        void GetDetails();
    }

    // 2. Customer class implementing ICustomer
    class Customer : ICustomer
    {
        private int customerId;
        private string customerName;

        public void SetDetails(int customerId, string customerName)
        {
            this.customerId = customerId;
            this.customerName = customerName;
        }

        public void GetDetails()
        {
            Console.WriteLine($"Customer ID: {customerId}, Customer Name: {customerName}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 1. Program using "is operator"
            object obj = "Hello";
            if (obj is string)
            {
                Console.WriteLine("Object is a string");
            }

            // 5. Read 2 numbers and perform operations
            Console.Write("Enter first number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Addition: {num1 + num2}");
            Console.WriteLine($"Subtraction: {num1 - num2}");
            Console.WriteLine($"Multiplication: {num1 * num2}");

            if (num2 != 0)
                Console.WriteLine($"Division: {num1 / (double)num2}");
            else
                Console.WriteLine("Cannot divide by zero");

            Console.WriteLine($"Biggest: {Math.Max(num1, num2)}");
            Console.WriteLine($"Smallest: {Math.Min(num1, num2)}");

            // 6. Read number and display multiplication table
            Console.Write("Enter a number to display its multiplication table: ");
            int tableNum = int.Parse(Console.ReadLine());
            Console.WriteLine($"Multiplication table for {tableNum}:");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{tableNum} * {i} = {tableNum * i}");
            }

            // 7. Read number and generate Fibonacci series
            Console.Write("Enter the number of terms for Fibonacci series: ");
            int numTerms = int.Parse(Console.ReadLine());
            int first = 0, second = 1, next;
            Console.Write($"Fibonacci Series up to {numTerms} terms: ");
            for (int i = 0; i < numTerms; i++)
            {
                Console.Write($"{first} ");
                next = first + second;
                first = second;
                second = next;
            }
            Console.WriteLine();

            // 8. Generate factorial value
            Console.Write("Enter a number to calculate its factorial: ");
            int factNum = int.Parse(Console.ReadLine());
            int factorial = 1;
            for (int i = 1; i <= factNum; i++)
            {
                factorial *= i;
            }
            Console.WriteLine($"Factorial of {factNum} is: {factorial}");

            // 9. Display yesterday's date
            DateTime yesterday = DateTime.Today.AddDays(-1);
            Console.WriteLine($"Yesterday's date: {yesterday.ToShortDateString()}");

            // 10. Read date of birth and display age
            Console.Write("Enter your date of birth (yyyy-MM-dd): ");
            DateTime dob = DateTime.Parse(Console.ReadLine());
            int age = DateTime.Today.Year - dob.Year;
            if (DateTime.Today < dob.AddYears(age)) age--;
            Console.WriteLine($"Your age is: {age}");

            // Creating and using customer object
            Customer customer = new Customer();
            customer.SetDetails(1001, "John Doe");
            customer.GetDetails();

            Console.ReadKey();
        }
    }
}
