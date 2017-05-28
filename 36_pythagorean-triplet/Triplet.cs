using System.Linq;
using System;

internal class Triplet
{
    private int v1;
    private int v2;
    private int v3;

    public Triplet(int v1, int v2, int v3)
    {
        this.v1 = v1;
        this.v2 = v2;
        this.v3 = v3;
    }

    public int Sum()
    {
        throw new System.NotImplementedException();
    }

    internal int Product()
    {
        throw new NotImplementedException();
    }

    internal bool IsPythagorean()
    {
        throw new NotImplementedException();
    }

    internal static Triplet Where(int maxFactor)
    {
        throw new NotImplementedException();
    }

    internal static Triplet Where(int sum, int maxFactor, int minFactor = 0)
    {
        throw new NotImplementedException();
    }

    internal static Triplet Where(int minFactor, int maxFactor)
    {
        throw new NotImplementedException();
    }

    internal object OrderBy(Func<object, object> p)
    {
        throw new NotImplementedException();
    }

    internal Triplet Select(Func<Triplet, int> p)
    {
        throw new NotImplementedException();
    }

}