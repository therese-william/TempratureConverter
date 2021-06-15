using NUnit.Framework;
using TempratureConverter.BL;

namespace TempratureConverter.Tests
{
    public class BLUnitTests
    {
        ITempratureService tempratureService;

        [SetUp]
        public void Setup()
        {
            tempratureService = new TempratureService();
        }

        [Test]
        public void TestGetTempByCelsius()
        {
            var temprature = tempratureService.GetTempratureByCelsius(100);
            Assert.AreEqual(temprature.Fahrenheit, 212);
            Assert.AreEqual(temprature.Kelvin, 373.15);
        }

        [Test]
        public void TestGetTempByFahrenheit()
        {
            var temprature = tempratureService.GetTempratureByFahrenheit(212);
            Assert.AreEqual(temprature.Celsius, 100);
            Assert.AreEqual(temprature.Kelvin, 373.15);
        }

        [Test]
        public void TestGetTempByKelvin()
        {
            var temprature = tempratureService.GetTempratureByKelvin(373.15);
            Assert.AreEqual(temprature.Celsius, 100);
            Assert.AreEqual(temprature.Fahrenheit, 212);
        }
    }
}
