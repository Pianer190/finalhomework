// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

uint A(uint n,uint m){
    if(n == 0) return m + 1;
    else {
        if((n != 0) && (m == 0)) return A(n - 1, 1);
        else return A(n-1, A(n, m - 1));
    }
}

uint M = 0;
uint N = 0;

while(!uint.TryParse(Console.ReadLine(), out M)) Console.WriteLine("Допустимы только натуральные числа");
while(!uint.TryParse(Console.ReadLine(), out N)) Console.WriteLine("Допустимы только натуральные числа");

Console.WriteLine("Результат: " + A(M,N));