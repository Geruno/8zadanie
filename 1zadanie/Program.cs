int Vvod (string message)
{
Console.WriteLine(message);
int result = Convert.ToInt32(Console.ReadLine());
return result;
}
void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
void Zamena(int[,] array, int str, int stolb)
{
    int max = 0;
    for (int i = 0; i < str; i++)
    {
        for (int j = 0; j < stolb; j++)
        {
            if (max < array[i,j])
            {
            max = array[i,j];
            }
        }
        Console.Write(max + " ");
        max = 0;
    }
    Console.WriteLine();
}
int str = Vvod("Введите количество строчек");
int stolb = Vvod("Введите количество столбцов");
int[,] number = new int[stolb, str];
FillArray(number);
PrintArray(number);
Zamena(number, str, stolb);