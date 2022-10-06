using Inlämningsuppgift_Butik;

List<Tshirt> tshirtList = new List<Tshirt>();
List<Mug> mugList = new List<Mug>();
//fyller listorna med hjälp av metoder som också frågar hur många det ska vara i varje

bool run = true;
while (run)
{
    Console.Clear();
    ButikInfo(); //skriver ut välkomstskärm med adress
    Console.WriteLine("Välj ett alternativ:\n1. Varor\n2. Avsluta");
    int menuChoice = Convert.ToInt32(Console.ReadLine());
    while (menuChoice == 1)
    {
        Console.Clear();
        Console.WriteLine("1. T-Shirts\n2. Muggar\n3. Gå tillbaka");
        int subMenuChoice = Convert.ToInt32(Console.ReadLine());
        if (subMenuChoice == 1)
        {
            subMenuChoice = 0;
            //tshirts metod, lista och sortering
        }
        else if (subMenuChoice == 2)
        {
            subMenuChoice = 0;
            //Muggar metod, lista och sortering
        }
        else if (subMenuChoice == 3)
        {
            subMenuChoice = 0;
            break;
        }

    };
    if (menuChoice == 2)
    {
        run = false;
    }
}

void ButikInfo()
{
    Console.WriteLine("-----------------------------------");
    Console.WriteLine("Välkommen till våran butik!");
    Console.WriteLine("Du kan besöka oss på Storagatan 1.");
    Console.WriteLine("Faktureringsadress är Smågatan 3.");
    Console.WriteLine("-----------------------------------");
}
/*
             * 
             * 30 motiv för muggar och tshirts
             * 
             *  interface varor:
             * string Motiv
             * double Snittbetyg från användare 1-10
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