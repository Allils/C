// #4

/* в начале работы упорядоченная часть пуста;
добавляем в отсортированную область первый элемент массива из неупорядоченных данных;

переходим к следующему элементу в не отсортированных данных,
и находим ему правильную позицию в отсортированной части массива, тем самым мы расширяем область упорядоченных данных;

повторяем предыдущий шаг для всех оставшихся элементов. */


Console.WriteLine("Введите длину массива");

int name;
name = Convert.ToInt32(Console.ReadLine());

int[] array = new int[name];

Console.WriteLine("Введите данные массива");

for (int i = 0; i < name;)
{
    Console.Write("Введите число - ");
    int arr = Convert.ToInt32(Console.ReadLine());

    array[i] = arr;
    ++i;
}
int choose = 0;
Console.WriteLine("убывание - 2. возрастание - 1 ");
choose = Convert.ToInt32(Console.ReadLine());
if (choose != 1 && choose != 2)
{
    Console.WriteLine("Введите верное значение - ");
    choose = Convert.ToInt32(Console.ReadLine());
}
if (choose == 1) 
{ 
    for (int i = 1; i < array.Length; i++) // возрастание
    {
        int k = array[i];
        int j = i - 1;

        while (j >= 0 && array[j] > k)
        {
            array[j + 1] = array[j];
            array[j] = k;
            j--;
        }
    }
}

if (choose == 2)
{
    for (int i = 1; i < array.Length; i++) // убывание
    {
        int k = array[i];
        int j = i - 1;

        while (j >= 0 && array[j] < k)
        {
            array[j + 1] = array[j];
            array[j] = k;
            j--;

        }
    }
}
Console.WriteLine();
for (int i = 0; i < name;)
{
    Console.WriteLine(array[i]);
    ++i;
}