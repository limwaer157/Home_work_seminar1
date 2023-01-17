// Выяснить, кратно ли число заданному, если нет, вывести остаток.

Console.Write("Введите  число - ");
int numberA = Int32.Parse(Console.ReadLine());
Console.Write("Введите  число  на которое нужно делить - ");
int numberB = Int32.Parse(Console.ReadLine());

int numberC = (numberA % numberB );

if(numberC == 0 )
     {
     int numberD = (numberA / numberB );
     Console.Write("Число кратно заданному ответ - ");
     Console.Write(numberD);
     } 
     else
     {
        Console.Write(numberC);
            }
