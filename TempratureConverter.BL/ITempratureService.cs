using System;
using System.Collections.Generic;
using System.Text;

namespace TempratureConverter.BL
{
    public interface ITempratureService
    {
        Temprature GetTempratureByCelsius(int celsius);
        Temprature GetTempratureByKelvin(double kelvin);
        Temprature GetTempratureByFahrenheit(int fahrenheit);
    }
}
