﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Ex1.Entities
{
    class Printer : Device, IPrinter
    {
        public override void ProcessDoc(string document)
        {
            Console.WriteLine("Printer processing: " + document);
        }
        public void Print(string document)
        {
            Console.WriteLine("Printer print " + document);
        }
    }
}
