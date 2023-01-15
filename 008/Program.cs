// Показать вторую цифру трёхзначного числа

Console.Write("Введите  число - ");
int numberA = Int32.Parse(Console.ReadLine());

string string1 = numberA.ToString();
Console.Write("Вторая  цифра введеного числа - ");
Console.Write(string1[1]);
