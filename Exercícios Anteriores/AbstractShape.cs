using Ex1.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ex1.Entities
{
    abstract class AbstractShape : IShape
    {
        public Color2 Color { get; set; }
        public abstract double Area();
    }
}
