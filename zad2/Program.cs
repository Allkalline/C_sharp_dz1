//Программа, которая принимает 2 числа и выдает мин и макс

Console.Write("Введите число 1:");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите число 2:");
int b = int.Parse(Console.ReadLine()!);

if (a<b) {

    Console.WriteLine("max= "+ b);
    Console.WriteLine("min= "+ a);
}
else {

    Console.WriteLine("max= " + a);
    Console.WriteLine("min= " + b);
}