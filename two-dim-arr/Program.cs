
using System.Xml.Linq;

Console.WriteLine("Введите rows "); // ряд
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите columns "); // столбец
int columns = Convert.ToInt32(Console.ReadLine());
 
int[,] MainArray = new int[columns, rows];

int[] SecArray = new int[rows * columns];

for (int i = 0; i < columns; i++)
{

    for (int j = 0; j < rows; j++)
    {
        Console.WriteLine($"Введите данные {++i} столбца и {++j} ряда ") ; --i;--j;
       int num = Convert.ToInt32(Console.ReadLine());
        MainArray[i, j] = num ;
    }

}
int w = 0;
for (int i = 0; i < columns; i++)
{

    for (int j = 0; j < rows; j++)
    {
        SecArray[w] = MainArray[i,j];
        w++;
    }

}

Console.WriteLine("Выбирай: по возрастанию - 1. По убыванию - 2 ");
int choose = Convert.ToInt32(Console.ReadLine());


if (choose == 1)
{
    for (int j = 0; j < SecArray.Length;) // по возрастанию
    {
        for (int k = 0; k < SecArray.Length;)
        {
            if (SecArray[j] < SecArray[k])
            {
                int swap = SecArray[k];
                SecArray[k] = SecArray[j];
                SecArray[j] = swap;
            }
            ++k;
        }
        ++j;
    }

    for (int i = 0; i < SecArray.Length; ++i)
    {
        Console.WriteLine(SecArray[i]);
    }
}
else if (choose == 2)
{
    for (int j = 0; j < SecArray.Length;) // по возрастанию
    {
        for (int k = 0; k < SecArray.Length;)
        {
            if (SecArray[j] > SecArray[k])
            {
                int swap = SecArray[k];
                SecArray[k] = SecArray[j];
                SecArray[j] = swap;
            }
            ++k;
        }
        ++j;
    }

   
}
else
{
    Console.WriteLine("Вы ввели неверное значение");
}

//for (int i = 0; i < SecArray.Length;i++)
//{
//    Console.WriteLine( $"\t {SecArray[i]}");
//}

int s = 0;
    for (int c = 0; c < columns; c++)
    {
        for (int r = 0; r < rows; r++)
        {
        
            MainArray[c, r] = SecArray[s];
        s++;
        }

    }

for (int i = 0; i < columns; i++)
{
    for (int j = 0; j < rows; j++)
    {
        Console.Write($"\t {MainArray[i, j]} \t");
    }
    Console.WriteLine();
}
