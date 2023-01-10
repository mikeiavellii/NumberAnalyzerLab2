Console.WriteLine("Welcome to Grand Circus' Number Analyzer. Who am I speaking with?");
string n = Console.ReadLine();
Console.WriteLine($"Nice to meet you {n}");
bool y = true;
do
{
    Console.WriteLine("Please enter in an interger between 1 and 100.");
    int x = int.Parse(Console.ReadLine());
    if (x >= 1 && x <= 100)
    {
        if (x < 60 && x % 2 != 0)
        {
            Console.WriteLine($"{x} is odd and less than 60, {n}.");
        }
        else if (x <= 24 && x % 2 == 0)
        {
            Console.WriteLine($"{x} is even and less than 25, {n}.");
        }
        else if (x > 24 && x <= 60 && x % 2 == 0)
        {
            Console.WriteLine($"{x} is even and between 26 and 60 inclusive, {n}.");
        }
        else if (x > 60 && x % 2 == 0)
        {
            Console.WriteLine($"{x} is even and greater than 60, {n}.");
        }
        else if (x > 60 && x % 2 != 0)
        {
            Console.WriteLine($"{x} is odd and greater than 60, {n}.");
        }

        Console.WriteLine("Would you like to continue analyzing numbers? Respond in either a yes or a no.");
        string response = Console.ReadLine();
        if (response.ToLower() == "yes" || response.ToLower() == "y")
        {
            y = true;
        }
        else
        {
            Console.WriteLine($"Thanks for using our Number Analyzer program, {n}. Have a great day or don't. It's a free country.");
            y = false;
            break;
        }
    }
    else
    {
        Console.WriteLine($"You don't follow directions well, do you {n}?");
    }
}
while (true);


//If the integer entered is odd and less than 60, print the number entered and “Odd and less than 60.”

//If the integer entered is even and in the inclusive range of 2 to 24, print “Even and less than 25.”

//If the integer entered is even and in the inclusive range of 26 to 60, print “Even and between 26 and 60 inclusive.”

//If the integer entered is even and greater than 60, print the number entered and “Even and greater than 60.”

//If the integer entered is odd and greater than 60, print the number entered and “Odd and greater than 60.”

//Ask for user information (ex. name) at the beginning of the application, and use it to refer to the user throughout the application.
//
//Add validation to guarantee that a user enters a positive integer between 1 and 100.
//____________________________________________________________________________________________________
//Set up the program to continue running with a prompt at the end to see if they want to stop. (hint: Loops)