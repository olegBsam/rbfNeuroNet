using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RbfNeuralNet.Net.Nerons
{
    public class Neuron
    {
        private double weight;
        private double center;
        private double radius;

        private ActivationFunction function;

        public double Weight { get => weight; set => weight = value; }
        public double Center { get => center; set => center = value; }
        public double Radius { get => radius; set => radius = value; }

        public Neuron(double weight, double center, double radius, ActivationFunction function)
        {
            this.weight = weight;
            this.center = center;
            this.radius = radius;
            this.function = function;
        }

        internal static Neuron[] CreateNeurons(int neuronsCount, ActivationFunction activationFunction)
        {
            var random = new Random();
            var neurons = new Neuron[neuronsCount];
            var maxCenter = double.MinValue;

            for (int i = 0; i < neuronsCount; i++)
            {
                var weight = random.NextDouble();
                var center = random.NextDouble();
                neurons[i] = new Neuron(weight, center, 0, activationFunction);

                if (maxCenter < center)
                {
                    maxCenter = center;
                }
            }

            var radius = maxCenter / (Math.Sqrt(2.0 * neuronsCount));

            for (int i = 0; i < neuronsCount; i++)
            {
                neurons[i].Radius = radius;
            }

            return neurons;
        }

        public double GetValue(double x)
        {
            double result = 0;
            result = function.GetValue(x, center, radius);
            return result;
        }

        public double GetDeriative_C(double x, double y, double d)
        {
            double result = 0;
            result = function.GetDerivative_С(x, y, d, weight, center, radius);
            return result;
        }
        public double GetDeriative_W(double x, double y, double d)
        {
            double result = 0;
            result = function.GetDerivative_W(x, y, d, weight, center, radius);
            return result;
        }
        public double GetDeriative_R(double x, double y, double d)
        {
            double result = 0;
            result = function.GetDerivative_R(x, y, d, weight, center, radius);
            return result;
        }
    }
}
