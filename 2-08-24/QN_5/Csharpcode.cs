static int GetNthTermOfSeries(int N) 
    {
        int term = 21;  
        int difference = 1;
        int I = 1;
        while ( I <= N ) 
        {
            if( I == N )
            {
                break;
            }
            //
            term = term + difference;
            difference = difference + 1;

            I++;
        }
        return term;
    }
    
    static void TestGetNthTermOfSeries()
    {
        Console.Write("Enter number of terms:");
        int N = int.Parse(Console.ReadLine());
        int nthTerm = GetNthTermOfSeries(N);
        Console.WriteLine($"Nth term is {nthTerm}"); 
    }
    static void Main(string[] args) //user: p
    {
        Console.WriteLine("-----TestGetNthTermOfSeries-----");
        GetNthTermOfSeries();
        Console.WriteLine("-----End GetNthTermOfSeries-----");
        Console.WriteLine("Press any key to contine...");
        Console.ReadKey();
    }
}
