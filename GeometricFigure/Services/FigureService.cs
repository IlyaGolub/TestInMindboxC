using GeometricFigure.DTO;
using GeometricFigure.Entities;
using GeometricFigure.Infrastructure;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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

        public async Task<int> SetFigure(FigureDTO figure)
        {
            if (figure.Radius.Value == 0 && (figure.SideB.Value == 0 || figure.SideA.Value == 0 || figure.SideС.Value == 0))

                if (figure.Radius.Value != 0 && (figure.SideB.HasValue || figure.SideA.HasValue || figure.SideС.HasValue))
            {
                return 0;
            }
            try
            {
                if (figure.Radius.HasValue && figure.Radius.Value != 0)
                {
                    double square = Math.PI * Math.Pow(figure.Radius.Value, 2);
                    var newFigure = new Figure
                    {
                        Name = figure.Name,                       
                        Square = square,                       
                    };
                    var resultFigure = await repository.Add(newFigure);
                    
                    return resultFigure.Id;

                }
                else if ( figure.SideB.HasValue && figure.SideС.HasValue && figure.SideС.HasValue)
                {                   
                    double p = (figure.SideB.Value + figure.SideA.Value + figure.SideС.Value) / 2;
                    double perimeter = (figure.SideB.Value + figure.SideA.Value + figure.SideС.Value);
                    double square = Math.Sqrt(p * (p - figure.SideB.Value) * (p - figure.SideA.Value) * (p - figure.SideС.Value));
                    var newFigure = new Figure
                    {
                        Name = figure.Name,
                        SideA = figure.SideA,
                        SideB = figure.SideB,
                        SideС = figure.SideС,
                        Square = square,
                        Perimeter = perimeter
                    };
                    var resultFigure = await repository.Add(newFigure);

                    return resultFigure.Id;
                }
            }
            catch (Exception)
            {

                throw;
            }
            return 0;
            
        }
        public Figure  GetFigure(int Id)
        {
     
            return repository.All().AsNoTracking().FirstOrDefault(x => x.Id == Id);
        }

    }
}
