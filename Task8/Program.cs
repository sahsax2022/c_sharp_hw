Console.WriteLine("Введите число:");
int numberA = Convert.ToInt32(Console.ReadLine());

int iterator = 1;

while (iterator <= numberA)
{
    if (iterator % 2 == 0)
        Console.Write($"{iterator},");
    iterator++;
}
