namespace ARSoft.Tools.Net.Dns;

public static class DnsfDnsMessageBaseExtensions
{
    public static int Encode(this DnsMessageBase message, bool includeLengthPrefix, out byte[] messageData)
        => message.Encode(includeLengthPrefix, out messageData);
}
