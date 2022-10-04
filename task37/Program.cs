// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент,
// второй и предпоследний и т.д. Результат запишите в новом массиве.

int[] GetPairMulti (int[] array)
{
    int size = array.Length;
    int sizeNew = 0;
    sizeNew = size/2;
    
   
    if (size % 2 == 0) 
    {
        int[] result = new int[sizeNew];
        for (int i = 0; i < result.Length; i++)
        {
            result[i] = array[i] * array[size-1-i];
        }
        return result;
    }
    else
    {
        int[] result = new int[sizeNew+1];
        for (int i = 0; i < result.Length; i++)
        {
            result[i] = array[i] * array[size-1-i];
        }
        result[sizeNew] = array[size/2];
        return result;
    }
    
}
int [] array = {70, 25, 99, 4, -5};
int[] newArray = GetPairMulti(array);

for (int i = 0; i < newArray.Length; i++)
{
    Console.Write($"{newArray[i]} ");
}