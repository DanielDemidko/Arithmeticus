using System;
using System.Linq;

static class Analyzer
{
    public static bool IsNumber(this Char symbol)
    {
        return symbol >= '0' && symbol <= '9';
    }

    public static Analysis IsCalculable(this String line)
    {
        foreach (Char i in line)
        {
            if (!(i.IsNumber() || "+-*/^(), ".Contains(i)))
            {
                return new Analysis(false, i);
            }
        }
        return new Analysis(!"+-*/(^, ".Contains(line.Last()), null);
    }
}
