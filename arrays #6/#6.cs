// #6

//Алгоритм сортировки подсчетом проходит через несколько этапов:

// 1 Подсчет элементов: На первом этапе алгоритм подсчитывает, сколько раз каждое значение встречается в исходном массиве.

// 2 Создание массива сумм: Затем он создает массив, в котором каждый индекс соответствует значению из исходного массива,
//и записывает туда суммарное количество вхождений этого значения и всех предыдущих.

// 3 Размещение элементов: Наконец, алгоритм проходит через исходный массив в обратном порядке и размещает каждый элемент в новом массиве на позицию,
//соответствующую последнему вхождению этого значения.



Console.WriteLine("Введите длину массива");

int lenght;
lenght = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[lenght];

Console.WriteLine("Введите данные массива");
for (int i = 0; i < lenght; i++)
{
    Console.Write("Введите число - ");
    int array = Convert.ToInt32(Console.ReadLine());

    arr[i] = array;
}

// Поиск максимального значения в массиве
int maxValue = arr.Max();

// Создание массива для подсчета количества вхождений
int[] amount = new int[maxValue + 1];

foreach (var i in arr) // Подсчет элементов
{
    amount[i]++;
}

for (int i = 1; i < amount.Length; i++) //массив сумм
{
   amount[i] += amount[i - 1];
}

int[] SortArr = new int[arr.Length]; //  массив для отсортированных элементов
int choose;
link: // сюда
Console.WriteLine("Возрастание  - 1. Убывание - 2");
choose = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
if (choose == 1)
{
    for (int i = arr.Length - 1; i >= 0; i--) // возрастание
    {
        SortArr[--amount[arr[i]]] = arr[i];
    }
}

else if (choose == 2)
{
    for (int i = arr.Length - 1; i >= 0; i--) // возрастание
    {
        SortArr[--amount[arr[i]]] = arr[i];
    }
    Array.Reverse(SortArr); // ну а теперь убывание
}
else { Console.WriteLine("Вы ввели неверное значение!"); goto link; /*ссылОчка отсюда*/ }
foreach (int i in SortArr)
{ Console.WriteLine(i); }