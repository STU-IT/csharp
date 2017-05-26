using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Cipher
{
    internal string Key;
    private string v;

    public Cipher(string v)
    {
        this.v = v;
    }

    public Cipher()
    {
    }

    internal bool Encode(string v)
    {
        throw new NotImplementedException();
    }

    internal bool Decode(object p)
    {
        throw new NotImplementedException();
    }
}
