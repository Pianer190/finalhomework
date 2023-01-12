// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

void MyFunction(int n){
    Console.Write(n + " ");
    if(n > 1) MyFunction(n - 1);
}

    Console.Write("Введите число: ");
int input = int.Parse(Console.ReadLine());

MyFunction(input);