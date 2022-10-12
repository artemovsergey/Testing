public class SimpleParser
{
    public int ParseAndSum(string numbers)
    {
        if (numbers.Length == 0)
        {
            return 0;
        }
        if (!numbers.Contains(","))
        {
            return int.Parse(numbers);
        }
        else
        {
            throw new InvalidOperationException();
        }
    }
}