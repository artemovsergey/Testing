class SimpleParserTests
{
    public static void TestReturnsZeroWhenEmptyString()
    {
        try
        {
            SimpleParser p = new SimpleParser();
            int result = p.ParseAndSum("1");
            if (result != 0)
            {
                Console.WriteLine(
                 @"***SimpleParserTests.TestReturnsZeroWhenEmptyString:

                -------
                ParseAndSum должен вернуть 0 для пустой строки");

            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }
}