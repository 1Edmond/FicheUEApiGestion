using FicheUEApiGestion.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FicheUEApiGestion.Controllers;

//[Authorize]
[ApiController]
public class FicheUEGenerate : ControllerBase
{
    IFicheUEService ficheUEService;
    public FicheUEGenerate(IFicheUEService ficheUEService)
    {
        this.ficheUEService = ficheUEService;
    }


    [HttpGet]
    [Route("fiche/generate")]
    public IActionResult GenerateData()
    {
        ficheUEService.GeneratePdf();
        var filePath = "Files/test.pdf";
        var bytes = System.IO.File.ReadAllBytesAsync(filePath).Result;
        return File(bytes, "application/pdf");

    }

}
