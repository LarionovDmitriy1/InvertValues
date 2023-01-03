using InvertValues;

var result = Invert_values.InvertValues(new int[] { 45, 2, 21, 2, 13 - 432, -32, -34, 0, -0 });
foreach (var value in result)
{
    Console.Write($"{value} ");
}