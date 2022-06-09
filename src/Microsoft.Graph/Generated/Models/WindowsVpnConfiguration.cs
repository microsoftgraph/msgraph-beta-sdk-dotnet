using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class WindowsVpnConfiguration : DeviceConfiguration, IParsable {
        /// <summary>Connection name displayed to the user.</summary>
        public string ConnectionName {
            get { return BackingStore?.Get<string>(nameof(ConnectionName)); }
            set { BackingStore?.Set(nameof(ConnectionName), value); }
        }
        /// <summary>Custom XML commands that configures the VPN connection. (UTF8 encoded byte array)</summary>
        public byte[] CustomXml {
            get { return BackingStore?.Get<byte[]>(nameof(CustomXml)); }
            set { BackingStore?.Set(nameof(CustomXml), value); }
        }
        /// <summary>List of VPN Servers on the network. Make sure end users can access these network locations. This collection can contain a maximum of 500 elements.</summary>
        public List<VpnServer> Servers {
            get { return BackingStore?.Get<List<VpnServer>>(nameof(Servers)); }
            set { BackingStore?.Set(nameof(Servers), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new WindowsVpnConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WindowsVpnConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"connectionName", n => { ConnectionName = n.GetStringValue(); } },
                {"customXml", n => { CustomXml = n.GetByteArrayValue(); } },
                {"servers", n => { Servers = n.GetCollectionOfObjectValues<VpnServer>(VpnServer.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("connectionName", ConnectionName);
            writer.WriteByteArrayValue("customXml", CustomXml);
            writer.WriteCollectionOfObjectValues<VpnServer>("servers", Servers);
        }
    }
}
