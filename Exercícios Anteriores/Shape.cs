﻿using Ex1.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ex1.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();
    }
}
