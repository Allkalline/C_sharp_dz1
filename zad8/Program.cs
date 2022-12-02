// Программа, которая на вход принимает число, а на выходе показывает все четные числа от 1 до N

Console.Write("Введите число 1: ");
int N = int.Parse(Console.ReadLine()!);
int a = 1;

if(N<0){
    while(a>=N)
       { 
         if(a%2 ==0) {
         Console.Write (" " + a + " ");}
        a--; }}
    else {

            while (a<=N) { 
            if(a%2 ==0) {
                Console.Write (" " + a + " ");}
             a++; }}
