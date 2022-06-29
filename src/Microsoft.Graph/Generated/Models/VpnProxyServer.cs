using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>VPN Proxy Server.</summary>
    public class VpnProxyServer : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Address.</summary>
        public string Address {
            get { return BackingStore?.Get<string>(nameof(Address)); }
            set { BackingStore?.Set(nameof(Address), value); }
        }
        /// <summary>Proxy&apos;s automatic configuration script url.</summary>
        public string AutomaticConfigurationScriptUrl {
            get { return BackingStore?.Get<string>(nameof(AutomaticConfigurationScriptUrl)); }
            set { BackingStore?.Set(nameof(AutomaticConfigurationScriptUrl), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Port. Valid values 0 to 65535</summary>
        public int? Port {
            get { return BackingStore?.Get<int?>(nameof(Port)); }
            set { BackingStore?.Set(nameof(Port), value); }
        }
        /// <summary>
        /// Instantiates a new vpnProxyServer and sets the default values.
        /// </summary>
        public VpnProxyServer() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static VpnProxyServer CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValueNode = parseNode.GetChildNode("@odata.type");
            var mappingValue = mappingValueNode?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.windows10VpnProxyServer" => new Windows10VpnProxyServer(),
                "#microsoft.graph.windows81VpnProxyServer" => new Windows81VpnProxyServer(),
                _ => new VpnProxyServer(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"address", n => { Address = n.GetStringValue(); } },
                {"automaticConfigurationScriptUrl", n => { AutomaticConfigurationScriptUrl = n.GetStringValue(); } },
                {"port", n => { Port = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("address", Address);
            writer.WriteStringValue("automaticConfigurationScriptUrl", AutomaticConfigurationScriptUrl);
            writer.WriteIntValue("port", Port);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
