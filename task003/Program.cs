Console.Write("Введите число для проверки на четность: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0)
{
    Console.Write("Число " + number + " является четным;");
}
else Console.Write("Число " + number + " не является четным;");