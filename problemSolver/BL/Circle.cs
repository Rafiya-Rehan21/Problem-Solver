using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problemSolver.BL
{
    public class Circle:Shape
    {
        private float Radius;

        public Circle()
        {
            base.paramters.Add("Radius");
        }

        protected override void setVariables()
        {
            if (base.paramterValues.Count == 1)
                Radius = paramterValues[0];
        }

        public override float calcualteArea()
        {
            float area = (float)Math.Pow(Radius, 2) * (float)Math.PI;
            return area;
        }
        public override float calcualteVolume()
        {
            return 0;
        }
    }
}
