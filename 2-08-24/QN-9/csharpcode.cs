static void Main(string[] args)
    {
        int N = 5;
        int row = 1;
        do
        {
            int spaces = N - row;
            int num = 1;
            int col = 1;
            do
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
            } while (col <= N);
            Console.WriteLine();
            row++;
        } while (row <= N);
    }
