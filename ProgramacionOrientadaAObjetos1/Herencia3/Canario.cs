﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia3
{
    internal class Canario : AnimalDomestico, flyable
    {
        public string volar()
        {
            return "vuela vuela canario";
        }
    }
}
