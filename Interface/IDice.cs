namespace MonopolyGame;

public interface IDice
{
    public int NumberOfSides { get;}
    public int[] SideValues { get;}
    // private int sideValues[] { get;}

    public int Roll();
}
