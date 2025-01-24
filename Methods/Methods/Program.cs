namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nFirst Employee");

            Employee[] emp = new Employee[2];

            Console.Write("TAX: ");
            Employee.TAX = Convert.ToDouble(Console.ReadLine());

            Employee e1 = new Employee();
            Console.Write("First Name: ");
            e1.FName = Console.ReadLine();

            Console.Write("Last Name: ");
            e1.LName = Console.ReadLine();

            Console.Write("Wage: ");
            e1.Wage = Convert.ToDouble(Console.ReadLine());

            Console.Write("LoggedHours: ");
            e1.LoggedHours = Convert.ToDouble(Console.ReadLine());
            emp[0] = e1;

            //----- Second Employee

            Console.WriteLine("\nSecond Employee");

            Employee e2 = new Employee();
            Console.Write("First Name: ");
            e2.FName = Console.ReadLine();

            Console.Write("Last Name: ");
            e2.LName = Console.ReadLine();

            Console.Write("Wage: ");
            e2.Wage = Convert.ToDouble(Console.ReadLine());

            Console.Write("LoggedHours: ");
            e2.LoggedHours = Convert.ToDouble(Console.ReadLine());
            emp[1] = e2;

            //   foreach (Employee e in emp)
            //   {
            //       var salary = e.Wage * e.LoggedHours;
            //       var taxAmount = salary * Employee.TAX;
            //       var netSalary = salary - (salary * Employee.TAX);

            //       Console.WriteLine($"-------------");

            //       Console.WriteLine($"\nFirst Name :{e.FName}");
            //       Console.WriteLine($"Last Name :{e.LName}");
            //       Console.WriteLine($"Wage :{e.Wage}");
            //       Console.WriteLine($"Logged Hours :{e.LoggedHours}");
            //       Console.WriteLine("=================");
            //       Console.WriteLine($"Salary :{salary}");
            //       Console.WriteLine($"Deductable Tax {Employee.TAX * 100}% Amount :${taxAmount}");

            //    Console.WriteLine($"Net Salary :{netSalary}\n");
            //  }

            // ======= Refactor salary slip application  ======

            foreach (Employee e in emp)
            {
                Console.WriteLine(e.PrintSlip());
            }
            // ***************************************************************
            //****************************************************************

            Demo d1 = new Demo();

            //Caller
            d1.DoSomthing();

            var z = 100 + d1.DoSomThing();   //primary expression z=300

            // ref
            var age = 18;
            d1.DoSomThing(ref age);// age is argument passed

            // out
            int num;
            d1.DoSomThing1(out num);

            var numString = "123456";
            int number;
            if (!int.TryParse(numString, out number))
            {
                Console.WriteLine("Invalid number");
            }
            else
            {
                Console.WriteLine($"you provided a valid number {number}");
            }


            //Method Overloading

            d1.Promote(100, "Amman-Istabul-Amman", "kampenski 3days/2night");

            // Expression Bodies Method
            var result = d1.IsEven(6);
            Console.WriteLine(result);   // true

            // Local Method 
            var numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            d1.PrintEven(numbers);

            Console.WriteLine();

            // Static Method

            Demo.PrintOdd(numbers);  // static Method is called by the name class.


            Console.ReadKey();
        }
    }

    public class Demo
    {
        // Method Syntax simple
        //<Access Modifier>  <Data Type>/void Method Name <(Parameter List)>
        // Serie of statement

        //1.
        //Callee
        public void DoSomthing()
        {
            Console.WriteLine("Do Somthing . . .");
        }

        //2.
        public int DoSomThing()
        {
            var x = 100;
            return x + x;
        }

        //3. ref
        public void DoSomThing(ref int age)  // age is parameter
        {
            age = age + 1;
        }

        //4. out
        public void DoSomThing1(out int number)
        {
            number = 100;
            number = number + 1;
        }

        //  Method Signiture  ( Name Parameter + Type + Parameter order)
        public void DoSomThing(int x, double y)
        {
            //....
        }
        public void DoSomThing(double y, int x)
        {
            //....
        }

        // Method Overloading (A common way to implementing polymorphism)

        public void Promote(double amount)
        {
            Console.WriteLine($"You've got a promotion of ${amount}");
        }
        public void Promote(double amount, string trip)
        {
            Console.WriteLine($"You've got a promotion of ${amount}and a trip {trip}");
        }
        public void Promote(double amount, string trip, string hotel)
        {
            Console.WriteLine($"You've got a promotion of ${amount} and a trip {trip} with {hotel}");
        }

        // Expression Bodies Method

        // public bool IsEven(int number) { return number % 2 == 0; }  <=>

        public bool IsEven(int number) => number % 2 == 0;



        // Local Method 

        public void PrintEven(int[] original)
        {
            foreach (int n in original)
            {
                if (IsEven(n))
                    Console.Write(n + " ");

            }
            bool IsEven(int number) => number % 2 == 0;

        }


        // Static Method

        public static void PrintOdd(int[] original)
        {
            foreach (int n in original)
            {
                if (IsOdd(n))
                    Console.Write(n + " ");

            }

        }

        static bool IsOdd(int number) => !(number % 2 == 0); // static method deal only with static members

    }
}