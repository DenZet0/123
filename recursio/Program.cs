// double Factorial(int n)
// {
//     if(n==1) return n;
//     else return n * Factorial(n - 1);
// }

// Console.WriteLine(Factorial(0));

int fibbonacci(int n)
{
    if(n <= 0) return 0;
    if(n == 1 || n == 2) return 1;
    else return fibbonacci(n-1) + fibbonacci(n-2);
}

for (int i = 0; i < 10; i++)
{
    if(fibbonacci(i) <= 0)
    {    
    Console.Write("Пошел нахуй");
    break;
    }
    Console.Write(fibbonacci(i) + " ");
}