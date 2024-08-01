namespace ReadAndCountDoctorsMin6DigitsSalariedwithout_array
{
    internal class Program
    {

        static bool IsDoctorSalaryMin6Digits(int doctorSalary)
        {
            int salary = doctorSalary;
            int count = 0;

            while (salary > 0)
            {
                count++;
                salary /= 10;
            }

            return count >= 6;
        }
        static int ReadAndCountDoctorsMin6DigitsSalaried()
        {
            int count = 0;
            Console.WriteLine("Enter number of salaries:");
            int N = int.Parse(Console.ReadLine());

            for (int I = 1; I <= N; I++)
            {
                Console.WriteLine("Enter salary:");
                int salary = int.Parse(Console.ReadLine());
                bool isMin6Digits = IsDoctorSalaryMin6Digits(salary);
                if (isMin6Digits)
                {
                    count++;
                }
            }

            return count;
        }
        static void Main(string[] args)
        {
            int result = ReadAndCountDoctorsMin6DigitsSalaried();
            Console.WriteLine("Number of doctors with at least 6 digit salary: " + result);
        }
    }
}
