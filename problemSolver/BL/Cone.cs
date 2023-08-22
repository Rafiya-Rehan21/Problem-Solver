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

        public Cone(string Radius,string Height)
        {
            base.paramters.Add(Radius);
            base.paramters.Add(Height);
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
