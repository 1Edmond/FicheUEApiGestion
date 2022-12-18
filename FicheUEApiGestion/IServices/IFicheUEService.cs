namespace FicheUEApiGestion.IServices;

public interface IFicheUEService
{
    Task<bool> GeneratePdf();
}
