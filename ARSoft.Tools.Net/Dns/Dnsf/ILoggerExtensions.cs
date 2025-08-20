using Microsoft.Extensions.Logging;
using System.Net;

namespace ARSoft.Tools.Net.Dns.Dnsf;

internal static partial class ILoggerExtensions
{
    [LoggerMessage(EventId = -1, Level = LogLevel.Debug, Message = "[{ClientId}] Disposing Client.")]
    public static partial void LogDnsClientDisposed(this ILogger logger, string clientId);

    [LoggerMessage(EventId = 0, Level = LogLevel.Debug, Message = "[{ClientId}] Initialized DNS Client with Timeout {QueryTimeoutInSeconds} and Servers {Servers}. Transports are {TransportNames}.")]
    public static partial void LogDnsClientInitialized(this ILogger logger, string clientId, IEnumerable<IPAddress> servers, int queryTimeoutInSeconds, IEnumerable<string> transportNames);

    [LoggerMessage(EventId = 1, Level = LogLevel.Warning, Message = "[{ClientId}:{TransactionId}] Request is missing a Transaction ID. Will assign randomly generated value {TransactionId}.")]
    public static partial void LogRequestTransactionIdMissing(this ILogger logger, string clientId, ushort transactionId);

    [LoggerMessage(EventId = 2, Level = LogLevel.Trace, Message = "[{ClientId}:{TransactionId}] Request 0x20 Validation Enabled = {Is0x20ValidationEnabled}.")]
    public static partial void LogRequest0x20ValidationStatus(this ILogger logger, string clientId, ushort transactionId, bool is0x20ValidationEnabled);

    [LoggerMessage(EventId = 3, Level = LogLevel.Trace, Message = "[{ClientId}:{TransactionId}] Request Secret Key Transaction Authentcation Enabled = {SecretKeyTransactionAuthenticationEnabled}.")]
    public static partial void LogRequestSecretKeyTransactionAuthenticationStatus(this ILogger logger, string clientId, ushort transactionId, bool secretKeyTransactionAuthenticationEnabled);

    [LoggerMessage(EventId = 4, Level = LogLevel.Warning, Message = "[{ClientId}:{TransactionId}] Response Validation Successful: {ResponseValidationSuccessful}.")]
    public static partial void LogResponseMessageValidationResult(this ILogger logger, string clientId, ushort transactionId, bool responseValidationSuccessful);

    [LoggerMessage(EventId = 5, Level = LogLevel.Error, Message = "[{ClientId}:{TransactionId}] Request Attempt failed due to an unknown error.")]
    public static partial void LogRequestFailedConnectionException(this ILogger logger, Exception ex, string clientId, ushort transactionId);

    [LoggerMessage(EventId = 6, Level = LogLevel.Error, Message = "[{ClientId}:{TransactionId}] Request Attempt failed due to a missing or invalid response.")]
    public static partial void LogRequestFailedResponseMissingOrInvalid(this ILogger logger, string clientId, ushort transactionId);

    [LoggerMessage(EventId = 7, Level = LogLevel.Debug, Message = "[{ClientId}:{TransactionId}] Request Attempt {RequestAttempt} to {DestinationAddress} using Pooled Transport {TransportName}.")]
    public static partial void LogConnectionAttemptWithPooledConnection(this ILogger logger, string clientId, ushort transactionId, int requestAttempt, IPAddress destinationAddress, string transportName);

    [LoggerMessage(EventId = 8, Level = LogLevel.Debug, Message = "[{ClientId}:{TransactionId}] Request Attempt {RequestAttempt} to {DestinationAddress} using Reliable Transport {TransportName}.")]
    public static partial void LogConnectionAttemptWithReliableConnection(this ILogger logger, string clientId, ushort transactionId, int requestAttempt, IPAddress destinationAddress, string transportName);

