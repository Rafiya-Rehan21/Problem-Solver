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
        protected abstract void setVariables();

        public List<string> GetParameters() => paramters;

        public void SetParameter(string name, float value)
        {
            if (paramterValues.Count != paramters.Count)
            {
                paramterValues = new List<float>( new float[paramters.Count]);
            }

            int idx = paramters.IndexOf(name);

            if (idx == -1)
                return;

            paramterValues[idx] = value;

            setVariables();
        }
    }
}
