using System;

public class TemperatureSensor
{
    private double _temperature;

    // Подія
    public event Action<double> TemperatureChanged;

    public void SetTemperature(double temperature)
    {
        _temperature = temperature;
        OnTemperatureChanged(_temperature);
    }

    protected virtual void OnTemperatureChanged(double temperature)
    {
        TemperatureChanged?.Invoke(temperature);
    }
}