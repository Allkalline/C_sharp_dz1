//Проверка четности введенного числа

Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine()!);

if(a%2 ==0) {

    Console.WriteLine("да");
}
else {
    Console.WriteLine("нет");
}