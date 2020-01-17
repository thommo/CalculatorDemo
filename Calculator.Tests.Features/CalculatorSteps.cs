using CalculatorDemo;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;

namespace Calculator.Tests.Features
{
    [Binding]
    public class CalculatorSteps
    {
        private RpnCalculator _calculator = new RpnCalculator();
        private double _result;

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(double p0)
        {
            _calculator.EnterNumber(p0);
        }
        
        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            _result = _calculator.Add();
        }
        
        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(double p0)
        {
            Assert.AreEqual(_result, p0);
        }

        [Then(@"current value is (.*)")]
        public void ThenCurrentValueIs(double p0)
        {
            Assert.AreEqual(_calculator.CurrentValue(), p0);
        }
    }
}
