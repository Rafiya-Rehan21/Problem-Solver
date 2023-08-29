using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problemSolver.BL
{
    public class Square:Shape
    {
        private float Length;

        public Square()
        {
            base.paramters.Add("Length");
        }

        protected override void setVariables()
        {
            if (base.paramterValues.Count == 1)
            {
                Length = paramterValues[0];
            }
        }

        public override float calcualteArea()
        {
            float area = (float)Math.Pow(Length, 2);
            return area;
        }
        public override float calcualteVolume()
        {
            float volume = (float)Math.Pow(Length, 3);
            return volume;
        }
    }
}
