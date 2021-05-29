using System.Collections.Generic;

namespace WireguardConfigurator.Domain.Data
{
    public class WireguardConfig
    {
        public WireguardInterface Interface { get; set; }
        public List<WireguardPeer> Peers { get; set; }
    }
}