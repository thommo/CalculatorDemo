using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace Calculator.Tests.Features
{
    [Binding]
    public class StepArgumentTransformations
    {
        [StepArgumentTransformation]
        public double TransformResultToDouble(string expression)
        {
            return double.Parse(expression, System.Globalization.CultureInfo.InvariantCulture);
        }
    }
}
