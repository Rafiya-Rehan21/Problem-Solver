using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problemSolver.BL
{
    public class Trapezium:Shape
    {
        private float Base1;
        private float Base2;
        private float Height;

        public Trapezium(string Base1, string Base2, string Height)
        {
            base.paramters.Add(Base1);
            base.paramters.Add(Base2);
            base.paramters.Add(Height);
        }
        public override float calcualteArea()
        {
            float area = ((Base1+Base2)/2)*Height;
            return area;
        }
        public override float calcualteVolume()
        {
            return 0;
        }
    }
}
