using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RbfNeuralNet.Net.Layers
{
    public class OutputLayer
    {
        public double Calculate(double[] x)
        {
            return x.Sum();
        }
    }
}
