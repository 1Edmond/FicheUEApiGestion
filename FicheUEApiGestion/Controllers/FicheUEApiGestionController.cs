using FicheUEApiGestion.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Net.Http.Headers;

namespace FicheUEApiGestion.Controllers;

[ApiController]
[Route("getion/")]
public class FicheUEApiGestionController : ControllerBase
{
    FicheUEApiGestionContext _context;
    public FicheUEApiGestionController(FicheUEApiGestionContext context)
        => (_context) = (context);
    


    #region Enseignant
    [HttpPost]
    [Route("Enseigants/Add")]
    public IActionResult AddEnseingant([FromBody] Enseignant enseignant)
    {
        if (enseignant is null)
            return BadRequest();
        if (_context.Enseignants.Any(x => x.Nom.Equals(enseignant.Nom) && x.Prenom.Equals(enseignant.Prenom)))
            return BadRequest("L'enseingant existe déjà");
        _context.Add(enseignant);
        _context.SaveChanges();
        return Ok();
    }
    
    [HttpGet]
    [Route("Enseigants")]
    public IActionResult GetEnseignant()
    {
        return Ok(_context.Enseignants.ToList());
    }

    [HttpDelete]
    [Route("Enseigants/Delete/{id}")]
    public IActionResult DeleteEnseignant(int id)
    {
        if (!_context.Enseignants.Any(x => x.Id.Equals(id)))
            return BadRequest();
        var enseignant = _context.Enseignants.Find(id);
        if (enseignant is null)
            return BadRequest();
        _context.Enseignants.Remove(enseignant);
        _context.SaveChanges();
        return NoContent();
    }
    
    [HttpPut]
    [Route("Enseigants/Update")]
    public IActionResult UpdateEnseignant([FromBody] Enseignant enseignant)
    {
        if (!_context.Enseignants.Any(x => x.Id.Equals(enseignant.Id)))
            return BadRequest("L'enseingant existe déjà");
        if (enseignant is null)
            return BadRequest();
        _context.Update(enseignant);
        _context.SaveChanges();
        return Ok();
    }

    [HttpGet]
    [Route("Enseignants/{id}")]
    public IActionResult GetEnseignant(int id)
    {
        if (!_context.Enseignants.Any(x => x.Id.Equals(id)))
            return BadRequest();
        var enseignant = _context.Enseignants.Find(id);
        if (enseignant is null)
            return BadRequest();
        return Ok(enseignant);
    }
    #endregion

    #region Compétences

    [HttpGet]
    [Route("Competences")]
    public IActionResult GetCompetence()
    {
        return Ok(_context.Competences.ToList());
    }


    [HttpGet]
    [Route("Competences/{id}")]
    public IActionResult GetCompetence(int id)
    {
        if (!_context.Competences.Any(x => x.Id.Equals(id)))
            return BadRequest();
        var compentence = _context.Competences.Find(id);
        if (compentence is null)
            return BadRequest();
        return Ok(compentence);
    }

    [HttpPost]
    [Route("Competences/Add")]
    public IActionResult AddCompetence([FromBody] Competence competence)
    {
        if (_context.Competences.Any(x => x.Libelle.Equals(competence.Libelle)))
            return BadRequest("La competence existe déjà");
        if (competence is null)
            return BadRequest();
        _context.Add(competence);
        _context.SaveChanges();
        return Ok();
    }


    [HttpDelete]
    [Route("Competences/Delete/{id}")]
    public IActionResult DeleteCompetence(int id)
    {
        if (!_context.Competences.Any(x => x.Id.Equals(id)))
            return BadRequest();
        var competence = _context.Competences.Find(id);
        if (competence is null)
            return BadRequest();
        _context.Competences.Remove(competence);
        _context.SaveChanges();
        return NoContent();
    }

    [HttpPut]
    [Route("Competences/Update")]
    public IActionResult UpdateCompetence([FromBody] Competence competence)
    {
        if (!_context.Competences.Any(x => x.Id.Equals(competence.Id)))
            return BadRequest("La compétence existe déjà");
        if (competence is null)
            return BadRequest();
        _context.Update(competence);
        _context.SaveChanges();
        return Ok();
    }


    #endregion

    #region Capacités

    [HttpGet]
    [Route("Capacites")]
    public IActionResult GetCapacite()
    {
        return Ok(_context.Capacites.ToList());
    }


    [HttpGet]
    [Route("Capacites/{id}")]
    public IActionResult GetCapacite(int id)
    {
        if (!_context.Capacites.Any(x => x.Id.Equals(id)))
            return BadRequest();
        var temp = _context.Capacites.Find(id);
        if (temp is null)
            return BadRequest();
        return Ok(temp);
    }

    [HttpPost]
    [Route("Capacites/Add")]
    public IActionResult AddCapacite([FromBody] Capacite capacite)
    {
        if (_context.Capacites.Any(x => x.Libelle.Equals(capacite.Libelle)))
            return BadRequest("La capactiée existe déjà");
        if (capacite is null)
            return BadRequest();
        _context.Add(capacite);
        _context.SaveChanges();
        return Ok();
    }


