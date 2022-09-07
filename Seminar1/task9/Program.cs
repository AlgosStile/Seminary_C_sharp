//Напишите программу , которая принимает 
// на вход координаты точки (X и Y), причем Х ≠ 0 и Y ≠ 0 и 
// выдается номер четверти плоскости, в которой находится эта точка.

Console.WriteLine ("Введите координату точки по X ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Введите координату точки по Y ");
int y = Convert.ToInt32(Console.ReadLine());

if (x > 0 && y > 0)
{
    Console.WriteLine("Точка находится в 1 координатной четверти");
}
else if (x < 0 && y > 0)
{
  Console.WriteLine("Точка находится во 2 координатной четверти");  
}
else if (x < 0 && y < 0)
{
  Console.WriteLine("Точка находится в 3 координатной четверти"); 
}
else if (x > 0 && y < 0)
{
    Console.WriteLine("Точка находится в 4 координатной четверти");
}
else 
{
   Console.WriteLine("Введениа нулевая координата по Х и/иля X");
}
