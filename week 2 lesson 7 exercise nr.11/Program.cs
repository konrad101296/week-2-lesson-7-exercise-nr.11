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