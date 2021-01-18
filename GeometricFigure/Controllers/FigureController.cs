using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace GeometricFigure.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FigureController : ControllerBase
    {     

        public FigureController()
        {
          
        }

        [HttpPost("figure")]
        public void GetFigure()
        {
           
        }

        [HttpGet("figure/{id}")]
        public void GetFigureId()
        {
          
        }
    }
}
