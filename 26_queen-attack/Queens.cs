using System;

internal class Queens
{
    private Queen black;
    private Queen white;

    public Queens(Queen white, Queen black)
    {
        this.white = white;
        this.black = black;
    }

    internal bool? CanAttack()
    {
        throw new NotImplementedException();
    }
}