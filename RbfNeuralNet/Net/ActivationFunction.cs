using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RbfNeuralNet
{
    public abstract class ActivationFunction
    {
        internal abstract double GetValue(double value, double center, double radius);

        internal abstract double GetDerivative_С(double x, double y, double d, double weight, double center, double radius);

        internal abstract double GetDerivative_W(double x, double y, double d, double weight, double center, double radius);

        internal abstract double GetDerivative_R(double x, double y, double d, double weight, double center, double radius);
    }
}
