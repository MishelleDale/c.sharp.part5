Console.WriteLine("Введите число");
int Number = Convert.ToInt32(Console.ReadLine());

if (Number <= 1 && Number >= 0) Console.WriteLine(Number);
if (Number == -1) Console.WriteLine($"{1}");

if (Number > 1)
{
    string Number2 = Convert.ToString(Number, 2);
    Console.WriteLine("Введенное вами число в двоичной системе: " + Number2);
}

if (Number < -1)
{
    int NumberPos = Number * (-1);
    string Number2 = Convert.ToString(NumberPos, 2);
    Console.WriteLine("Введенное вами число в двоичной системе: " + Number2);
}