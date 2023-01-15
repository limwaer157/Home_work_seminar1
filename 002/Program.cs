// По двум заданным числам проверять является ли первое квадратом второго

Console.Write("Введите первое число - ");
int numberA = Int32.Parse(Console.ReadLine());
Console.Write("Введите второе число - ");
int numberB = Int32.Parse(Console.ReadLine());
int numberC = (numberB * numberB);

  if(numberA == numberC)
   {
     Console.Write(" Число - ");
     Console.Write(numberA);
     Console.Write(" является квадратом первого ");
    } 
   else
   {
     Console.Write(" Число -  ");
     Console.Write(numberA);
     Console.Write(" не является квадратом первого ");
   }