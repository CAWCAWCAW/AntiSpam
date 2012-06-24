﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AntiSpam
{
    public static class Extensions
    {
        public static int GetCount(this string str, char c)
        {
            int charCount = 0;
            foreach (char chr in str)
            {
                if (chr == c)
                {
                    charCount++;
                }
            }
            return charCount;
        }

        public static double UpperCount(this string str)
        {
            double capsCount = 0;
            double charCount = 0;
            foreach (char c in str)
            {
                if (char.IsLetter(c))
                {
                    charCount++;
                    if (char.IsUpper(c))
                    {
                        capsCount++;
                    }
                }
            }
            return capsCount / charCount;
        }
    }
}
