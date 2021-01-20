using GeometricFigure.DTO;
using GeometricFigure.Entities;
using System.Threading.Tasks;

namespace GeometricFigure.Services
{
    public interface IFigureService
    {
        Task<int> SetFigure(FigureDTO figure);
        Figure GetFigure(int Id);
    }
}