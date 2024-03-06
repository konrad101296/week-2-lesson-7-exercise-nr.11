Console.WriteLine("wpisz ocene:");
int ocena = int.Parse(Console.ReadLine());

if (ocena == 1)
{
    Console.WriteLine("niedostateczny");
}
else if (ocena == 2)
{
    Console.WriteLine("dopuszczajacy");
}
else if (ocena == 3)
{
    Console.WriteLine("dostateczny");
}
else if (ocena == 4)
{
    Console.WriteLine("dobry");
}
else if (ocena == 5)
{
    Console.WriteLine("bardzo dobry");
}
else if (ocena == 6)
{
    Console.WriteLine("celujacy");
}
else
{
    Console.WriteLine("oceny sa tylko od 1 do 6");
}

Console.WriteLine("wpisz ocene:");
int ocena = int.Parse(Console.ReadLine());

switch (ocena)
{
    case 1:
        Console.WriteLine("niedostateczny");
        break;
    case 2:
        Console.WriteLine("dopuszczajacy");
        break;
    case 3:
        Console.WriteLine("dostateczny");
        break;
    case 4:
        Console.WriteLine("dobry");
        break;
    case 5:
        Console.WriteLine("bardzo dobry");
        break;
    case 6:
        Console.WriteLine("celujacy");
        break;
    default:
        Console.WriteLine("oceny sa tylko od 1 do 6");
        break;
}
