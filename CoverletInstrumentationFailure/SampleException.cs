using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;

namespace CoverletInstrumentationFailure
{
    public class SampleException : ExceptionFilterAttribute
    {
        private readonly ILogger<SampleException> _logger;
        private readonly LogLevel _logLevel;

        public SampleException(ILoggerFactory loggerFactory, LogLevel logLevel)
        {
            _logger = loggerFactory.CreateLogger<SampleException>();
            _logLevel = logLevel;
        }
    }
}