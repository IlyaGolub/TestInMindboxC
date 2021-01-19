using GeometricFigure.DTO;
using System.Threading.Tasks;

namespace GeometricFigure.Services
{
    public interface IFigureService
    {
        void SetFigure(FigureDTO figure);
    }
}