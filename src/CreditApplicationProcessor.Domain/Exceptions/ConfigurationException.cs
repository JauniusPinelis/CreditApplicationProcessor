using System;

namespace CreditApplicationProcessor.Domain.Exceptions
{
    public class ConfigurationException : Exception
    {
        public ConfigurationException(string message)
        : base(message)
        {
        }
    }
}
