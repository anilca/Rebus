using Rebus.Logging;

namespace Rebus.Configuration
{
    /// <summary>
    /// Configurer that allows for logging to be configured
    /// </summary>
    public class LoggingConfigurer : BaseConfigurer
    {
        /// <summary>
        /// Constructs the configurer with the specified <see cref="ConfigurationBackbone"/>
        /// </summary>
        public LoggingConfigurer(ConfigurationBackbone backbone)
            : base(backbone)
        {
        }

        /// <summary>
        /// Passes the specified <see cref="IRebusLoggerFactory"/> to the backbone
        /// </summary>
        public void Use(IRebusLoggerFactory loggerFactory)
        {
            Backbone.LoggerFactory = loggerFactory;
        }
    }
}