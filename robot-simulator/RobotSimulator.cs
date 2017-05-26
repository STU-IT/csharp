using System;

internal class RobotSimulator
{
    internal bool Bearing;
    private Coordinate coordinate;
    private object west;
    internal bool Coordinate;

    public RobotSimulator(object west, Coordinate coordinate)
    {
        this.west = west;
        this.coordinate = coordinate;
    }

    internal void TurnRight()
    {
        throw new NotImplementedException();
    }

    internal void TurnLeft()
    {
        throw new NotImplementedException();
    }

    internal void Simulate(string v)
    {
        throw new NotImplementedException();
    }
}