    [HttpDelete]
    [Route("Capacites/Delete/{id}")]
    public IActionResult DeleteCapacite(int id)
    {
        if (!_context.Capacites.Any(x => x.Id.Equals(id)))
            return BadRequest();
        var capacite = _context.Capacites.Find(id);
        if (capacite is null)
            return BadRequest();
        _context.Capacites.Remove(capacite);
        _context.SaveChanges();
        return NoContent();
    }

    [HttpPut]
    [Route("Capacites/Update")]
    public IActionResult UpdateCapacite([FromBody] Capacite capacite)
    {
        if (!_context.Capacites.Any(x => x.Id.Equals(capacite.Id)))
            return BadRequest("La capacité existe déjà");
        if (capacite is null)
            return BadRequest();
        _context.Update(capacite);
        _context.SaveChanges();
        return Ok();
    }
    #endregion

    #region Mode Evaluation

    [HttpGet]
    [Route("ModeEvaluation")]
    public IActionResult GetModeEvaluation()
    {
        return Ok(_context.ModeEvaluations.ToList());
    }


    [HttpGet]
    [Route("ModeEvaluation/{id}")]
    public IActionResult GetModeEvaluation(int id)
    {
        if (!_context.ModeEvaluations.Any(x => x.Id.Equals(id)))
            return BadRequest();
        var temp = _context.ModeEvaluations.Find(id);
        if (temp is null)
            return BadRequest();
        return Ok(temp);
    }

    [HttpPost]
    [Route("ModeEvaluation/Add")]
    public IActionResult AddModeEvaluation([FromBody] ModeEvaluation modeEvaluation)
    {
        if (_context.ModeEvaluations.Any(x => x.Type.Equals(modeEvaluation.Type)))
            return BadRequest("Le Mode d'évaluation existe déjà");
        if (modeEvaluation is null)
            return BadRequest();
        _context.Add(modeEvaluation);
        _context.SaveChanges();
        return Ok();
    }


    [HttpDelete]
    [Route("ModeEvaluation/Delete/{id}")]
    public IActionResult DeleteModeEvaluation(int id)
    {
        if (!_context.ModeEvaluations.Any(x => x.Id.Equals(id)))
            return BadRequest();
        var temp = _context.ModeEvaluations.Find(id);
        if (temp is null)
            return BadRequest();
        _context.ModeEvaluations.Remove(temp);
        _context.SaveChanges();
        return NoContent();
    }

    [HttpPut]
    [Route("ModeEvaluation/Update")]
    public IActionResult UpdateModeEvaluations([FromBody] ModeEvaluation modeEvaluation)
    {
        if (!_context.ModeEvaluations.Any(x => x.Id.Equals(modeEvaluation.Id)))
            return BadRequest("Le mode d'évaluation existe déjà");
        if (modeEvaluation is null)
            return BadRequest();
        _context.Update(modeEvaluation);
        _context.SaveChanges();
        return Ok();
    }

    #endregion

    #region Cursus

    [HttpGet]
    [Route("Cursus")]
    public IActionResult GetCursus()
    {
        return Ok(_context.Cursus.ToList());
    }


    [HttpGet]
    [Route("Cursus/{id}")]
    public IActionResult GetCursus(int id)
    {
        if (!_context.Cursus.Any(x => x.Id.Equals(id)))
            return BadRequest();
        var temp = _context.Cursus.Find(id);
        if (temp is null)
            return BadRequest();
        return Ok(temp);
    }

    [HttpPost]
    [Route("Cursus/Add")]
    public IActionResult AddCursus([FromBody] Cursus cursus)
    {
        if (_context.Cursus.Any(x => x.Implantation.Equals(cursus.Implantation) && x.Libelle.Equals(cursus.Libelle)))
            return BadRequest("Le cursus existe déjà");
        if (cursus is null)
            return BadRequest();
        _context.Add(cursus);
        _context.SaveChanges();
        return Ok();
    }


    [HttpDelete]
    [Route("Cursus/Delete/{id}")]
    public IActionResult DeleteCursus(int id)
    {
        if (!_context.Cursus.Any(x => x.Id.Equals(id)))
            return BadRequest();
        var temp = _context.Cursus.Find(id);
        if (temp is null)
            return BadRequest();
        _context.Cursus.Remove(temp);
        _context.SaveChanges();
        return NoContent();
    }

    [HttpPut]
    [Route("Cursus/Update")]
    public IActionResult UpdateCursus([FromBody] Cursus cursus)
    {
        if (!_context.Cursus.Any(x => x.Id.Equals(cursus.Id)))
            return BadRequest("Le cursus existe déjà");
        if (cursus is null)
            return BadRequest();
        _context.Update(cursus);
        _context.SaveChanges();
        return Ok();
    }

    #endregion

    #region Cours

    [HttpGet]
    [Route("Cours")]
    public IActionResult GetCours()
    {
        return Ok(_context.Cours.ToList());
    }


