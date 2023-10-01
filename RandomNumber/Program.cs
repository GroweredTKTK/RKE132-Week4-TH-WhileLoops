Random rnd = new Random();

int myrandomNum;

int randomSum = 0;

for (int i = 0; i < 15; i++)
{
    myrandomNum = rnd.Next(0, 11);
    randomSum = randomSum + myrandomNum;
    Console.WriteLine($"My random number is: {myrandomNum}");
}
Console.WriteLine($"Random sum total: {randomSum}");