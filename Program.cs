using System;
using System.Collections.Generic;

namespace TestDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            List<BaseTank> listTank = new List<BaseTank>();

            listTank.Add(new TankSwimming());
            listTank.Add(new TankSimple());

            foreach(BaseTank e in listTank)
            {
                e.draw();
                e.swimming();

                Console.WriteLine();
            }
        }
    }
}
