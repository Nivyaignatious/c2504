
namespace ReadAndFindMinSalaryOfNDoctorswithout_array
{
    internal class Program
    {

        static int ReadAndFindMinSalaryOfNDoctors()
        {
            Console.WriteLine("Enter number of salaries:");
            int N = int.Parse(Console.ReadLine());
            int MinSalary = -1;

            for (int I = 1; I <= N; I++)
            {
                Console.WriteLine("Enter salary:");
                int salary = int.Parse(Console.ReadLine());
                if (I == 1)
                {
                    MinSalary = salary;
                    continue;
                }

                if (salary < MinSalary)
                {
                    MinSalary = salary;
                }
            }

            return MinSalary;
        }
        static void Main(string[] args)
        {
            int minSalary = ReadAndFindMinSalaryOfNDoctors();
            Console.WriteLine("The minimum salary is: " + minSalary);
        }
    }
}
