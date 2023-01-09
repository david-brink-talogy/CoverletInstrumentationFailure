using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace CoverletInstrumentationFailure
{
    public class SampleExceptionFactory : Attribute, IFilterFactory
    {
        private readonly LogLevel _logLevel;

        public SampleExceptionFactory(LogLevel logLevel = LogLevel.Error)
        {
            _logLevel = logLevel;
        }

        public bool IsReusable => true;

        public IFilterMetadata CreateInstance(IServiceProvider serviceProvider)
        {
            var factory = serviceProvider.GetRequiredService<ILoggerFactory>();

            return new SampleException(factory, _logLevel);
        }
    }
}
