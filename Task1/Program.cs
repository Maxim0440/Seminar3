// // напишите программу которая по заданному 
// номеру четверти показывает диапазон
//  координат точек в этой четверти

int num = new Random().Next(1,5);
System.Console.WriteLine(num);

if (num == 1)
{
    System.Console.WriteLine("x от 0 до +&, y от 0 до +&");
}

else if (num == 2)
{
    System.Console.WriteLine("x от 0 до -&, y от 0 до +&");
}
else if (num == 3)
{
System.Console.WriteLine("x от 0 до -&, y от 0 до -&");
}
else if (num == 4)
{
    System.Console.WriteLine("x от 0 до +&, y от 0 до -&");
}
else
System.Console.WriteLine("нет такой четверти");