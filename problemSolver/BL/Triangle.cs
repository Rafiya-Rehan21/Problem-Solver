using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problemSolver.BL
{
    public class Triangle:Shape
    {
        private float Base;
        private float Height;

        public Triangle()
        {
            base.paramters.Add("Base");
            base.paramters.Add("Height");
        }

        protected override void setVariables()
        {
            if (base.paramterValues.Count == 2)
            {
                Base = paramterValues[0];
                Height = paramterValues[1];
            }
        }

        public override float calcualteArea()
        {
            float area = 0.5F*(Base*Height);
            return area;
        }
        public override float calcualteVolume()
        {
            return 0;
        }
    }
}
