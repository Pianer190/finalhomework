// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Hello, World!");

Console.Write("Введите значение M: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите значение N: ");
int n = int.Parse(Console.ReadLine());
while(true){
    if(m >= n){
        Console.WriteLine("Значение M не может быть больше или равно N!");
        Console.Write("Введите значение M: ");
        m = int.Parse(Console.ReadLine());
        Console.Write("Введите значение N: ");
        n = int.Parse(Console.ReadLine());
        continue;
    } 
    break;
}
int result = 0;
for(; m <= n; m++){
    if(m < 1) continue;
    result += m;
}
Console.WriteLine("Результат: " + result);