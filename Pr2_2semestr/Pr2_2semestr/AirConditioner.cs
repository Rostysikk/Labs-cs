using System;

public class AirConditioner
{
    public void Subscribe(TemperatureSensor sensor)
    {
        sensor.TemperatureChanged += ReactToTemperature;
    }

    private void ReactToTemperature(double temperature)
    {
        if (temperature < 17)
            Console.WriteLine("AirConditioner: HEATING is on");
        else if (temperature <= 25)
            Console.WriteLine("AirConditioner: Air conditioning OFF");
        else
            Console.WriteLine("AirConditioner: COOLING is on");
    }
}