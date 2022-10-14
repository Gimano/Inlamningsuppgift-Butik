using Inlämningsuppgift_Butik;

List<Tshirt> tshirtList = new List<Tshirt>();
List<Mug> mugList = new List<Mug>();
string[] productArt = new string[] {"Häst", "Bil", "Båt", "Blomma", "Fjäril", "Fågel", "Flygplan", "Skog", "Strand", "Berg", 
                                    "Äng", "Sol", "Måne", "Varg", "Fisk", "Orm", "Kattunge", "Katt", "Hund", "Hundvalp", 
                                    "Dinosaurie", "Fotbollsspelare", "Räv", "Elefant", "Älg", "Hjort", "Stad", "Taxi", "Hav", "Tårta"};
string[] mugType = new string[] { "Extra stor", "Stor", "Medium", "Liten", "Mini" };
string[] tshirtSize = new string[] { "XL", "L", "M", "S", "XS" };
string[] tshirtMaterial = new string[] { "Bomull", "Polyester", "Bomull och Polyester" };
string storeAddress = "Storgatan 1";
string businessAddress = "Bakgatan 3";

//fyller listorna med hjälp av metoder som också frågar hur många det ska vara i varje
tshirtList = TshirtGenerator(tshirtList, productArt, tshirtSize, tshirtMaterial);
mugList = MugGenerator(mugList, productArt, mugType);

//En första grundsortering av listorna
tshirtList.Sort();
mugList.Sort();

while (true)  //Huvudmenyn
{
    Console.Clear();
    StoreInfo(); //skriver ut välkomstskärm med adress
    Console.WriteLine("Välj ett alternativ:\n1. Varor\n2. Avsluta");
    int menuChoice = Convert.ToInt32(Console.ReadLine());
    while (menuChoice == 1)
    {
        Console.Clear();
        Console.WriteLine("1. T-Shirts\n2. Muggar\n3. Gå Tillbaka");
        int subMenuChoice = Convert.ToInt32(Console.ReadLine());
        switch(subMenuChoice)
        {
            case 1:
                OpenTshirts(); //Metod som visar lista av tshirts och sorterar listan
                break;
            case 2:
                OpenMugs(); //Metod som visar lista av muggar och sorterar listan
                break;
            case 3:
                menuChoice = 0;
                break;
            default:
                break;
        };
    };

    if (menuChoice == 2)
        break;
}

void StoreInfo()
{
    Console.WriteLine("-----------------------------------");
    Console.WriteLine("Välkommen till butiken!");
    Console.WriteLine($"Du kan besöka oss på {storeAddress}.");
    Console.WriteLine($"Faktureringsadress är {businessAddress}.");
    Console.WriteLine("-----------------------------------");
}

List<Tshirt> TshirtGenerator(List<Tshirt> tshirts, string[] art, string[] size, string[] material) //Fyller tshirtlistan med objekt
{
    Random random = new Random();
    List<Tshirt> filledTshirts = new List<Tshirt>();
    foreach(string a in art)
    {
        Tshirt tshirt = new Tshirt();
        tshirt.ProductArt = a;
        tshirt.Size = size[random.Next(5)];
        tshirt.Material = material[random.Next(3)];
        tshirt.Rating = random.NextDouble() * 10;
        tshirt.Price = random.Next(50, 401);
        filledTshirts.Add(tshirt);
    }
    return filledTshirts;
}

List<Mug> MugGenerator(List<Mug> mugs, string[] art, string[] type) //Fyller mugglistan med objekt
{
    Random random = new Random();
    List<Mug> filledMugs = new List<Mug>();
    foreach(string a in art)
    {
        Mug mug = new Mug();
        mug.ProductArt = a;
        mug.Type = type[random.Next(type.Length)];
        mug.Rating = random.NextDouble() * 10;
        mug.Price = random.Next(50, 201);
        filledMugs.Add(mug);
    }
    return filledMugs;
}

void OpenTshirts()
{
    while (true)
    {
        DisplayTshirtsList();
        Console.WriteLine(); 
        Console.WriteLine("Ändra Sortering");
        Console.WriteLine("1. Betyg - Högst överst");
        Console.WriteLine("2. Betyg - Lägst överst");
        Console.WriteLine("3. Motiv - A-Ö");
        Console.WriteLine("4. Motiv - Ö-A");
        Console.WriteLine("5. Pris - Dyrast överst");
        Console.WriteLine("6. Pris - Billigast överst");
        Console.WriteLine("7. Gå Tillbaka");
        int choice = int.Parse(Console.ReadLine());
        SortTshirts(choice);
        if (choice == 7)
            break;
    }
}

