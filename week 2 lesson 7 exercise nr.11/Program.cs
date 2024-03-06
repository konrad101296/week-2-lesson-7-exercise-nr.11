Console.WriteLine("wpisz ocene:");
int mark = int.Parse(Console.ReadLine());

if (mark == 1)
{
    Console.WriteLine("niedostateczny");
}
else if (mark == 2)
{
    Console.WriteLine("dopuszczajacy");
}
else if (mark == 3)
{
    Console.WriteLine("dostateczny");
}
else if (mark == 4)
{
    Console.WriteLine("dobry");
}
else if (mark == 5)
{
    Console.WriteLine("bardzo dobry");
}
else if (mark == 6)
{
    Console.WriteLine("celujacy");
}
else
{
    Console.WriteLine("oceny sa tylko od 1 do 6");
}

switch (mark)
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
