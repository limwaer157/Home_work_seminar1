// Показать последнюю цифру трёхзначного числа

Console.Write("Введите  число - ");
int Number = Int32.Parse(Console.ReadLine());
int lastNumber = Number % 10;
Console.Write("Последяя цифра - ");
Console.Write(lastNumber);