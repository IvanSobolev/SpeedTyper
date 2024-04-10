namespace algorithm_tester;

class Program
{
    static void Main(string[] args)
    {
        string line = "CAT Cat cat dog hate dog gpt";
        string subLine = "dog";
        List<int> startSublines = StringOperation.string_search_subline(line, subLine);
        foreach(var _sublinestart in startSublines)
        {
            Console.Write(_sublinestart + " ");
        }
        
    }
}
