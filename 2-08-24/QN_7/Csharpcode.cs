static void PrintNumTriangleMirroredRightAngle(int N)
    { 
        for(int I = 1; I <= N; I++ )
        { 
            for(int J = 1; J <= N-I; J++)
            {
                Console.Write("  "); //2 spaces
            }
            for(int J = 1; J <= I; J++)
            {
                Console.Write($"{J} ");//num and space
            }
            Console.WriteLine();//new line 
        }
    }
  
   
    static void TestPrintNumTriangleMirroredRightAngle()
    {
        Console.Write("Enter number of lines:");
        int N = int.Parse(Console.ReadLine());
        PrintNumTriangleMirroredRightAngle(N);
    }
    static void Main(string[] args) //user: p
    {
        Console.WriteLine("-----TestPrintNumTriangleMirroredRightAngle-----");
        TestPrintNumTriangleMirroredRightAngle();
        Console.WriteLine("-----End TestPrintNumTriangleMirroredRightAngle-----");
        Console.WriteLine("Press any key to contine...");
        Console.ReadKey();
    }
}

OR------
      static void Main(string[] args)
    {
        for (int row = 1; row <= 5; row++)
        {
            int spaces = 5 - row;
            int num = 1;
            for (int col = 1; col <= 5; col++)
            {
                if (col <= spaces)
                    Console.Write(" ");
                else
                    Console.Write(num++);
            }
            Console.WriteLine();
        }
    }
