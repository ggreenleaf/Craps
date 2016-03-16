using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrapsProject
{
    class RandomUtil
    {
        private static Random rand = new Random();

        public static double RandomProbability()
        {
           return rand.NextDouble();
        } 
    }
}
