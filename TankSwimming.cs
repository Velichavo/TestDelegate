using System;
using System.Collections.Generic;
using System.Text;

namespace TestDelegate
{
    class TankSwimming : BaseTank
    {
        public TankSwimming()
        {
            swimming = Swim;
        }
    }
}
