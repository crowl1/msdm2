﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace msdm2.ViewModel
{
    public class Storage
    {
        public string Name { get; }
        public int Distance { get; }
        public Storage(string Name, int Distance)
        {
            this.Name = Name;
            this.Distance = Distance;
        }
    }
}
