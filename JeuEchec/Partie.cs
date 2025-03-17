namespace JeuEchec;

public class Partie
{
    private int tour;
    private Joueur joueurBlanc;
    private Joueur joueurNoir;
    private Plateau plateau;
    
    public string jouerCoup(byte xDebut, byte xFin, byte yDebut, byte yFin)
    {
        string message = "";
        Mouvement mouvement = new Mouvement(xDebut, xFin, yDebut, yFin);
        message += plateau.coupPossible(mouvement, tour);
        
        
        return message;
    }
}