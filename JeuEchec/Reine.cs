namespace JeuEchec;

public class Reine : Piece
{
    public override bool coupEstPossible(Mouvement mouvement, int tour)
    {
        return mouvement.estDiagonal(1) || mouvement.estVertical() || mouvement.estHorizontal();
    }
}