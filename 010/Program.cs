// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа


int number = new Random().Next(10, 99);
Console.WriteLine("Сгенерированное число - ");
Console.WriteLine(number);
string string1 = number.ToString();

int numberA1 = Int32.Parse(string1[0].ToString());
int numberB2 = Int32.Parse(string1[1].ToString());

int max = numberB2;
if (numberA1 > numberB2 )
{
    max = numberA1;
}
else 
{
numberB2 = max;
}
Console.WriteLine(max);