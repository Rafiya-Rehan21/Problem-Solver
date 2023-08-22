using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using org.matheval;

namespace problemSolver.BL
{
    abstract public class Shape
    {
        protected List<string> paramters= new List<string>();
        protected List<float> paramterValues = new List<float>();
        public abstract float calcualteArea();
        public abstract float calcualteVolume();
    }
}
