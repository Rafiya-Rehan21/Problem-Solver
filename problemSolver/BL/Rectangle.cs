using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problemSolver.BL
{
    public class Rectangle:Shape
    {
        private float Length;
        private float Width;
        private float Height;

        public Rectangle()
        {
            base.paramters.Add("Length");
            base.paramters.Add("Width");
            base.paramters.Add("Height");
        }

        protected override void setVariables()
        {
            if (base.paramterValues.Count == 3)
            {
                Length = paramterValues[0];
                Width = paramterValues[1];
                Height = paramterValues[2];
            }
        }
        public override float calcualteArea()
        {
            float area = Length * Width;
            return area;
        }
        public override float calcualteVolume()
        {
            float volume = Length * Width * Height;
            return volume;
        }
    }
}
