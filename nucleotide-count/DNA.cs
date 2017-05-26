using System;
using System.Collections.Generic;

internal class DNA
{
    internal Dictionary<char, int>[] NucleotideCounts = new Dictionary<char, int>[1];
    private string v;

    public DNA(string v)
    {
        this.v = v;
    }

    internal bool Count(char v)
    {
        throw new NotImplementedException();
    }
}

public class InvalidNucleotideException : System.Exception 
{
}
