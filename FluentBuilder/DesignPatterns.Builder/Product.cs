﻿using System.Collections.Generic;

namespace DesignPatterns.Builder
{
    public class Product
    {
        public List<string> Parts = new List<string>();

        public void Add(string part)
        {
            Parts.Add(part);
        }
    }
}