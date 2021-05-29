using System.Net;

namespace WireguardConfigurator.Domain.Data
{
    public class WireguardInterface
    {
        public string PrivateKey { get; set; }
        public IPAddress Address { get; set; }
        public int ListenPort { get; set; }
    }
}