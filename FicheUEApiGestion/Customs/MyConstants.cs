using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace FicheUEApiGestion.Customs;

public static class MyConstants
{
    private const string SECRET_KEY = "EverythingAsCodeByWicode";
    public const string ISSUER = "projetcSharp";
    public const string AUDIANCE = "CSharp";
    public const int EXPIRE = 20;
    public static readonly SymmetricSecurityKey SIGN_KEY = new(Encoding.UTF8.GetBytes(SECRET_KEY));


    public static void AddDefaultDataToDatabase(this FicheUEApiGestionContext context)
    {
        #region Langues
        new List<Langue>()
        {
            new Langue() { Libelle = "Français"},
            new Langue() { Libelle = "Anglais"},
            new Langue() { Libelle = "Néerlandais"},
            new Langue() { Libelle = "Espagnol"}
        }.ForEach(x =>
        {
            context.Add(x);
        });
        #endregion


        #region ModeEvaluation
        new List<ModeEvaluation>()
        {
            new ModeEvaluation(){ Type = "Ecrit"},
            new ModeEvaluation(){ Type = "Oral"},
            new ModeEvaluation(){ Type = "Ecrit-Pratique"},
            new ModeEvaluation(){ Type = "Oral-Pratique"}
        }.ForEach(x =>
        {
            context.Add(x);
        });
        #endregion





    }





}
