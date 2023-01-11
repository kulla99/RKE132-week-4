
Random rnd = new Random();
int cpuRandom;

bool loopAvtice = true;

while (loopAvtice)
{
    cpuRandom = rnd.Next(1, 4);
    //Console.WriteLine($"cpu had generated {cpuRandom}");
    Console.WriteLine("make a guess. enter a number 1-3");
    int userNumber = Int32.Parse(Console.ReadLine());

    if(userNumber == cpuRandom)
    {
        Console.WriteLine("congratualatsion, you won");
        //loopAvtice = false;
        break;
    }else
    {
        Console.WriteLine("oops. try again");
    }
}
Console.WriteLine("have a nice day");
