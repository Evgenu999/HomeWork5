// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int CountNumbers (int[] array)
{    
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count ++;
        }
    }
    return count;
}

int num = new Random().Next(1,100);
int[] threeDigitArray = new int[num];

for (int i = 0; i < num; i++)
{
    threeDigitArray[i] = new Random().Next(100,1000);
}

int number = CountNumbers(threeDigitArray);
Console.WriteLine($"Количество четных чисел в массиве равно {number}");


// сделал согласно условию задачи! можно было распечатать массив на экране и убедиться в достоверности.