Console.WriteLine("Введите первое число:");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число:");
int numberС = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("max = " + Math.Max(Math.Max(numberA, numberB), numberС) );
