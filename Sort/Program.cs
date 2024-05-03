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
        Console.WriteLine("Zapisování ukončeno nepovolenou hodnotou");
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

int[] sorted =  new int[10];

// Min to max sort
Console.WriteLine("");
Console.WriteLine($"Index: {index}");
for (int y=0;y<index;y++)
{
    for (int x=0;x<index-1;x++)
    {
        if (cisla[x] >= cisla[x+1])
        {
            int temp = cisla[x];
            cisla[x] = cisla[x+1];
            cisla[x+1] = temp;
        }
    }
}
for (int x = 0;x<=cisla.Count()-1;x++)
{
    if(x<=index-1)
    {
        Console.Write($"{cisla[x]}, ");
    }      
}

// Max to min sort
Console.WriteLine("");
Console.WriteLine($"Index: {index}");
for (int y=0;y<index;y++)
{
    for (int x=0;x<index-1;x++)
    {
        if (cisla[x] <= cisla[x+1])
        {
            int temp = cisla[x];
            cisla[x] = cisla[x+1];
            cisla[x+1] = temp;
        }
    }
}
for (int x = 0;x<=cisla.Count()-1;x++)
{
    if(x<=index-1)
    {
        Console.Write($"{cisla[x]}, ");
    }      
}