using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GeometricFigure.DTO;
using GeometricFigure.Entities;
using GeometricFigure.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace GeometricFigure.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FigureController : ControllerBase
    {
        private readonly IFigureService figureService;
        public FigureController(IFigureService figureService)
        {
            this.figureService = figureService;
        }

        [HttpPost("figure")]
        public async Task<ActionResult> SetFigureAsync([FromBody]FigureDTO figure)
        {
            try
            {
                var resultId = await figureService.SetFigure(figure);
                if (resultId == 0) return BadRequest("В треугольнике или круге не может быть стороны и радиуса");
                return Ok($"Id вашей фигуры {resultId}");;
            }
            catch (Exception)
            {
                throw;
            
            }           
            
        }

        [HttpGet("{Id}")]
        public ActionResult GetFigureId([FromRoute] int Id)
        {
            try
            {
                var result = figureService.GetFigure(Id);
                return Ok(result);
            }
            catch (Exception)
            {               
               return BadRequest($"Фигура с данным Id ={Id} не найдена");
            }
            
        }
    }
}
