﻿using IOC.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace IOC.Manufacturers
{
    public class BMW : ICar
    {
        private int _miles = 0;
        public int Run()
        {
            return ++_miles;
        }
    }
}
