using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Garden
{
    private string[] v1;
    private string v2;

    public Garden(string[] v1, string v2)
    {
        this.v1 = v1;
        this.v2 = v2;
    }

    internal static Garden DefaultGarden(string v)
    {
        throw new NotImplementedException();
    }

    internal object GetPlants(string v)
    {
        throw new NotImplementedException();
    }
}
