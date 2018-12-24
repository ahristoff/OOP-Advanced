﻿using System;

namespace _4_Coding_Tracker
{

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
    public class SoftUniAttribute : Attribute
    {
      
        public SoftUniAttribute(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }
    }
}