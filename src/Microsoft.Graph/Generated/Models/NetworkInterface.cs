using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class NetworkInterface : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Description of the NIC (e.g. Ethernet adapter, Wireless LAN adapter Local Area Connection &lt;#&gt;, etc.).</summary>
        public string Description {
            get { return BackingStore?.Get<string>(nameof(Description)); }
            set { BackingStore?.Set(nameof(Description), value); }
        }
        /// <summary>Last IPv4 address associated with this NIC.</summary>
        public string IpV4Address {
            get { return BackingStore?.Get<string>(nameof(IpV4Address)); }
            set { BackingStore?.Set(nameof(IpV4Address), value); }
        }
        /// <summary>Last Public (aka global) IPv6 address associated with this NIC.</summary>
        public string IpV6Address {
            get { return BackingStore?.Get<string>(nameof(IpV6Address)); }
            set { BackingStore?.Set(nameof(IpV6Address), value); }
        }
        /// <summary>Last local (link-local or site-local) IPv6 address associated with this NIC.</summary>
        public string LocalIpV6Address {
            get { return BackingStore?.Get<string>(nameof(LocalIpV6Address)); }
            set { BackingStore?.Set(nameof(LocalIpV6Address), value); }
        }
        /// <summary>MAC address of the NIC on this host.</summary>
        public string MacAddress {
            get { return BackingStore?.Get<string>(nameof(MacAddress)); }
            set { BackingStore?.Set(nameof(MacAddress), value); }
        }
        /// <summary>
        /// Instantiates a new networkInterface and sets the default values.
        /// </summary>
        public NetworkInterface() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static NetworkInterface CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new NetworkInterface();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"description", n => { Description = n.GetStringValue(); } },
                {"ipV4Address", n => { IpV4Address = n.GetStringValue(); } },
                {"ipV6Address", n => { IpV6Address = n.GetStringValue(); } },
                {"localIpV6Address", n => { LocalIpV6Address = n.GetStringValue(); } },
                {"macAddress", n => { MacAddress = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("ipV4Address", IpV4Address);
            writer.WriteStringValue("ipV6Address", IpV6Address);
            writer.WriteStringValue("localIpV6Address", LocalIpV6Address);
            writer.WriteStringValue("macAddress", MacAddress);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
