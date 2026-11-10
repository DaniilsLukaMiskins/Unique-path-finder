using RobotPathFinder;
using System;

bool repeat = true;
int row=1, column=1;

while (repeat)
{
    while (0 != 1)  // while for entering and checking inputs for rows and colums
    {
        int errors = 0;
        Console.WriteLine("Enter rows:\n");
        string rowString = Console.ReadLine();

        try
        {
            row = Convert.ToInt32(rowString);
            if (row <= 0)
            {
                Console.WriteLine("Number must be > 0. Try again");
                continue;
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Input string is not a sequence of digits. Try again");
            continue;
        }
        catch (OverflowException)
        {
            Console.WriteLine("The number cannot fit in an Int32. Try again");
            continue;

        }

        Console.WriteLine("Enter columns:\n");
        string columnString = Console.ReadLine();

        try
        {
            column = Convert.ToInt32(columnString);
            if (column <= 0)
            {
                Console.WriteLine("Number must be > 0. Try again");
                continue;

            }

        }
        catch (FormatException)
        {
            Console.WriteLine("Input string is not a sequence of digits. Try again");
            continue;

        }
        catch (OverflowException)
        {
            Console.WriteLine("The number cannot fit in an Int32. Try again");
            continue;

        }
        break;

    }

    Robot myRobot = new Robot(row, column); //new object and answer
    Console.WriteLine("===========\nAnswer:");
    Console.WriteLine(myRobot.FindUniquePaths());
    Console.WriteLine("===========\n");

    Console.Write("Go again? Y for yes, N or anything else for no: "); // repeating
    string? go = Console.ReadLine();
    if (go?.ToUpper() != "Y")
    {
        repeat = false;
    }
    
}
