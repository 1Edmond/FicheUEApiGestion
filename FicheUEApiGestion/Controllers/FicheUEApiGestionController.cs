using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FicheUEApiGestion.Controllers;

[Authorize]
[ApiController]
public class FicheUEApiGestionController : ControllerBase
{
    FicheUEApiGestionContext _context;
    public FicheUEApiGestionController(FicheUEApiGestionContext context)
        => _context = context;
    

    [HttpPost]
    [Route("fiche/generate")]
    public IActionResult GenerateData()
    {
        
        

        return Ok();
    }


    [HttpGet]
    [Route("")]
    public IActionResult GetData()
    {
        return Ok();
    }


}
