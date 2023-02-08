// Задача 1: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

int Inputint(string message)
{
    System.Console.Write($"{message}: ");
    return int.Parse(Console.ReadLine());
}
int size = Inputint("Введите размер");
int[] myArray = new int[size];

for (int i = 0; i < myArray.Length; i++)
{
    myArray[i] = Inputint($"Введите элементы массива {i}\t");
}
int CountNumbers(int[] myArray)
{
    int count = 0;
    for (int i = 0; i < myArray.Length; i++)
    {
        if (myArray[i] > 0)
        {
            count += 1;
        }
    }
    return count;
}
Console.WriteLine($"Количество чисел в массиве больше нуля {CountNumbers(myArray)}");



