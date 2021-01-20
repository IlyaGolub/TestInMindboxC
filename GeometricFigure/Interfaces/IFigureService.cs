using GeometricFigure.DTO;
using System.Threading.Tasks;

namespace GeometricFigure.Services
{
    public interface IFigureService
    {
        Task<int> SetFigure(FigureDTO figure);
    }
}