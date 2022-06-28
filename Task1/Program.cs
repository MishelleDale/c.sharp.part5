Console.WriteLine("Сколько цифр вы хотите ввести?");
int Number = Convert.ToInt32(Console.ReadLine());

int[] Quantity = new int[Number];

int[] FillArray (int[] array)
{
    
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine("Введите число");
        int Digit = Convert.ToInt32(Console.ReadLine());
        array[i] = Digit;
       // Console.Write(Digit);
    }
    return array;
} 

void PrintArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

void CountPositive (int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) 
        {
            sum = sum + 1;
        }
    }
    Console.WriteLine("Вы ввели " + sum + " чисел(ла) больше 0");
}

int[] arr = FillArray(Quantity);
PrintArray(arr);
Console.WriteLine();
CountPositive(arr);