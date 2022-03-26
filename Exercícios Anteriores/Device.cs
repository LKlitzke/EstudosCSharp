using System;
using System.Collections.Generic;
using System.Text;

namespace Ex1.Entities
{
    abstract class Device
    {
        public int SerialNumber { get; set; }
        public abstract void ProcessDoc(string document);
    }
}
