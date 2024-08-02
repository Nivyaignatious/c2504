static int GetNthTermOfSeries(int N) 
    {
        int term = 21;  
        int difference = 1;
        for (int I = 1; I <= N; I++) 
        {
            if( I == N )
            {
                break;
            }
            //
            term = term + difference;
            difference = difference + 1;
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
        TestGetNthTermOfSeries();
        Console.WriteLine("-----End TestGetNthTermOfSeries-----");
        Console.WriteLine("Press any key to contine...");
        Console.ReadKey();
    }
}
