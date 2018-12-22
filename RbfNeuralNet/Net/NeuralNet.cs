using RbfNeuralNet.Net.Layers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RbfNeuralNet
{
    public class NeuralNet
    {
        private InputLayer inputLayer;
        private HiddenLayer hiddenLayer;
        private OutputLayer outputLayer;

        public double[] iLInput;
        public double[] iLOutput;

        public double[] hLInput;
        public double[] hLOutput;

        public double[] oLInput;
        public double oLOutput;

        public NeuralNet(int inputLayerSize, int hiddenLayerSize, ActivationFunction function)
        {
            inputLayer = new InputLayer(inputLayerSize);
            hiddenLayer = new HiddenLayer(hiddenLayerSize, function);
            outputLayer = new OutputLayer();
        }

        public double Calculate(double[] x)
        {
            double result = 0.0;

            iLInput = x;
            iLOutput = inputLayer.Calculate(iLInput);

            hLInput = Link1(iLOutput);
            hLOutput = hiddenLayer.Calculate(hLInput);

            oLInput = Link2(hLOutput);
            oLOutput = outputLayer.Calculate(oLInput);

            return result;
        }

        private double[] Link2(double[] hLOutput)
        {
            double[] result = new double[hiddenLayer.NeuronsCount];
            for (int i = 0; i < hiddenLayer.NeuronsCount; i++)
            {
                result[i] = hLOutput[i] * hiddenLayer.Weights[i];
            }
            return result;
        }

        private double[] Link1(double[] x)
        {
            return x;
        }


    }
}
