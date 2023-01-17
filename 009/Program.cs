// Удалить вторую цифру трёхзначного числа

int number = new Random().Next(100, 999);
Console.WriteLine("Сгенерированное число - ");
Console.WriteLine(number);
string string1 = number.ToString();

int numberA1 = Int32.Parse(string1[0].ToString());
Console.Write(numberA1);
int numberB2 = Int32.Parse(string1[2].ToString());
Console.Write(numberB2);

