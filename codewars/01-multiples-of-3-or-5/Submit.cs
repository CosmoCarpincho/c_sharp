public static class Kata
{
    public static int Solution(int value)
    {
        int total = 0;
        for (int i = 0; i < value; i++)
        {
            total += i switch
            {
                _ when i % 3 == 0 => i,
                _ when i % 5 == 0 => i,
                _ => 0
            };
        }
        return total;
    }
}