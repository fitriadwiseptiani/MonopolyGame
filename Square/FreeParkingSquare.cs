namespace MonopolyGame;

public class FreeParkingSquare : SpecialSquare
{
    public string Name { get; private set; }

    public FreeParkingSquare(int id, string name): base(id, name)
    {
    }
    public override bool EffectSquare(IPlayer player, GameController game){
        return true;
    }
}
