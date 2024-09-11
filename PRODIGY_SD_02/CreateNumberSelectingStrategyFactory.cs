using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRODIGY_SD_02
{
    internal class CreateNumberSelectingStrategyFactory
    {
        public static IRandomNumberStrategy CreateNumberSelectingStrategy(string choice)
        {
            if (choice == "1")
                return new EasyStrategy();
            else
                return new HardStrategy();
        }
    }
}
