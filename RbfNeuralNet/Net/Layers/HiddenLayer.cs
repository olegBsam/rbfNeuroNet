using RbfNeuralNet.Net.Nerons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RbfNeuralNet.Net.Layers
{
    public class HiddenLayer
    {
        private Neuron[] Neurons;
        public int NeuronsCount
        {
            get; private set;
        }
        private double[] Weights
        {
            get
            {
                return Neurons.Select(o => o.Weight).ToArray();
            }
        }

        public HiddenLayer(int neuronsCount, ActivationFunction function)
        {
            NeuronsCount = neuronsCount;
            Neurons = Neuron.CreateNeurons(neuronsCount, function);
        }

        public double[] Calculate(double[] x)
        {
            if (x.Length == NeuronsCount)
            {
                double[] result = new double[NeuronsCount];

                for (int i = 0; i < NeuronsCount; i++)
                {
                    result[i] = Neurons[i].GetValue(x[i]);
                }
                return result;
            }
            else
            {
                throw new Exception();
            }
        }

        public double[] ApplyWeights(double[] x)
        {
            if (x.Length == NeuronsCount)
            {
                double[] result = new double[NeuronsCount];

                for (int i = 0; i < NeuronsCount; i++)
                {
                    result[i] = Neurons[i].Weight * x[i];
                }
                return result;
            }
            else
            {
                throw new Exception();
            }
        }
    }
}
