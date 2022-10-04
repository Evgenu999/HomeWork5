// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

double GetDifference(double[] array)
{
    double minNum = array[0];
    double maxNum = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > maxNum)
        {
            maxNum = array[i];
        }
        else if (array[i] < minNum)
        {
            minNum = array[i];
        }
    }
    double range = maxNum - minNum;
    return range;
}

double [] array = {42.4, -22.2, 99, 8.8 , 88};
var rangeArray = GetDifference(array);
Console.WriteLine ($"Разница между максимальным и минимальным значением элементов массива равна {rangeArray}");