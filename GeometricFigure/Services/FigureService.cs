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
          
            if (figure.TypeFigure == 1 && (figure.SideB.HasValue || figure.SideС.HasValue || figure.SideС.HasValue))
            {
                return 0;
            }
            try
            {
                if (figure.TypeFigure == 0 && figure.Radius.HasValue)
                {
                    var square = Math.PI * Math.Pow(figure.Radius.Value, 2);
                    var newFigure = new Figure
                    {
                        Name = figure.Name,                       
                        Square = square,                       
                    };
                    var resultFigure = await repository.Add(newFigure);
                    
                    return resultFigure.Id;

                }
                else if (figure.TypeFigure == 1 && figure.SideB.HasValue && figure.SideС.HasValue && figure.SideС.HasValue)
                {
                    var p = (figure.SideB.Value + figure.SideС.Value + figure.SideС.Value) / 2;
                    var perimeter = (figure.SideB.Value + figure.SideС.Value + figure.SideС.Value);
                    var square = Math.Sqrt(p * (p - figure.SideB.Value) * (p - figure.SideС.Value) * (p - figure.SideС.Value));
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
