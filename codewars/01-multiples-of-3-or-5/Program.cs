int isMultiply3OrMultiply5(int value)
{

    return value switch
    {
        _ when value % 3 == 0 => value,
        _ when value % 5 == 0 => value,
        _ => 0
    };

}

int n = 200;
int total = 0;

for (int i = 0; i < n; i++)
    total += isMultiply3OrMultiply5(i);

Console.WriteLine(total);

try
{
    int sol3 = OtherSolutions.Solution3(-10);
    Console.WriteLine(sol3);
}
catch (System.Exception)
{
    Console.WriteLine("Número negativo OJO");

}


int sol4 = OtherSolutions.Solution4(-3);
Console.WriteLine($"Sol 4 -> {sol4}");