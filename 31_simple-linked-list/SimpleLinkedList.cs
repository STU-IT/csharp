using System;

internal class SimpleLinkedList<T>
{
    internal SimpleLinkedList<T> Next;
    internal T Value;
    private int v;
    private System.Collections.Generic.IEnumerable<T> v1;

    public SimpleLinkedList(System.Collections.Generic.IEnumerable<T> v1)
    {
        this.v1 = v1;
    }

    public SimpleLinkedList(int v)
    {
        this.v = v;
    }

    internal SimpleLinkedList<T> Add(T v)
    {
        throw new NotImplementedException();
    }

    internal object Reverse()
    {
        throw new NotImplementedException();
    }
}