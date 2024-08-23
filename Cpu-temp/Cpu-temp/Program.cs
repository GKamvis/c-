using System;
using OpenHardwareMonitor.Hardware;

public class Program
{
    public static void Main()
    {
        Computer computer = new Computer() { CPUEnabled = true };

        foreach (var hardwareItem in computer.Hardware)
        {
            if (hardwareItem.HardwareType == HardwareType.CPU)
            {
                hardwareItem.Update();
                foreach (var sensor in hardwareItem.Sensors)
                {
                    if (sensor.SensorType == SensorType.Temperature)
                    {
                        Console.WriteLine($"CPU Temperaturu: {sensor.Value} °C");
                    }
                }
            }
        }
    }
}
