﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace msdm2.ViewModel
{
    public class Goods
    {
        public string Name { get; }
        public long Time { get; }

        public Goods(string Name, long Time)
        {
            this.Name = Name;
            this.Time = Time;
        }
    }
}
