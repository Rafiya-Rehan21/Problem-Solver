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

        public Trapezium()
        {
            base.paramters.Add("Base1");
            base.paramters.Add("Base2");
            base.paramters.Add("Height");
        }

        protected override void setVariables()
        {
            if (base.paramterValues.Count == 3)
            {
                Base1 = paramterValues[0];
                Base2 = paramterValues[1];
                Height = paramterValues[2];
            }
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
