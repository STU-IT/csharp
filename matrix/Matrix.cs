using System;

class Matrix
{
    private string input;

    public int Rows { get; internal set; }
    public int Cols { get; internal set; }

    public Matrix(string input)
    {
        this.input = input;
    }

    internal int[] Row(int v)
    {
        throw new NotImplementedException();
    }

    internal int[] Col(int v)
    {
        throw new NotImplementedException();
    }
}