namespace CustomConfigurationSection.Configuration
{
    interface ISettings
    {
        int Size { get; set; }

        bool Active { get; }

        string GetPath();
    }
}
