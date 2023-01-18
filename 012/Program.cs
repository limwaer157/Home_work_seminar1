// Найти третью цифру числа или сообщить, что её нет

Console.Write("Введите трехзначное число число - ");
int number = Int32.Parse(Console.ReadLine());   
 
 if (number < 100)
 {
        Console.WriteLine("Слишком маленькое число");
 }
    
    else
 {
        while (number > 999 )
 {
    number = number - 1000;
 }
if (number <= 999)
 {
    number = number / 100;
 }
Console.WriteLine(number);
}
 


 