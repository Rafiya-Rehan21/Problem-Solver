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

        public Rectangle(string Length,string Width, string Height)
        {
            base.paramters.Add(Length);
            base.paramters.Add(Width);
            base.paramters.Add(Height);
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
