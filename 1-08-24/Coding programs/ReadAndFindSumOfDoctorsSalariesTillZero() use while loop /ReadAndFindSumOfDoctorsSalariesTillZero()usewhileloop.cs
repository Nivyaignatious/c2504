namespace ReadAndFindSumOfDoctorsSalariesTillZero___use_while_loop
{
    internal class Program
    {
        static void ReadAndFindSumOfDoctorsSalariesTillZero()
        {
            int sum = 0;
            int salary;

            Console.WriteLine("Enter salary:");
            salary = int.Parse(Console.ReadLine());

            while (salary != 0)
            {
                if (salary < 0)
                {
                    Console.WriteLine("Input valid salary");
                    salary = int.Parse(Console.ReadLine());
                    continue;
                }

                sum += salary;
                Console.WriteLine("Enter salary:");
                salary = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Total sum of salaries: " + sum);
        }
        static void Main(string[] args)
        {
            ReadAndFindSumOfDoctorsSalariesTillZero();
        }
    }
}
