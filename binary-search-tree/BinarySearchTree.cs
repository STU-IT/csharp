using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class BinarySearchTree
{
    internal BinarySearchTree Left;
    internal BinarySearchTree Right;
    internal int Value;
    private int v;
    private int[] v1;

    public BinarySearchTree(int[] v1)
    {
        this.v1 = v1;
    }

    public BinarySearchTree(int v)
    {
        this.v = v;
    }

    internal BinarySearchTree Add(int v)
    {
        throw new NotImplementedException();
    }

    internal object AsEnumerable()
    {
        throw new NotImplementedException();
    }
}
