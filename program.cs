class program

{
    public static void Main(string[] args)
    {
    Console.Clear();

    int guld = 50; 
    int pris = 10; 

    System.Console.WriteLine("Skapa din karaktär!"); //introduktionen


    System.Console.WriteLine("Vad heter din karaktär?"); //namn på karaktären
    string namn = Console.ReadLine();


    System.Console.WriteLine("Vilken klass vill du spela?"); //klass på gubben
    string klass = Console.ReadLine();


    System.Console.WriteLine("Vilket startvapen vill du ha?"); //startvapen till gubben
    string vapen = Console.ReadLine();


    System.Console.WriteLine("Hur många hälsodrycker vill du köpa?"); //hälsodrycker
    int dryck = int.Parse(Console.ReadLine());
    
    /*
    if (dryck > 5)
        {
            Console.WriteLine("Du har tyvärr inte råd med det!");
            Console.WriteLine("Skriv in ett nytt antal");
            dryck = int.Parse(Console.ReadLine());

        }
    else if (dryck < 0)
        {
            Console.WriteLine("Du kan inte sälja drycker, du har ju inga!");
            Console.WriteLine("Skriv hur många du vill köpa");
            dryck = int.Parse(Console.ReadLine());
        }
    else
        {
            Console.WriteLine("Det var ett bra antal drycker!");
        }
    
    Detta blev fel, alltså att den gav en massa pengar o lät dig sälja drycker,
    varje gång man la in fel nummer andra gången den frågade, jag ville försöka
    så att det alltid sa till en när man la in fel.
    */
    while (dryck < 0 || dryck > 5)
        {
            System.Console.WriteLine("ogiltigt antal!");
            System.Console.WriteLine("Du måste välja ett antal mellan 0-5!");
            System.Console.WriteLine("Välj ett nytt antal");

            dryck = int.Parse(Console.ReadLine());
        }

    //jag testade något nytt här som var lite kortare och som jag tror upprepar?
    //jag använde mig av "while" istället för if och else för att det ska upprepa

    int totalpris = dryck * pris;
    guld = guld - totalpris;

    Console.WriteLine();
    Console.WriteLine("===Karaktärskort!===");
    Console.WriteLine("Namn: " + namn);
    Console.WriteLine("Klass: " + klass);
    Console.WriteLine("Startvapen: " + vapen);
    Console.WriteLine("Hälsodrycker: " + dryck);
    Console.WriteLine("Guld kvar: " + guld + "g" );

    

    }

 }