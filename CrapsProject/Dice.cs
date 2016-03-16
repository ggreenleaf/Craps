using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrapsProject
{
    class Dice
    {
        public void RollDice(Action<double> BiasFunc)
        {
            var res = BiasFunc(RandomUtil.RandomProbability());

            
        }

        private int MapToResult(double x)
        {

            if (x <= 1)
            {
                return 2;
            }
            else if (x <= 3)
            {
                return 3;
            }
            else if (x <= 6)
            {
                return 4;
            }
            else if (x <= 10)
            {
                return 5;
            }
            else if (x <= 15)
            {
                return 6;
            }
            else if (x <= 21)
            {
                return 7;
            }
            else if (x <= 26)
            {
                return 8;
            }
            else if (x <= 30)
            {
                return 9;
            }
            else if (x <= 33)
            {
                return 10;
            }
            else if (x <= 35)
            {
                return 11;
            }
            else
            {
                return 12;
            }
        }
    }
}
