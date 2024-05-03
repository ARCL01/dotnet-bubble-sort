Console.WriteLine("Hello, World!");
Console.WriteLine("funguje");

int[] cisla = new int[10];
int index = 0;
int zapsane_cislo;

while(true)
{
    Console.Write("Zapište číslo: ");
    zapsane_cislo = int.Parse(Console.ReadLine());
    if (zapsane_cislo<=100 && zapsane_cislo>=0)
    {
        cisla[index] = zapsane_cislo;
        index++;
        if (index == 10)
        {
            Console.WriteLine("Pole Naplněno");
            break;
        }
    }
    else
    {
        Console.WriteLine("Zapisování dokončeno");
        break;
    }
}


for (int x = 0;x<=cisla.Count()-1;x++)
{
    if(x<=index-1)
    {
        Console.Write($"{cisla[x]}, ");
    }      
}

// Min number
Console.WriteLine("min to max");
int min = 0;
for (int x = 0;x<index;x++)
{
    if (x==0)
    {
        min = cisla[x];
    }
    else
    {
        if (cisla[x]< min)
        {
            min = cisla[x];
        }
    }
}


Console.WriteLine("Třídění dokončeno");
