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

while (true)
{
    Console.Clear();
    StoreInfo(); //skriver ut välkomstskärm med adress
    Console.WriteLine("Välj ett alternativ:\n1. Varor\n2. Avsluta");
    int menuChoice = Convert.ToInt32(Console.ReadLine());
    while (menuChoice == 1)
    {
        Console.Clear();
        Console.WriteLine("1. T-Shirts\n2. Muggar\n3. Gå tillbaka");
        int subMenuChoice = Convert.ToInt32(Console.ReadLine());
        switch(subMenuChoice)
        {
            case 1:
                DisplayTshirts(); //tshirts metod, lista och sortering
                break;
            case 2:
                DisplayMugs(); //Muggar metod, lista och sortering
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

List<Tshirt> TshirtGenerator(List<Tshirt> tshirts, string[] art, string[] size, string[] material)
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

List<Mug> MugGenerator(List<Mug> mugs, string[] art, string[] type)
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

void DisplayTshirts(){
    tshirtList.Sort();
    Console.Clear();
    Console.WriteLine("--------------T-SHIRTS----------------");
    Console.WriteLine("Motiv, Storlek, Material, Betyg, Pris");
    Console.WriteLine("--------------------------------------");
    foreach (Tshirt t in tshirtList)
    {
        Console.WriteLine(t.ProductArt + "     " + t.Size + "     " + t.Material + "     " +  + t.Rating + "     " + t.Price);
    }
    Console.ReadKey();
}

void DisplayMugs()
{
    mugList.Sort();
    Console.Clear();
    Console.WriteLine("-----------MUGGAR------------");
    Console.WriteLine("Motiv, Storlek, Betyg, Pris");
    Console.WriteLine("-----------------------------");
    foreach (Mug m in mugList)
    {
        Console.WriteLine(m.ProductArt + "     " + m.Type + "     " + m.Rating + "     " + m.Price);
    }
    Console.ReadKey();
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