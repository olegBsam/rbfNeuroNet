using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RbfNeuralNet.Net.Layers
{
    public class InputLayer
    {
        private double[][] Weights {get; set;}
        public int NeuronsCount {get; private set;}

        public InputLayer(int size) => NeuronsCount = size;
        public InputLayer(int size, int nextLayerSize): this(size)
        {
            Weights = new double[size][];
            for (int i = 0; i < size; i++)
            {
                Weights[i] = new double[nextLayerSize];
            }
        }

        public double[] Calculate(double[] x)
        {
            if (x.Length == NeuronsCount)
            {
                return x;
            }
            else
            {
                throw new Exception();
            }
        }
    }
}
