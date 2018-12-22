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
        public double[] oLOutput;

        public NeuralNet(int inputLayerSize, int hiddenLayerSize, ActivationFunction function)
        {
            inputLayer = new LinearInputLayer(inputLayerSize);
            hiddenLayer = new HiddenLayer(hiddenLayerSize, function);
            outputLayer = new OutputLayer();
        }

        public double Calculate(double[] x)
        {
            double result = 0.0;

            iLInput = x;
            iLOutput = inputLayer.CalcLinerOutput(hiddenLayer.NeuronsCount);
            hLInput = hiddenLayer.Calculate(iLOutput);
            result = outputLayer.Calculate(hiddenLayerOutput);

            return result;
        }
    }
}
