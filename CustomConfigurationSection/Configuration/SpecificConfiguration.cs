using System.Configuration;

namespace CustomConfigurationSection.Configuration
{
    class SpecificConfiguration : ConfigurationSection, ISettings
    {
        private const string Size = "size";
        private const string Active = "active";
        private const string Path = "path";

        protected override ConfigurationPropertyCollection Properties
        {
            get
            {
                var active = new ConfigurationProperty(Active, typeof(bool), true);
                var size = new ConfigurationProperty(Size, typeof(int), 0, ConfigurationPropertyOptions.IsRequired);
                var path = new ConfigurationProperty(Path, typeof(PathElement), null, ConfigurationPropertyOptions.IsRequired);
                
                return new ConfigurationPropertyCollection { active, size, path };
            }
        }

        public static ISettings GetSettings(string sectionName)
        {
            return (SpecificConfiguration)ConfigurationManager.GetSection(sectionName);
        }

        #region ISettings

        bool ISettings.Active { get { return (bool)this[Active]; } }

        int ISettings.Size
        {
            get
            {
                return (int)this[Size];
            }
            set
            {
                this[Size] = value;
            }
        }

        string ISettings.GetPath()
        {
            var pathElement = (PathElement)this[Path];
            return pathElement.Path;
        }

        #endregion
    }
}
