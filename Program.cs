Random rnd = new();

//feladatlap f1
Dolg01();
Dolg02();
Dolg03();

void Dolg03()
{
    int pontszam = 0;

    for (int i = 0; i < 8; i++)
    {
        int x = rnd.Next(10, 100);
        int y = rnd.Next(10, 100);
        if (rnd.Next(2) == 0) x *= -1;
        if (rnd.Next(2) == 0) y *= -1;

        Console.Write($"({i + 1}.) {x} + {y} = ");
        int pred = int.Parse(Console.ReadLine());

        if (pred == x + y) pontszam++;
    }
    Console.WriteLine($"az esetek {pontszam / 8f * 100:0.00}%-ában adtál helyes választ!");
}

void Dolg02()
{
    Console.Write("\nmaximálisan megengedett sebesség (kmph): ");
    int limit = int.Parse(Console.ReadLine());

    if (limit <= 0 || limit > 50)
    {
        Console.WriteLine("Ez a program csak 50 kmph sebességkorlátig tudja meghatározni a bírságot.");
    }
    else
    {
        Console.Write("tényleges sebesség (kmph) : ");
        int aktSeb = int.Parse(Console.ReadLine());
        if (aktSeb <= limit)
        {
            Console.WriteLine("nem lépted túl a sebességkorlátozast, nincs büntetés.");
        }
        else
        {
            int tullepes = aktSeb - limit;
            if (tullepes <= 15)
            {
                Console.WriteLine("a túllépés tűréshatárán belül van, nincs büntetés, de legyél óvatosabb!");
            }
            else
            {
                int birsag = 0;
                if (tullepes < 25) birsag = 30000;
                else if (tullepes < 35) birsag = 45000;
                else if (tullepes < 45) birsag = 60000;
                else if (tullepes < 55) birsag = 90000;
                else if (tullepes < 65) birsag = 130000;
                else if (tullepes < 75) birsag = 200000;
                else                    birsag = 300000;

                Console.WriteLine($"a megengedett sebességet {tullepes} kmphval haladtad meg a büntetés {birsag} Ft");
            }
        }
    }
}

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