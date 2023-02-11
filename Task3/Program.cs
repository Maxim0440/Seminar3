// // //Напишите программу, которая 
// принимает на вход число (N) и 
// выдаёт таблицу квадратов чисел 
// // от 1 до N.

// // 5 -> 1, 4, 9, 16, 25.
// // 2 -> 1,4


int num = new Random().Next(1,21);
System.Console.WriteLine($"num = {num}");
int i = 1;
while (i <= num)

{
    System.Console.WriteLine(Math.Pow(i, 2));
i++;
}
