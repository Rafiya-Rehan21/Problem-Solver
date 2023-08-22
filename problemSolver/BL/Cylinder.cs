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

        public Cylinder(string Radius, string Height)
        {
            base.paramters.Add(Radius);
            base.paramters.Add(Height);
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
