using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeometricFigure.Entities
{
    public class Figure
    {
        public int Id { get; set; }
        public double? SideA { get; set; }
        public double? SideB { get; set; }
        public double? SideС { get; set; }   
        public double? Radius { get; set; }
        public double? Square { get; set; }
        public double? Perimeter { get; set; }
        public string Name { get; set; }
    }
}
