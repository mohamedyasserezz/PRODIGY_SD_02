using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRODIGY_SD_02
{
    internal class EasyStrategy : IRandomNumberStrategy
    {
        public int GenerateNumber()
        {
            Random random = new Random();
            return random.Next(1, 20);
        }
    }
}
