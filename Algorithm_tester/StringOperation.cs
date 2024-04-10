namespace algorithm_tester;

static class StringOperation
{
    public static List<int> string_search_subline(string Line, string SubLine)
    {
        List<int> result = new List<int>();
        for(int i = 0; i <= Line.Length - SubLine.Length; i ++ )
        {
            if(is_sublines_equals(Line, SubLine, i))
            {
                result.Add(i);
            }
        }
        return result;
    }

    public static bool is_sublines_equals(string Line, string SubLine, int i)
    {
        return SubLine == Line.Substring(i, SubLine.Length);
    }
    

    public static int largest_not_repeating_subline(string s)
    {
        int left = 0;
        int max_subline_length = 0;
        for(int right = 0; right < s.Length + 1; right++)
        {
            left += number_step_left(s.Substring(left, right-left));
            if(max_subline_length < right-left)
            {
                max_subline_length = right-left;
            }
        }
        return max_subline_length;
    }
    static int number_step_left(string line)
    {
        for(int i = 0; i < line.Length - 1; i++)
        {
            if(line[i] == line[line.Length - 1])
            {
                return i + 1;
            }
        }
        return 0;
    }

    public static int RomanToInt(string s)
    {
        Dictionary<char, int> romanMap = new Dictionary<char, int>
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };
        int result = 0;
        for(int i = 0; i < s.Length; i ++)
        {
            if(i+1==s.Length)
            {
                result += romanMap[s[i]];
            }
            else
            {
                int num = romanMap[s[i]];
                int nextNum = romanMap[s[i+1]];
                if(nextNum > num)
                {
                    result += nextNum - num;
                    i ++;
                }
                else
                {
                    result += num;
                }
            }
        }
        return result;
    }
}