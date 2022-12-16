int a = new Random().Next(0,101);
Console.WriteLine("Напишите число от 0 до 100");
int usernum = System.Convert.ToInt32(Console.ReadLine());
if (usernum == a)
{
    Console.WriteLine("Да ты Ванга!");
}
else
{
    Console.Write("Повезет в другой раз, компьютер загадал ");
    Console.WriteLine(a);
}