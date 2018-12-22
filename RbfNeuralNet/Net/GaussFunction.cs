using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RbfNeuralNet
{
    public class GaussFunction : ActivationFunction
    {
        internal override double GetDerivative_R(double x, double y, double d, double weight, double center, double radius)
        {
            double fr = 15.0 / 16.0 * weight * (1 - ((x - center) / (2 * Math.Pow(radius, 2))));
            double result = (fr * (1 - ((x - center) / (2 * Math.Pow(radius, 2))) - d)) * (fr * 2) * (-3 * (center - x) / 2) / Math.Pow(radius, 3);
            return result;
        }

        internal override double GetDerivative_W(double x, double y, double d, double weight, double center, double radius)
        {
            double funcRes = GetValue(x, center, radius);
            double result = (y - d) * funcRes * (funcRes * weight - d);
            return result;
        }

        internal override double GetDerivative_С(double x, double y, double d, double weight, double center, double radius)
        {
            double result = 15.0 / 16.0 * weight * Math.Pow(1 - ((x - center) / (2 * Math.Pow(radius, 2))), 2);
            result *= 15.0 / 16.0 * weight * (1 - ((x - center) / (2 * Math.Pow(radius, 2)))) * 1 / Math.Pow(radius, 2);
            return result;
        }

        internal override double GetValue(double value, double center, double radius)
        {
            double val1 = - Math.Pow(value - center, 2);
            val1 = val1 / (2 * radius * radius);
            val1 = Math.Exp(val1);
            return val1;
        }
    }
}
