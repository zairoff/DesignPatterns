﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class Blur : IFilter
    {
        public void Apply(object obj)
        {
            Console.WriteLine("Applying Blur filter");
        }
    }
}
