using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class Windows81VpnProxyServer : VpnProxyServer, IParsable {
        /// <summary>Automatically detect proxy settings.</summary>
        public bool? AutomaticallyDetectProxySettings {
            get { return BackingStore?.Get<bool?>("automaticallyDetectProxySettings"); }
            set { BackingStore?.Set("automaticallyDetectProxySettings", value); }
        }
        /// <summary>Bypass proxy server for local address.</summary>
        public bool? BypassProxyServerForLocalAddress {
            get { return BackingStore?.Get<bool?>("bypassProxyServerForLocalAddress"); }
            set { BackingStore?.Set("bypassProxyServerForLocalAddress", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Windows81VpnProxyServer CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Windows81VpnProxyServer();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"automaticallyDetectProxySettings", n => { AutomaticallyDetectProxySettings = n.GetBoolValue(); } },
                {"bypassProxyServerForLocalAddress", n => { BypassProxyServerForLocalAddress = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("automaticallyDetectProxySettings", AutomaticallyDetectProxySettings);
            writer.WriteBoolValue("bypassProxyServerForLocalAddress", BypassProxyServerForLocalAddress);
        }
    }
}
