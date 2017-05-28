using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Clock
{
    private int hours;
    private int minutes;

    public Clock(int hours)
    {
        this.hours = hours;
    }

    public Clock(int hours, int minutes) : this(hours)
    {
        this.minutes = minutes;
    }

    internal Clock Add(int v)
    {
        throw new NotImplementedException();
    }

    internal Clock Subtract(int v)
    {
        throw new NotImplementedException();
    }
}
