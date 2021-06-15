using System;
using System.Collections.Generic;
using System.Text;

namespace TempratureConverter.BL
{
    public class TempratureService : ITempratureService
    {
        public Temprature GetTempratureByCelsius(int celsius)
        {
            Temprature temprature = new Temprature();
            temprature.Celsius = celsius;
            return temprature;
        }

        public Temprature GetTempratureByFahrenheit(int fahrenheit)
        {
            Temprature temprature = new Temprature();
            temprature.Fahrenheit = fahrenheit;
            return temprature;
        }

        public Temprature GetTempratureByKelvin(double kelvin)
        {
            Temprature temprature = new Temprature();
            temprature.Kelvin = kelvin;
            return temprature;
        }
    }
}
