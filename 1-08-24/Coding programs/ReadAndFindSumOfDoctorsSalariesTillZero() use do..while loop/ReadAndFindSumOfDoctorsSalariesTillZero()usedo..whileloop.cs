namespace ReadAndFindSumOfDoctorsSalariesTillZero__usedowhile_loop
{
    internal class Program
    {
        static void ReadAndFindSumOfDoctorsSalariesTillZero()
        {
            int sum = 0;
            int salary;
            do
            {
                Console.WriteLine("Enter salary:");
                salary = int.Parse(Console.ReadLine());

                if (!(salary > 0 || salary == 0)) //Invalid salary
                {
                    Console.WriteLine("Input valid salary");
                    continue;
                }
                if (salary != 0)// Business Rule
                {
                    sum += salary;
                }
            } while (salary != 0);
            Console.WriteLine("Total sum of salaries: " + sum);
        }
        static void Main(string[] args)
        {
            ReadAndFindSumOfDoctorsSalariesTillZero();
        }
    }
}
