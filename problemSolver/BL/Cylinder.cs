using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problemSolver.BL
{
    public class Cylinder:Shape
    {
        private float Radius;
        private float Height;

        public Cylinder()
        {
            base.paramters.Add("Radius");
            base.paramters.Add("Height");
        }

        protected override void setVariables()
        {
            if (base.paramterValues.Count == 2)
            {
                Radius = paramterValues[0];
                Height = paramterValues[1];
            }
        }
        public override float calcualteArea()
        {
            float area = 2 * (float)Math.PI * Radius * (Height + Radius);
            return area;
        }
        public override float calcualteVolume()
        {
            float volume = (float)Math.PI * (float)Math.Pow(Radius, 2) * Height;
            return volume;
        }
    }
}
