using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class AndroidDeviceOwnerGlobalProxyDirect : AndroidDeviceOwnerGlobalProxy, IParsable {
        /// <summary>The excluded hosts</summary>
        public List<string> ExcludedHosts {
            get { return BackingStore?.Get<List<string>>(nameof(ExcludedHosts)); }
            set { BackingStore?.Set(nameof(ExcludedHosts), value); }
        }
        /// <summary>The host name</summary>
        public string Host {
            get { return BackingStore?.Get<string>(nameof(Host)); }
            set { BackingStore?.Set(nameof(Host), value); }
        }
        /// <summary>The port</summary>
        public int? Port {
            get { return BackingStore?.Get<int?>(nameof(Port)); }
            set { BackingStore?.Set(nameof(Port), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new AndroidDeviceOwnerGlobalProxyDirect CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AndroidDeviceOwnerGlobalProxyDirect();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"excludedHosts", n => { ExcludedHosts = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"host", n => { Host = n.GetStringValue(); } },
                {"port", n => { Port = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfPrimitiveValues<string>("excludedHosts", ExcludedHosts);
            writer.WriteStringValue("host", Host);
            writer.WriteIntValue("port", Port);
        }
    }
}
