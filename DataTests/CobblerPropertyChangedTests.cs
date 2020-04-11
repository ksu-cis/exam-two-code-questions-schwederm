using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using ExamTwoCodeQuestions.Data;
using System.ComponentModel;

namespace ExamTwoCodeQuestions.DataTests
{
    public class CobblerPropertyChangedTests
    {
        [Fact]
        public void CobblerImplementsINotifyPropertyChanged()
        {
            var cobbler = new Cobbler();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(cobbler);
        }

        [Fact]
        public void ChangingFruitPropertyShouldInvokePropertyChangedForFruitFilling()
        {
            var cobbler = new Cobbler();
            Assert.PropertyChanged(cobbler, "Fruit", () =>
            {
                cobbler.Fruit = FruitFilling.Blueberry;
            });
        }

        [Fact]
        public void ChangingWithIceCreamPropertyShouldInvokePropertyChangedForWithIceCream()
        {
            var cobbler = new Cobbler();
            Assert.PropertyChanged(cobbler, "WithIceCream", () =>
            {
                cobbler.WithIceCream = false;
            });
        }

        [Fact]
        public void ChangingWithIceCreamPropertyShouldInvokePropertyChangedForPrice()
        {
            var cobbler = new Cobbler();
            Assert.PropertyChanged(cobbler, "Price", () =>
            {
                cobbler.WithIceCream = false;
            });
        }

        [Fact]
        public void ChangingWithIceCreamPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var cobbler = new Cobbler();
            Assert.PropertyChanged(cobbler, "SpecialInstructions", () =>
            {
                cobbler.WithIceCream = false;
            });
        }
    }
}
