// Показать четные числа от 1 до N

Console.Write("Показать четные числа от 1 до -  ");
int n = Convert.ToInt32(Console.ReadLine());
int numbers = 1;

while(numbers <= n)
{
    if(numbers % 2 == 0)
    {
        Console.WriteLine(numbers);
        numbers = numbers + 2;
    }
    else
    {
        numbers = numbers + 1;
    }
}