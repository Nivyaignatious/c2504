static void PrintSeries1(int numOfTerms)
    {
        int term = 10;
        int I = 1;
        do 
        {
            if (0 == numOfTerms)
            {
                break;
            }
            Console.Write($"{term} ");
            term = term + 2;

            I++;
        } while (I <= numOfTerms) ;
    }
    
    static void TestPrintSeries1()
    {
        Console.Write("Enter number of terms:");
        int numOfTerms = int.Parse(Console.ReadLine());
        Console.Write("Series: ");
        PrintSeries1(numOfTerms);
        Console.WriteLine();
    }

    static void Main(string[] args) //user: p
    {
        Console.WriteLine("--------------TestPrintSeries1...--------------");
        TestPrintSeries1();
        Console.WriteLine("--------------End TestPrintSeries1...--------------");
        Console.WriteLine("Press any key to contine...");
        Console.ReadKey();
    }
}
