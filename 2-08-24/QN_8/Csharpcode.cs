static void Main(string[] args)
    {
        int N = 5;
        int row = 1;
        while (row <= N)
        {
            int spaces = N - row;
            int num = 1;
            int col = 1;
            while (col <= N)
            {
                if (col <= spaces)
                {
                    Console.Write(" ");
                }
                else
                {
                    Console.Write(num++);
                }
                col++;
            }
            Console.WriteLine();
            row++;
        }
    }
