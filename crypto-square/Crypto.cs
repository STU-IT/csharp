
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Crypto
{
    internal bool NormalizePlaintext;
    internal bool Size;
    private string v;

    public Crypto(string v)
    {
        this.v = v;
    }

    internal bool PlaintextSegments()
    {
        throw new NotImplementedException();
    }

    internal bool Ciphertext()
    {
        throw new NotImplementedException();
    }

    internal bool NormalizeCiphertext()
    {
        throw new NotImplementedException();
    }
}
