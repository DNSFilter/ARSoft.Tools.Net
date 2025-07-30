namespace ARSoft.Tools.Net.Dns;

public static class DnsfDnsMessageBaseExtensions
{
    public static ArraySegment<byte> Encode(this DnsMessageBase message, bool includeLengthPrefix)
        => message.Encode().ToArraySegment(includeLengthPrefix);
}
