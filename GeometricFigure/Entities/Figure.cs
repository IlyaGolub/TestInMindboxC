using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeometricFigure.Entities
{
    public class Figure
    {
        public int Id { get; set; }
        public int SideA{ get; set; }
        public int SideB { get; set; }
        public int? SideС { get; set; }
        public int? SideD { get; set; }
        public int? Кadius { get; set; }
        public int? Square { get; set; }
        public int? Perimeter { get; set; }
        public string Name { get; set; }
    }
}
