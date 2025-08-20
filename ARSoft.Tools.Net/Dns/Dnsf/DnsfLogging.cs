using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;

namespace ARSoft.Tools.Net.Dns.Dnsf;

/// <summary>
/// Allows logging within the library.
/// </summary>
public static class DnsfLogging
{
    /// <summary>
    /// Contains the logger factory in use by the library, since ARSoft does not support logging or DI.
    /// </summary>
    public static ILoggerFactory LoggerFactory { get; set; } = NullLoggerFactory.Instance;
}
