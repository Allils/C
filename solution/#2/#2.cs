// 5 алгоритмов для сортировки массива

// #2 - cлучайная сортировка




Console.WriteLine("Введите длину массива");

int name;
name = Convert.ToInt32(Console.ReadLine());
int[] log = new int[name];

Console.WriteLine("Введите данные массива");

for (int i = 0; i < name; ++i)
{

    Console.Write("Введите число - ");
    int arr= Convert.ToInt32(Console.ReadLine());

    log[i] = arr;
}

for (int i = 0; i < name; ++i)
{
    Console.WriteLine(log[i]);
}

Console.WriteLine("Выбирай: 1- убывание. 2- возрастание");
Console.WriteLine();

int value;
value = Convert.ToInt32(Console.ReadLine());   

if (value == 2)
{
    RandSortA(log);
    for (int i = 0; i < name; ++i)
    {
        Console.WriteLine(log[i]);
    }
}

if (value == 1)
{
    RandSortB(log);
    for (int i = 0; i < name; ++i)
    {
        Console.WriteLine(log[i]);
    }
}

bool IsSortB(int[] a) // Убывание
{
    for (int i = 0; i < a.Length - 1; i++)
    {
        if (a[i] < a[i + 1])
            return false;
    }
    return true;
}
int[] RandSortB(int[] a) // Убывание
{
    while (!IsSortB(a))
    {
        a = RandPerm(a);
    }

    return a;
}
bool IsSortA(int[] a) // Возрастание
{
    for (int i = 0; i < a.Length - 1; i++)
    {
        if (a[i] > a[i + 1])
            return false;
    }
    return true;
}

int[] RandSortA(int[] a) // Возрастание
{
    while (!IsSortA(a))
    {
        a = RandPerm(a);
    }

    return a;
}

static int[] RandPerm(int[] a)
{
    Random random = new Random();
    var n = a.Length;
    while (n > 1)
    {
        n--;
        var i = random.Next(n + 1);
        var swap = a[i];
        a[i] = a[n];
        a[n] = swap;
    }

    return a;
}
