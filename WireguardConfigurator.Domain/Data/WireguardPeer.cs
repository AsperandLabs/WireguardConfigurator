using System.Net;

namespace WireguardConfigurator.Domain.Data
{
    public class WireguardPeer
    {
        public string PublicKey { get; set; }
        public IPAddress AllowedIPs { get; set; }
    }
}