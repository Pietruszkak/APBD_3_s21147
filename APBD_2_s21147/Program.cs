// See https://aka.ms/new-console-template for more information
using APBD_2_s21147.Classes;
using APBD_2_s21147.Exceptions;

Console.WriteLine("Hello, World!");
/*
#region Section 1
//Objects
//-------------------------------------------------Stworzenie kontenera danego typu
Container cc1 = new CoolingContainer(0, 10, 10, 10, 700, new ProductType("Bananas", 13.3), 15);
Container lc1 = new LiquidContainer(0, 10, 10, 10, 800, LiquidType.Dangerous);
Container gc1 = new GasContainer(0, 10, 10, 10, 800, 0);

Container cc2 = new CoolingContainer(0, 10, 10, 10, 700, new ProductType("Bananas", 13.3), 15);
Container lc2 = new LiquidContainer(0, 10, 10, 10, 800, LiquidType.Dangerous);
Container gc2 = new GasContainer(0, 10, 10, 10, 800, 0);

List<Container> containers = new List<Container>();
containers.Add(cc2);
containers.Add(lc2);
containers.Add(gc2);
//-------------------------------------------------

ContainerShip ship1 = new ContainerShip(10, 10, 3);
// end

// operations
Console.WriteLine("1.");
Console.WriteLine(cc1.ToString());
Console.WriteLine(lc1.ToString());
Console.WriteLine(gc1.ToString());
Console.WriteLine();

//-------------------------------------------------Załadowanie ładunku do danego kontenera
try
{
    cc1.AddCargo(500);//
}
catch (OverfillException e)
{
    Console.WriteLine(e.Message);
}

try
{
    lc1.AddCargo(400);//
}
catch (OverfillException e)
{
    Console.WriteLine(e.Message);
}

try
{
    gc1.AddCargo(300);//
}
catch (OverfillException e)
{
    Console.WriteLine(e.Message);
}
Console.WriteLine("2.");
Console.WriteLine(cc1.ToString());
Console.WriteLine(lc1.ToString());
Console.WriteLine(gc1.ToString());
Console.WriteLine();

try
{
    cc1.AddCargo(10, new ProductType("NOTBANANAS", 11));
}
catch (WrongProductTypeException e)
{
    Console.WriteLine(e.Message);
}
catch (WrongTemperatureException e)
{
    Console.WriteLine(e.Message);
}
//-------------------------------------------------

//-------------------------------------------------Załadowanie kontenera na statek
try
{
    ship1.addContainer(cc1);
    ship1.addContainer(gc1);
    Console.WriteLine("3.");
    Console.WriteLine(ship1.ToString());
    Console.WriteLine();
} catch(OverfillException e) {  Console.WriteLine(e.Message); }

try
{
    ship1.addContainer(lc1);
    Console.WriteLine(ship1.ToString());
    Console.WriteLine();
}
catch (OverfillException e) { Console.WriteLine(e.Message); }
//-------------------------------------------------

//-------------------------------------------------Załadowanie listy kontenerów na statek
try
{
    ship1.addContainerList(containers);
    Console.WriteLine("4.");
    Console.WriteLine(ship1.ToString());
    Console.WriteLine();
}
catch (OverfillException e) { Console.WriteLine(e.Message); }
//-------------------------------------------------

//-------------------------------------------------Usunięcie kontenera ze statku
ship1.removeContainer(cc1);
Console.WriteLine("5.");
Console.WriteLine(ship1.ToString());
Console.WriteLine();
//-------------------------------------------------
//-------------------------------------------------Rozładowanie kontenera
ship1.removeContainer(cc1);
Console.WriteLine("5.");
Console.WriteLine(ship1.ToString());
Console.WriteLine();
//-------------------------------------------------

//-------------------------------------------------Zastąpienie kontenera na statku o danym numerze innymkontenerem
ship1.replaceContainer("KON-G-5", cc1);
Console.WriteLine("6.");
Console.WriteLine(ship1.ToString());
Console.WriteLine();
//-------------------------------------------------

//-------------------------------------------------Możliwość przeniesienie kontenera między dwoma statkami
ContainerShip ship2= new ContainerShip(10, 10, 3);
ship1.moveToAnotherShip(cc1, ship2);
Console.WriteLine("7.");
Console.WriteLine(ship1.ToString());
Console.WriteLine();
Console.WriteLine(ship2.ToString());
Console.WriteLine();
//-------------------------------------------------

//-------------------------------------------------Wypisanie informacji o danym kontenerze|Wypisanie informacji o danym statku i jego ładunku
Console.WriteLine("8.");
Console.WriteLine(cc1.ToString());
Console.WriteLine();
Console.WriteLine(ship1.ToString());
Console.WriteLine();

// end
#endregion
*/
/*
#region Section 2
int action = -1;
List <Container> containersList = new List <Container> ();
List<ContainerShip> shipsList = new List <ContainerShip> ();
while(action!=0)
{
    Console.WriteLine("Lista kontenerowców:");
    if (shipsList.Count > 0) 
    {
        string tmpShips = string.Join("\n", shipsList);
        Console.WriteLine(tmpShips);
    } else
    {
        Console.WriteLine("Brak");
    }

    Console.WriteLine("Lista konenerów:");
    if (containersList.Count > 0)
    {
        string tmpContainers = string.Join("\n", containersList);
        Console.WriteLine(tmpContainers);
    }
    else
    {
        Console.WriteLine("Brak");
    }

    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("Możliwe akcje:");
    Console.WriteLine("1. Dodaj kontenerowiec");

}
#endregion
*/