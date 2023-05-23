namespace Exercise_03_;

public static class Balance
{
    // Key => '<' & value => '>' \\
    static Dictionary<char, char> pairs = new()
    {
        { '<', '>' },
        { '{', '}' },
        { '(', ')' },
        { '[', ']' },
    };

    // Extension Method
    public static bool IsBalanced(this string text)
    {
        Stack<char> brackets = new();
        try
        {
            foreach (char t in text)
            {
                if (pairs.Keys.Contains(t))
                    brackets.Push(t);
                else if (pairs.Values.Contains(t))
                {
                    if (t == pairs[brackets.Peek()])
                        brackets.Pop();
                    else
                        return false;
                }
                else
                    continue;
            }
        }
        catch
        {
            return false;
        }
        return brackets.Count() == 0 ? true : false;
    }


}