using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Congo.WebApi.Extensions
{
    public static class MathExtensions
    {
        public static double NextDouble(this Random random, double min, double max) => random.NextDouble() * (max - min) + min;
    }
}
