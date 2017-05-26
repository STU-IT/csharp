using System;

internal class Meetup
{
    private int month;
    private int v;

    public Meetup(int month, int v)
    {
        this.month = month;
        this.v = v;
    }

    internal DateTime Day(DayOfWeek dayOfWeek, object teenth)
    {
        throw new NotImplementedException();
    }
}