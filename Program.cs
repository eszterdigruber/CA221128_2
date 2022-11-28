Random rnd = new();

//feladatlap f1
Dolg01();

void Dolg01()
{
    Console.Write("karakterlánc: ");
    string str = Console.ReadLine();
    int rndNum = rnd.Next(10);
    Console.WriteLine($"a generált szám: {rndNum}");

    if (rndNum % 2 == 0)
    {
        for (int i = 0; i < rndNum; i++)
        {
            Console.Write($"{str} ");
        }
    }
    else
    {
        for (int i = 0; i < rndNum; i++)
        {
            Console.WriteLine(str);
        }
    }
}