    [HttpGet]
    [Route("Cours/{id}")]
    public IActionResult GetCours(int id)
    {
        if (!_context.Cours.Any(x => x.Id.Equals(id)))
            return BadRequest();
        var temp = _context.Cours.Find(id);
        if (temp is null)
            return BadRequest();
        return Ok(temp);
    }

    [HttpPost]
    [Route("Cours/Add")]
    public IActionResult AddCours([FromBody] Cours cours)
    {
        if (_context.Cours.Any(x => x.Libelle.Equals(cours.Libelle)))
            return BadRequest("Le cours existe déjà");
        if (cours is null)
            return BadRequest();
        _context.Add(cours);
        _context.SaveChanges();
        return Ok();
    }


    [HttpDelete]
    [Route("Cours/Delete/{id}")]
    public IActionResult DeleteCours(int id)
    {
        if (!_context.Cours.Any(x => x.Id.Equals(id)))
            return BadRequest();
        var temp = _context.Cours.Find(id);
        if (temp is null)
            return BadRequest();
        _context.Cours.Remove(temp);
        _context.SaveChanges();
        return NoContent();
    }

    [HttpPut]
    [Route("Cours/Update")]
    public IActionResult UpdateCours([FromBody] Cours cours)
    {
        if (!_context.Cours.Any(x => x.Id.Equals(cours.Id)))
            return BadRequest("Le cours existe déjà");
        if (cours is null)
            return BadRequest();
        _context.Update(cours);
        _context.SaveChanges();
        return Ok();
    }

    #endregion
    
    #region Champ Libre

    [HttpGet]
    [Route("Libres")]
    public IActionResult GetLibres()
    {
        return Ok(_context.Libres.ToList());
    }


    [HttpGet]
    [Route("Libres/Cours/{id}")]
    public IActionResult GetLibre(int id)
    {
        if (!_context.Libres.Any(x => x.Id.Equals(id)))
            return BadRequest();
        var temp = _context.Libres.Find(id);
        if (temp is null)
            return BadRequest();
        return Ok(temp);
    }

    [HttpPost]
    [Route("Libres/Add")]
    public IActionResult AddLibre([FromBody] Libre libre)
    {
        if (_context.Libres.Any(x => x.Valeur.Equals(libre.Valeur) && x.Type.Equals(libre.Type)))
            return BadRequest("Le champ là existe déjà");
        if (libre is null)
            return BadRequest();
        _context.Add(libre);
        _context.SaveChanges();
        return Ok();
    }


    [HttpDelete]
    [Route("Libres/Delete/{id}")]
    public IActionResult DeleteLibre(int id)
    {
        if (!_context.Libres.Any(x => x.Id.Equals(id)))
            return BadRequest();
        var temp = _context.Libres.Find(id);
        if (temp is null)
            return BadRequest();
        _context.Libres.Remove(temp);
        _context.SaveChanges();
        return NoContent();
    }

    [HttpPut]
    [Route("Libres/Update")]
    public IActionResult UpdateLibres([FromBody] Libre libre)
    {
        if (!_context.Libres.Any(x => x.Id.Equals(libre.Id)))
            return BadRequest("Le cours existe déjà");
        if (libre is null)
            return BadRequest();
        _context.Update(libre);
        _context.SaveChanges();
        return Ok();
    }

	#endregion

	#region UE
	[HttpGet]
	[Route("UEs")]
	public IActionResult GetUE()
	{
		return Ok(_context.UEs.ToList());
	}


	[HttpGet]
	[Route("UEs/{Code}")]
	public IActionResult GetUEs(string code)
	{
		if (!_context.UEs.Any(x => x.CodeUE.Equals(code)))
			return BadRequest();
		var temp = _context.UEs.Find(code);
		if (temp is null)
			return BadRequest();
		return Ok(temp);
	}

	[HttpPost]
	[Route("UEs/Add")]
	public IActionResult AddUE([FromBody] UE ue)
	{
		if (_context.UEs.Any(x => x.NomUE.Equals(ue.NomUE)))
			return BadRequest("Le cours existe déjà");
		if (ue is null)
			return BadRequest();
		_context.Add(ue);
		_context.SaveChanges();
		return Ok();
	}


	[HttpDelete]
	[Route("UEs/Delete/{Code}")]
	public IActionResult DeleteUE(string code)
	{
		if (!_context.UEs.Any(x => x.CodeUE.Equals(code)))
			return BadRequest();
		var temp = _context.UEs.Find(code);
		if (temp is null)
			return BadRequest();
		_context.UEs.Remove(temp);
		_context.SaveChanges();
		return NoContent();
	}

	[HttpPut]
	[Route("UEs/Update")]
	public IActionResult UpdateCours([FromBody] UE ue)
	{
		if (!_context.UEs.Any(x => x.CodeUE.Equals(ue.CodeUE)))
			return BadRequest("Le cours existe déjà");
		if (ue is null)
			return BadRequest();
		_context.Update(ue);
		_context.SaveChanges();
		return Ok();
	}
	#endregion









}
