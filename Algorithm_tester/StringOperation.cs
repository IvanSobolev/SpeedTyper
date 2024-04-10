namespace algorithm_tester;

static class StringOperation
{
    public static List<int> string_search_subline(string Line, string SubLine)
    {
        List<int> result = new List<int>();
        for(int i = 0; i <= Line.Length - SubLine.Length; i ++ )
        {
            if(string_equals(Line, SubLine, i))
            {
                result.Add(i);
            }
        }
        return result;
    }

    public static bool string_equals(string Line, string SubLine, int i)
    {
        return SubLine == Line.Substring(i, SubLine.Length);
    }
}