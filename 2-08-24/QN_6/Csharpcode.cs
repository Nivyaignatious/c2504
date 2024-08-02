 static int GetNthTermOfSeries(int N) 
    {
        int term = 21;  
        int difference = 1;
        int I = 1;
        do
        {
            if (I == N)
            {
                break;
            }
            //
            term = term + difference;
            difference = difference + 1;

            I++;
        } while (I <= N);
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
        Console.WriteLine("-----TestGGetNthTermOfSeries-----");
        TestGetNthTermOfSeries();
        Console.WriteLine("-----End TestGetNthTermOfSeries-----");
        Console.WriteLine("Press any key to contine...");
        Console.ReadKey();
    }
