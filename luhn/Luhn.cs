using System;

class Luhn
{
    private int v;

    public Luhn(int v)
    {
        this.v = v;
    }

    public bool Addends { get; internal set; }
    public bool CheckDigit { get; internal set; }
    public int Checksum { get; internal set; }
    public bool Valid { get; internal set; }

    internal static bool Create(int v)
    {
        throw new NotImplementedException();
    }
}