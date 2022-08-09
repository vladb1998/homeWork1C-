Console.WriteLine("Введите первое число : ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число : ");
int numberB = Convert.ToInt32(Console.ReadLine());

int max = numberA;
int min = numberB;

if (numberA > numberB)
{
    max = numberA ;
    min = numberB ;
    Console.Write("Число " + numberA + " > " +numberB);
}
else  Console.Write("Число " + numberB + " > " +numberA);