using System.ComponentModel.Design;

Console.Write("Ingrese el primer número:");
var number1String = Console.ReadLine();
var number1Int = int.Parse(number1String!);
Console.Write("Ingrese el segundo número:");
var number2String = Console.ReadLine();
var number2Int = int.Parse(number2String!);
Console.Write("Ingrese el tercer número:");
var number3String = Console.ReadLine();
var number3Int = int.Parse(number3String!);
if (number1Int > number2Int && number1Int > number3Int)
{
    Console.Write($"El número mayor es {number1Int}");
    if (number2Int < number1Int && number2Int > number3Int)
    {
        Console.Write($"El número del medio es {number2Int}");
    }
    else
    {
        Console.Write($"El número del medio es {number3Int}");
    }
}
if (number2Int > number1Int && number2Int > number3Int)
{
    Console.Write($"El número mayor es {number2Int}");
    if (number1Int < number2Int && number1Int > number3Int)
    {
        Console.Write($"El número del medio es {number1Int}");
    }
    else
    {
        Console.Write($"El número del medio es {number3Int}");
    }
}
if (number3Int > number1Int && number3Int > number2Int)
{
    Console.Write($"El número mayor es {number3Int}");
    if (number2Int < number3Int && number2Int > number1Int)
    {
        Console.Write($"El número del medio es {number2Int}");
    }
    else
    {
        Console.Write($"El número del medio es {number1Int}");
    }
}
