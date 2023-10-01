Random rnd = new Random();

int cpuRandom;

bool loopActive = true;

while (true)
{
    cpuRandom = rnd.Next(1, 4);
    //Console.Write($"The generated number is: {cpuRandom}");
    Console.WriteLine("Make a guess. Enter a number 1 - 3");

    int userNumber = Int32.Parse(Console.ReadLine());

    if(userNumber == cpuRandom)
    {
        Console.WriteLine("Congratulations, you won!");
        //loopActive = false;
        break;
    }
    else
    {
        Console.WriteLine("Oops. Try again.");
    }
}

Console.WriteLine("Have a nice day!");