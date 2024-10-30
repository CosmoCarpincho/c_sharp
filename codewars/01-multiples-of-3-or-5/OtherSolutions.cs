
public class OtherSolutions
{
    public int Solution1(int value)
    {
        var sum = 0;
        for (int i = 3; i < value; i++)
        {
            if (i % 3 == 0 || i % 5 == 0) sum += i;
        }
        return sum;
    }


    public int Solution2(int value)
    {
        if (value <= 0) return 0;
        return Enumerable.Range(0, value).Where(num => num % 3 == 0 | num % 5 == 0).Sum();
    }

    // Esta no sirve para negativos OJO ->
    public static int Solution3(int value) => Enumerable.Range(0, value).Sum(i => i % 3 == 0 || i % 5 == 0 ? i : 0);

    // Corregido
    public static int Solution4(int value) => value < 3 ? 0 : Enumerable.Range(0, value).Sum(i => i >= 3 && (i % 3 == 0 || i % 5 == 0 ) ? i : 0);
}