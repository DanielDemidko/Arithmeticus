using System;

struct Analysis
{
    public readonly Boolean IsSuccessfully;
    public readonly Char? UncorrectSymbol;

    public Analysis(Boolean successfull, Char? symbol)
    {
        IsSuccessfully = successfull;
        UncorrectSymbol = symbol;
    }
}

