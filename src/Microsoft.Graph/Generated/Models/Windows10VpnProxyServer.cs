using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class Windows10VpnProxyServer : VpnProxyServer, IParsable {
        /// <summary>Bypass proxy server for local address.</summary>
        public bool? BypassProxyServerForLocalAddress {
            get { return BackingStore?.Get<bool?>(nameof(BypassProxyServerForLocalAddress)); }
            set { BackingStore?.Set(nameof(BypassProxyServerForLocalAddress), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Windows10VpnProxyServer CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Windows10VpnProxyServer();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
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
            writer.WriteBoolValue("bypassProxyServerForLocalAddress", BypassProxyServerForLocalAddress);
        }
    }
}
