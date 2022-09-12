using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class AndroidDeviceOwnerGlobalProxyDirect : AndroidDeviceOwnerGlobalProxy, IParsable {
        /// <summary>The excluded hosts</summary>
        public List<string> ExcludedHosts {
            get { return BackingStore?.Get<List<string>>("excludedHosts"); }
            set { BackingStore?.Set("excludedHosts", value); }
        }
        /// <summary>The host name</summary>
        public string Host {
            get { return BackingStore?.Get<string>("host"); }
            set { BackingStore?.Set("host", value); }
        }
        /// <summary>The port</summary>
        public int? Port {
            get { return BackingStore?.Get<int?>("port"); }
            set { BackingStore?.Set("port", value); }
        }
        /// <summary>
        /// Instantiates a new AndroidDeviceOwnerGlobalProxyDirect and sets the default values.
        /// </summary>
        public AndroidDeviceOwnerGlobalProxyDirect() : base() {
            OdataType = "#microsoft.graph.androidDeviceOwnerGlobalProxyDirect";
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
                {"excludedHosts", n => { ExcludedHosts = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
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
