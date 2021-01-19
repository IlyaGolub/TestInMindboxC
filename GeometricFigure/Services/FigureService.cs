using GeometricFigure.DTO;
using GeometricFigure.Entities;
using GeometricFigure.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeometricFigure.Services
{
    public class FigureService : IFigureService
    {
        private readonly IRepository<Figure> repository;
        public FigureService(IRepository<Figure> repository)
        {
            this.repository = repository;
        }

        public void SetFigure(FigureDTO figure)
        {
            double square = 0;            
            double perimeter = 0;
            if (figure.TypeFigure == 1 && (figure.SideB.HasValue || figure.SideС.HasValue || figure.SideС.HasValue))
            {
                return;
            }
            try
            {
                if (figure.TypeFigure == 0 && figure.Radius.HasValue)
                {
                    square = Math.PI * Math.Pow(figure.Radius.Value, 2);
                    var result = new Figure
                    {
                        Name = figure.Name,                       
                        Square = square,                       
                    };
                    repository.Add(result);
                   
                }
                else if (figure.TypeFigure == 1 && figure.SideB.HasValue && figure.SideС.HasValue && figure.SideС.HasValue)
                {
                    var p = (figure.SideB.Value + figure.SideС.Value + figure.SideС.Value) / 2;
                    perimeter = (figure.SideB.Value + figure.SideС.Value + figure.SideС.Value);
                    square = Math.Sqrt(p * (p - figure.SideB.Value) * (p - figure.SideС.Value) * (p - figure.SideС.Value));
                    var result = new Figure
                    {
                        Name = figure.Name,
                        SideA = figure.SideA,
                        SideB = figure.SideB,
                        SideС = figure.SideС,
                        Square = square,
                        Perimeter = perimeter
                    };
                    repository.Add(result);
                  
                }
            }
            catch (Exception)
            {

                throw;
            }
            
        }

    }
}
