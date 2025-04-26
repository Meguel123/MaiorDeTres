Console.Clear();
decimal x, y, z;
Console.WriteLine("Digite um numero");
x = Convert.ToDecimal(Console.ReadLine()!);

Console.WriteLine("Digite um numero");
y = Convert.ToDecimal(Console.ReadLine()!);

Console.WriteLine("Digite um numero");
z = Convert.ToDecimal(Console.ReadLine()!);

if (x >= y && x >= z)
{
    Console.Write("O maior número entre os 3 é...: ");
    Console.WriteLine($"{x}");
}
 
else if(y >= x && y >= z)
{
Console.Write("O maior número entre os 3 é...: ");
Console.WriteLine($"{y}");
}

else if(z >= x && z >= y)
{
Console.Write("O maior número entre os 3 é...: ");
Console.WriteLine($"{z}");

}
else
{
    Console.WriteLine("erro ");
}