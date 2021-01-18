using GeometricFigure.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeometricFigure.Infrastructure
{
    public class GeometricFigureContext: DbContext
    {

        public GeometricFigureContext(DbContextOptions<GeometricFigureContext> options) : base(options) 
        { 

        }

        public DbSet<Figure> Figure { set; get; }
    }
}
