internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter the wall height");
        int height = GetHeightInput();

        PrintWall(height);

        Console.Readkey();

    }

    static int GetHeightInput()
    {
        int input;
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out input) && input >= 1 && input <= 8)
            {
                break; // Break
            }
            else
            {
                Console.WriteLine("Please enter a value between 1 and 8:");
            }
        }
        return input;
    }

    static void PrintWall(int height) // parameter for the height
    {
        for (int i = 0; i<=height ; i++)
        {
            for (k = 0; k = height - i; k++)
            {
                Console.Writeline(" ");
            }
            for (int j = 0; j < i ; j++)
            {
                Console.Write("#");
            }
            Console.WriteLine();
        }
    }

}