﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Ex1.Entities
{
    class Scanner : Device, IScanner
    {
        public override void ProcessDoc(string document)
        {
            Console.WriteLine("Scanner processing: " + document);
        }
        public string Scan()
        {
            return "Scanner scan result";
        }
    }
}
