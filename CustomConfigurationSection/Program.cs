using CustomConfigurationSection.Configuration;
using System;
using System.Configuration;

namespace CustomConfigurationSection
{
    class Program
    {
        static void Main(string[] args)
        {
            // fetch a app setting configuration value
            var regularConfigValue = ConfigurationManager.AppSettings["NormalConfig"];
            Console.WriteLine($"Fetch an app setting config value: {regularConfigValue}");

            var settings = SpecificConfiguration.GetSettings("mySettings");

            Console.WriteLine("Display custom settings:");
            var areActive = settings.Active ? "are" : "aren't";
            Console.WriteLine($"  > The settings {areActive} active");
            Console.WriteLine($"  > Size : {settings.Size}");
            Console.WriteLine($"  > Path : {settings.GetPath()}");

            Console.Read();
        }
    }
}
