using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problemSolver.BL
{
    public class Cone:Shape
    {
        private float Radius;
        private float Height;

        public Cone()
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
            float area = ((float)Math.PI * Radius) * (Radius+(float)Math.Sqrt(((float)Math.Pow(Radius, 2) + (float)Math.Pow(Height, 2))));
            return area;
        }
        public override float calcualteVolume()
        {
            float volume = ((float)Math.PI * (float)Math.Pow(Radius, 2) * Height) / 3;
            return volume;
        }
    }
}
