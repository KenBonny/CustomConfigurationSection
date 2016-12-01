using System.Configuration;

namespace CustomConfigurationSection.Configuration
{
    class PathElement : ConfigurationElement
    {
        private const string LocalPath = "localPath";

        [ConfigurationProperty(LocalPath, IsRequired = true, DefaultValue = "No path found")]
        public string Path {
            get
            {
                return (string)this[LocalPath];
            }
        }
    }
}
