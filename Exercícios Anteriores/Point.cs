﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Ex1.Entities
{
    struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y) : this()
        {
            X = x;
            Y = y;
        }
    }
}