void DisplayTshirtsList()
{
    Console.Clear();
    Console.WriteLine("-------------------------------T-SHIRTS----------------------------------");
    Console.WriteLine("Motiv               Storlek   Material                 Betyg 0-10   Pris");
    Console.WriteLine("-------------------------------------------------------------------------");
    foreach (Tshirt t in tshirtList)
    {
        Console.WriteLine($"{t.ProductArt,-20}" + $"{t.Size,-10}" + $"{t.Material,-25}" + $"{t.Rating,-12}" + $"{t.Price + "Kr",-10}");
    }
}

void SortTshirts(int sortId)
{
    switch (sortId)
    {
        case 1:
            tshirtList.Sort();
            break;
        case 2:
            tshirtList = tshirtList.OrderBy(o => o.Rating).ToList();
            break;
        case 3:
            tshirtList = tshirtList.OrderBy(o => o.ProductArt).ToList();
            break;
        case 4:
            tshirtList = tshirtList.OrderByDescending(o => o.ProductArt).ToList();
            break;
        case 5:
            tshirtList = tshirtList.OrderByDescending(o => o.Price).ToList();
            break;
        case 6:
            tshirtList = tshirtList.OrderBy(o => o.Price).ToList();
            break;
        default:
            break;
    }
}

void OpenMugs()
{
    while (true)
    {
        DisplayMugsList();
        Console.WriteLine();
        Console.WriteLine("Ändra Sortering");
        Console.WriteLine("1. Betyg - Högst överst");
        Console.WriteLine("2. Betyg - Lägst överst");
        Console.WriteLine("3. Motiv - A-Ö");
        Console.WriteLine("4. Motiv - Ö-A");
        Console.WriteLine("5. Pris - Dyrast överst");
        Console.WriteLine("6. Pris - Billigast överst");
        Console.WriteLine("7. Gå Tillbaka");
        int choice = int.Parse(Console.ReadLine());
        SortMugs(choice);
        if (choice == 7)
            break;
    }
}

void DisplayMugsList()
{
    Console.Clear();
    Console.WriteLine("----------------------MUGGAR------------------------");
    Console.WriteLine("Motiv               Storlek       Betyg 0-10   Pris");
    Console.WriteLine("----------------------------------------------------");
    foreach (Mug m in mugList)
    {
        Console.WriteLine($"{m.ProductArt,-20}" + $"{m.Type,-14}" + $"{m.Rating,-12}" + $"{m.Price + "Kr",-10}");
    }
}

void SortMugs(int sortId)
{
    switch (sortId)
    {
        case 1:
            mugList = mugList.OrderByDescending(o => o.Rating).ToList();
            break;
        case 2:
            mugList.Sort();
            break;
        case 3:
            mugList = mugList.OrderBy(o => o.ProductArt).ToList();
            break;
        case 4:
            mugList = mugList.OrderByDescending(o => o.ProductArt).ToList();
            break;
        case 5:
            mugList = mugList.OrderByDescending(o => o.Price).ToList();
            break;
        case 6:
            mugList = mugList.OrderBy(o => o.Price).ToList();
            break;
        default:
            break;
    }
}

/*
             * 
             * 30 motiv för muggar och tshirts
             * 
             *  abstract klass varor:
             * string Motiv
             * double Snittbetyg från användare 0-10
             * decimal Pris
             * 
             *    tshirt klass:
             * string Storlek
             * string Material
             *    mugg klass:
             * string Typ
             * 
             * lista av varor och deras mängd
             * 
             * Metoder:
             * Navigering med piltangenter
             * Grafik
             * Sortering av listor
             * 
             * 
             * Metod:
             * Adress för butiksbesök
             * Adress för fakturering
             * 
             * Ska presentera butikens information och adress
             * 
             * Presentera tshirt-utbud sorterat efter snittbetyg, fallande (högst överst)
             * Presentera mugg-utbud sorterat efter snittbetyg, stigande (lägst överst)
            */