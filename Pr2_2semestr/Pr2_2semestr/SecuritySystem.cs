using System;

public class SecuritySystem
{
    public void Subscribe(TemperatureSensor sensor)
    {
        sensor.TemperatureChanged += CheckTemperature;
    }

    private void CheckTemperature(double temperature)
    {
        if (temperature > 40)
            Console.WriteLine("SecuritySystem: System overheating!");
        else if (temperature < 5)
            Console.WriteLine("SecuritySystem: Risk of systems freezing!");
    }
}