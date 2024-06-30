// #5 шейкерная сортировка, аналогична пузырьку, но сортируется в две стороны.
// (наибольшие элементы перемещаются в правую сторону, а во время обратного движения наименьшие движутся в левую сторону.)


Console.WriteLine("Введите длину массива");

int name;
name = Convert.ToInt32(Console.ReadLine());

int[] arr = new int[name];

Console.WriteLine("Введите данные массива");

for (int i = 0; i < name;)
{
    Console.Write("Введите число - ");
    int array = Convert.ToInt32(Console.ReadLine());

    arr[i] = array;
    ++i;
}

bool swapped = true;
int start = 0;
int end = arr.Length;

while (swapped)
{
    swapped = false;
link: // cсылка goto
    Console.WriteLine("Возрастание - 1; Убывание - 2");
    int choose;
    choose = Convert.ToInt32(Console.ReadLine());
    if (choose == 1) // возрастание
    {
        for (int i = start; i < end - 1; i++)
        {
            if (arr[i] > arr[i + 1])
            {
                Swap(arr, i, i + 1);
                swapped = true;
            }
        }


        if (!swapped)
        { break; }

        swapped = false;

        end--;

        for (int i = end - 1; i >= start; i--)
        {
            if (arr[i] > arr[i + 1])
            {
                Swap(arr, i, i + 1);
                swapped = true;
            }
        }

        start++;
    }

    else if (choose == 2)
    {
        for (int i = start; i < end - 1; i++)
        {
            if (arr[i] < arr[i + 1])
            {
                SecondSwap(arr, i, i + 1);
                swapped = true;
            }
        }
        if (!swapped)
        { break; }

        swapped = false;

        end--;

        for (int i = end - 1; i >= start; i--)
        {
            if (arr[i] < arr[i + 1])
            {
                SecondSwap(arr, i, i + 1);
                swapped = true;
            }
        }
    }

    else if (choose != 1 && choose != 2) { Console.WriteLine("Вы ввели неверное значение!"); goto link; /* <-- она самая*/ }
}
for (int i =0; i < arr.Length; i++)
{
    Console.WriteLine(arr[i]);
}
static void Swap(int[] arr, int a, int b)
{
    int temp = arr[a];
    arr[a] = arr[b];
    arr[b] = temp;
}

static void SecondSwap (int[] arr, int a, int b)
{
    int temp = arr[b];
    arr[b] = arr[a];
    arr[a] = temp;
} // что-то типо вроде , хз короче