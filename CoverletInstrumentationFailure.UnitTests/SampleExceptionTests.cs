using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;

namespace CoverletInstrumentationFailure.UnitTests
{
    [TestClass]
    public class SampleExceptionTests
    {
        [TestMethod]
        public void SampleTest()
        {
            var factory = new NullLoggerFactory();

            var exception = new SampleException(factory, LogLevel.Error);
        }
    }
}