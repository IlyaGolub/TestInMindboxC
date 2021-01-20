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
                return Ok($"Id вашей фигуры {resultId}");;
            }
            catch (Exception)
            {

                return BadRequest("Ошибка добавления фигуры");
            }           
            
        }

        [HttpGet("figure/{id}")]
        public ActionResult GetFigureId()
        {
            return Ok();
        }
    }
}
