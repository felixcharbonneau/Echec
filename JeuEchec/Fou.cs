namespace JeuEchec;

public class Fou : Piece
{
    public override bool coupEstPossible(Mouvement mouvement, int tour)
    {
        return mouvement.estDiagonal(1);
    }
}