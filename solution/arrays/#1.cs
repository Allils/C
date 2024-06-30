// 5 алгоритмов для сортировки массива

// #1 (оказывается это сортировка пузырьком)
Console.WriteLine("Введите длину массива");

int name;
name = Convert.ToInt32(Console.ReadLine());

int[] log =  new int[name];

Console.WriteLine("Введите данные массива");
for(int i = 0; i <name; ++i)
{
    
    Console.Write("Введите число - ") ;
    int arr = Convert.ToInt32(Console.ReadLine());
    
    log[i] = arr;
}
for (int i = 0; i < name; ++i)
{
    Console.WriteLine(log[i]);
}
Console.WriteLine("Сортировка массива");
Console.WriteLine("Выбирай: по возрастанию - 1. По убыванию - 2 ");
int choose = Convert.ToInt32(Console.ReadLine());


if (choose == 1)
{
    for (int j = 0; j < name;) // по возрастанию
    {
        for (int k = 0; k < name;)
        {
            if (log[j] < log[k])
            {
                int swap = log[k];
                log[k] = log[j];
                log[j] = swap;
            }
            ++k;
        }

        ++j;
    }

    for (int i = 0; i < name; ++i)
    {
        Console.WriteLine(log[i]);
    }
}
else if (choose == 2)
{
    for (int j = 0; j < name;) // по возрастанию
    {
        for (int k = 0; k < name;)
        {
            if (log[j] > log[k])
            {
                int swap = log[k];
                log[k] = log[j];
                log[j] = swap;
            }
            ++k;
        }

        ++j;
    }

    for (int i = 0; i < name; ++i)
    {
        Console.WriteLine(log[i]);
    }
}    
else
{
    Console.WriteLine("Вы ввели неверное значение");
}    