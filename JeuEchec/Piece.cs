namespace JeuEchec;

public abstract class Piece {
    private Couleur m_couleur;
    private int m_dernierTourBouge;
    private bool m_estCapturable;
    private bool m_peuColision;
    private bool m_peuEnPassant;
    private bool m_peuPromotion;
    private bool m_peuInitierRoque;


    public abstract bool coupEstPossible(Mouvement mouvement, int tour);
}