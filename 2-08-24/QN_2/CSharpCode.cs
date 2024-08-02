static void PrintSeries1(int numOfTerms)
    {
        int term = 10;
        int I = 1;
        while ( I <= numOfTerms  )
        {
            Console.Write($"{term} ");
            term = term + 2;
            I++;
        }
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
