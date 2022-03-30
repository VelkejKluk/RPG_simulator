Random skills = new Random();
string[] vlst = { "STR", "DEX", "INT" };
string vlastnosti = vlst[skills.Next(0,3)];

Dictionary<string, int> slovnik = new Dictionary<string, int>()
{
    { "STR", 10},
    { "DEX", 10},
    { "INT", 10}

};

Console.Write("Zadejte jméno své postavy: ");
string jmeno = Console.ReadLine();

int cas = 10;
int level = 1;
int unava = 0;
while(true)
{
    Console.WriteLine($"Jsi unavený na {unava}%");
    Console.Write("Chcete jít na quest, nebo se jít vyspat? Q/V ");
    string iput1 = Console.ReadLine().ToLower();

    if (iput1 == "q")
    {
        Console.WriteLine($"Vydáváš se plnit úkol na {vlastnosti}, vrať se za {cas} sekund");
        Console.WriteLine("...");
        Thread.Sleep(cas*10);

        unava += 10;
        level = (level + 1);
        slovnik[vlastnosti] += 10;
        cas += 10;
        

    }
    else if (iput1 == "v")
    {
        Console.WriteLine($"{jmeno} bude spát ještě {unava} sekund, vrať se pak");
        Thread.Sleep(unava * 10);
        unava = 0;
        Console.WriteLine("Krásně jsi se vyspal");
        Console.WriteLine();
        continue;
    }
    else
    {
        Console.WriteLine("neplatná hodnota");

    }

    Console.WriteLine($"{jmeno} se z výpravy vrátil celý");
    Console.WriteLine("------------------------");
    Console.WriteLine($"{jmeno} má 1v1. {level} a vlastnosti:");
    foreach (var radekSlovniku in slovnik)
    {
        Console.WriteLine($"{radekSlovniku.Key} :  {radekSlovniku.Value}");
        
    }
    if (unava == 40)
    {
        Console.Clear();
        Console.WriteLine("Zemřel jsi únavou v boji. Přeji ti hodně štěstí příště...");
        break;

    }
    else
    {
        continue;
    }
}

