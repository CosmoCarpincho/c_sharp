
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