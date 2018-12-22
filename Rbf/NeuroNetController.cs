using RbfNeuralNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rbf
{
    class NeuroNetController
    {
        private static NeuroNetController controller;
        public static NeuroNetController Controller => 
            controller == null ? controller = new NeuroNetController() : controller;

        NeuralNet neuroNet;


        public void CreateNeuroNet(int inputSize, int hiddenSize)
        {
            ActivationFunction aFunc = new GaussFunction();

            neuroNet = new NeuralNet(inputSize, hiddenSize, aFunc);
        }

        public double Calculate(double[] inputSet, int prognosticCount)
        {
            double result = 0;


            return result;
        }
    }
}
