// 5 алгоритмов для сортировки массива

/* #3 - Алгоритм сортировки stooge sort заключается в следующем:

Если значение последнего элемента массива меньше, чем значение первого элемента, то меняем их местами;
Если в массиве содержится три и более элемента, то:
Рекурсивно вызываем метод для первых 2⁄3 элементов;
Рекурсивно вызываем метод для последних 2⁄3 элементов;
Снова рекурсивно вызываем метод для первых 2⁄3 элементов; */

using System.Xml.Linq;

static void Swap(ref int x, ref int y)
{
    int swap = x;
    x = y;
    y = swap;
}

Console.WriteLine("Введите длину массива");

int name;
name = Convert.ToInt32(Console.ReadLine());

int[] array = new int[name];

Console.WriteLine("Введите данные массива");

for (int i = 0; i < name; )
{
    Console.Write("Введите число - ");
    int arr = Convert.ToInt32(Console.ReadLine());

    array[i] = arr;
    ++i;
}

for (int i = 0; i < name; )
{
    
    Console.WriteLine(array[i]);
    i++;
}
int a = array[0];
int b = array[--name];
Sort(array,a, b );


static int[] Sort(int[] array, int firstNum, int lastNum) // возрастание
{
    if (firstNum > lastNum)
    {
        Swap(ref firstNum, ref lastNum);
    }
    if (lastNum - firstNum > 1)
    {
        int length = (lastNum - firstNum + 1) / 3;
        Sort(array, firstNum, lastNum - length);
        Sort(array, firstNum + length, lastNum);
        Sort(array, firstNum, lastNum - length);
    }
    return array;
}


for (int i = 0; i < name; )
{
    Console.WriteLine(array[i]);
    ++i;
}

Console.WriteLine("Упорядоченный массив: {0}", string.Join(", ", Sort(array)));
// хз короче
