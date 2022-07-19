using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class AndroidDeviceOwnerGlobalProxyAutoConfig : AndroidDeviceOwnerGlobalProxy, IParsable {
        /// <summary>The proxy auto-config URL</summary>
        public string ProxyAutoConfigURL {
            get { return BackingStore?.Get<string>("proxyAutoConfigURL"); }
            set { BackingStore?.Set("proxyAutoConfigURL", value); }
        }
        /// <summary>
        /// Instantiates a new AndroidDeviceOwnerGlobalProxyAutoConfig and sets the default values.
        /// </summary>
        public AndroidDeviceOwnerGlobalProxyAutoConfig() : base() {
            OdataType = "#microsoft.graph.androidDeviceOwnerGlobalProxyAutoConfig";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new AndroidDeviceOwnerGlobalProxyAutoConfig CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AndroidDeviceOwnerGlobalProxyAutoConfig();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"proxyAutoConfigURL", n => { ProxyAutoConfigURL = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("proxyAutoConfigURL", ProxyAutoConfigURL);
        }
    }
}
