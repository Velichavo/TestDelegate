using System;
using System.Collections.Generic;
using System.Text;

namespace TestDelegate
{
    abstract class BaseTank
    {
        public delegate void Draw();
        public delegate void Swimming();
        //protected delegate void NoSwimming();

        public Draw draw;
        public Swimming swimming;
        //protected NoSwimming noSwimming;

        public BaseTank()
        {
            swimming = Swim;
            draw = DrawTank;
        }

        public virtual void DrawTank()
        {
            Console.WriteLine("This Tank Draw");
        }

        public virtual void Swim()
        {
            Console.WriteLine("This Tank Swimming");
        }

        public virtual void NoSwim()
        {

        }
    }
}
