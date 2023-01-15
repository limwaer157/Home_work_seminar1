// Найти максимальное из трех чисел


Console.Write("Введите первое число - ");
int numberA = Int32.Parse(Console.ReadLine());
Console.Write("Введите второе число - ");
int numberB = Int32.Parse(Console.ReadLine());
Console.Write("Введите третье число - ");
int numberC = Int32.Parse(Console.ReadLine());
int maxNumber = numberA;

if(numberA > numberB )
     {
    maxNumber = numberA;
     } 
 if(numberB > numberA )
     {
    maxNumber = numberB;
     } 
if(numberC > numberB)
     {
     maxNumber = numberC;
     } 
     
  Console.Write("Наибольшее число - ");
  Console.Write(maxNumber);