using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class TeamworkNetworkConfiguration : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The default gateway is the path used to pass information when the destination is unknown to the device.</summary>
        public string DefaultGateway { get; set; }
        /// <summary>The network domain of the device, for example, contoso.com.</summary>
        public string DomainName { get; set; }
        /// <summary>The device name on a network.</summary>
        public string HostName { get; set; }
        /// <summary>The IP address is a numerical label that uniquely identifies every device connected to the internet.</summary>
        public string IpAddress { get; set; }
        /// <summary>True if DHCP is enabled.</summary>
        public bool? IsDhcpEnabled { get; set; }
        /// <summary>True if the PC port is enabled.</summary>
        public bool? IsPCPortEnabled { get; set; }
        /// <summary>A primary DNS is the first point of contact for a device that translates the hostname into an IP address.</summary>
        public string PrimaryDns { get; set; }
        /// <summary>A secondary DNS is used when the primary DNS is not available.</summary>
        public string SecondaryDns { get; set; }
        /// <summary>A subnet mask is a number that distinguishes the network address and the host address within an IP address.</summary>
        public string SubnetMask { get; set; }
        /// <summary>
        /// Instantiates a new teamworkNetworkConfiguration and sets the default values.
        /// </summary>
        public TeamworkNetworkConfiguration() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static TeamworkNetworkConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TeamworkNetworkConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"defaultGateway", (o,n) => { (o as TeamworkNetworkConfiguration).DefaultGateway = n.GetStringValue(); } },
                {"domainName", (o,n) => { (o as TeamworkNetworkConfiguration).DomainName = n.GetStringValue(); } },
                {"hostName", (o,n) => { (o as TeamworkNetworkConfiguration).HostName = n.GetStringValue(); } },
                {"ipAddress", (o,n) => { (o as TeamworkNetworkConfiguration).IpAddress = n.GetStringValue(); } },
                {"isDhcpEnabled", (o,n) => { (o as TeamworkNetworkConfiguration).IsDhcpEnabled = n.GetBoolValue(); } },
                {"isPCPortEnabled", (o,n) => { (o as TeamworkNetworkConfiguration).IsPCPortEnabled = n.GetBoolValue(); } },
                {"primaryDns", (o,n) => { (o as TeamworkNetworkConfiguration).PrimaryDns = n.GetStringValue(); } },
                {"secondaryDns", (o,n) => { (o as TeamworkNetworkConfiguration).SecondaryDns = n.GetStringValue(); } },
                {"subnetMask", (o,n) => { (o as TeamworkNetworkConfiguration).SubnetMask = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("defaultGateway", DefaultGateway);
            writer.WriteStringValue("domainName", DomainName);
            writer.WriteStringValue("hostName", HostName);
            writer.WriteStringValue("ipAddress", IpAddress);
            writer.WriteBoolValue("isDhcpEnabled", IsDhcpEnabled);
            writer.WriteBoolValue("isPCPortEnabled", IsPCPortEnabled);
            writer.WriteStringValue("primaryDns", PrimaryDns);
            writer.WriteStringValue("secondaryDns", SecondaryDns);
            writer.WriteStringValue("subnetMask", SubnetMask);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