    [LoggerMessage(EventId = 9, Level = LogLevel.Warning, Message = "[{ClientId}:{TransactionId}] Request Attempt failed due to a missing connection.")]
    public static partial void LogRequestFailedMissingConnection(this ILogger logger, string clientId, ushort transactionId);

    [LoggerMessage(EventId = 10, Level = LogLevel.Warning, Message = "[{ClientId}:{TransactionId}] Request Attempt failed due to a bad result code: {ResultCode}.")]
    public static partial void LogRequestFailedBadReturnCode(this ILogger logger, string clientId, ushort transactionId, ushort resultCode);

    [LoggerMessage(EventId = 11, Level = LogLevel.Trace, Message = "[{ClientId}:{TransactionId}] Successfully received response.")]
    public static partial void LogResponseSuccessful(this ILogger logger, string clientId, ushort transactionId);

    [LoggerMessage(EventId = 12, Level = LogLevel.Trace, Message = "[{ClientId}:{TransactionId}] Request reattempt over reliable transport {TransportName}.")]
    public static partial void LogRequestReattemptWithReliableTransportRequested(this ILogger logger, string clientId, ushort transactionId, string transportName);

    [LoggerMessage(EventId = 13, Level = LogLevel.Error, Message = "[{ClientId}:{TransactionId}] Request Attempt failed due to no reliable transports available.")]
    public static partial void LogRequestFailedReattemptOverReliableTransportNotAvailable(this ILogger logger, string clientId, ushort transactionId);

    [LoggerMessage(EventId = 14, Level = LogLevel.Error, Message = "[{ClientId}:{TransactionId}] Request Attempt failed due to reliable transport connection not available.")]
    public static partial void LogRequestFailedReattemptOverReliableTransportConnectionNotAvailable(this ILogger logger, string clientId, ushort transactionId);

    [LoggerMessage(EventId = 15, Level = LogLevel.Error, Message = "[{ClientId}:{TransactionId}] Request Attempt failed due to reliable transport response missing or invalid.")]
    public static partial void LogRequestFailedReattemptOverReliableTransportResponseMissingOrInvalid(this ILogger logger, string clientId, ushort transactionId);

    [LoggerMessage(EventId = 16, Level = LogLevel.Trace, Message = "[{ClientId}:{TransactionId}] Successfully received response from reliable transport.")]
    public static partial void LogResponseSuccessfulOverReliableTransport(this ILogger logger, string clientId, ushort transactionId);

    [LoggerMessage(EventId = 17, Level = LogLevel.Error, Message = "[{ClientId}:{TransactionId}] Sending request over connection {ConnectionName} failed.")]
    public static partial void LogConnectionRequestSendingFailed(this ILogger logger, string clientId, ushort transactionId, string connectionName);

    [LoggerMessage(EventId = 18, Level = LogLevel.Error, Message = "[{ClientId}:{TransactionId}] Receiving response over connection {ConnectionName} failed.")]
    public static partial void LogConnectionResponseReceivingFailed(this ILogger logger, string clientId, ushort transactionId, string connectionName);

    [LoggerMessage(EventId = 19, Level = LogLevel.Trace, Message = "[{ClientId}:{TransactionId}] Received response that requires further messages.")]
    public static partial void LogConnectionResponseIndicatesFurtherMessages(this ILogger logger, string clientId, ushort transactionId);

    [LoggerMessage(EventId = 20, Level = LogLevel.Error, Message = "[{ClientId}:{TransactionId}] Unable to receive subsequent response after previous response.")]
    public static partial void LogConnectionSubsequentResponseMissing(this ILogger logger, string clientId, ushort transactionId);

    [LoggerMessage(EventId = 21, Level = LogLevel.Error, Message = "[{ClientId}:{TransactionId}] Unable to receive subsequent response due to server failure.")]
    public static partial void LogConnectionSubsequentResponseIndicatesServerFailure(this ILogger logger, string clientId, ushort transactionId);
}
