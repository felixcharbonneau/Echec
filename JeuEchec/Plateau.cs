namespace JeuEchec;
/// <summary>
/// Plateau pour un jeu d'echec
/// </summary>
public class Plateau
{
    private int derniereCaptureOuMouvPion;
    
    
    /// <summary>
    /// Constructeur
    /// </summary>
    public Plateau()
    {
        derniereCaptureOuMouvPion = 0;
    }
    /// <summary>
    /// liste des pieces avec positions
    /// </summary>
    /// <param name="x">Position en x de la piece</param>
    /// <param name="y">Position en y de la piece</param>
    public Piece this [int x, int y] {
        get{ return this [x, y]; }
        set{ this[x, y] = value; }
    }
    /// <summary>
    /// Determine si le coup est possible
    /// </summary>
    /// <param name="mouvement"></param>
    /// <param name="tour"></param>
    /// <returns>Message contenant la possibilité du tour</returns>
    public String coupPossible(Mouvement mouvement, int tour)
    {
        Piece pieceDebut = this[mouvement.xDebut, mouvement.yDebut];
        Piece pieceFin = this[mouvement.xFin, mouvement.yFin];

        String message = "";

        if (pieceDebut is not null)
        {
            if (pieceDebut.coupEstPossible(mouvement, tour))
            {
                
            }
        }
        else
        {
            message = "Aucune pièce aux coordonnées de départ";
        }
        
        return message;
    }




    public bool provoqueCapture(Mouvement mouvement)
    {
        return this[mouvement.xFin, mouvement.yFin] is not null;
    }
}