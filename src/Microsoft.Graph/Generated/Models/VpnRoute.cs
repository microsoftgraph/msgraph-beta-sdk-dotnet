using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>VPN Route definition.</summary>
    public class VpnRoute : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Destination prefix (IPv4/v6 address).</summary>
        public string DestinationPrefix {
            get { return BackingStore?.Get<string>("destinationPrefix"); }
            set { BackingStore?.Set("destinationPrefix", value); }
        }
        /// <summary>Prefix size. (1-32). Valid values 1 to 32</summary>
        public int? PrefixSize {
            get { return BackingStore?.Get<int?>("prefixSize"); }
            set { BackingStore?.Set("prefixSize", value); }
        }
        /// <summary>
        /// Instantiates a new vpnRoute and sets the default values.
        /// </summary>
        public VpnRoute() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static VpnRoute CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new VpnRoute();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"destinationPrefix", n => { DestinationPrefix = n.GetStringValue(); } },
                {"prefixSize", n => { PrefixSize = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("destinationPrefix", DestinationPrefix);
            writer.WriteIntValue("prefixSize", PrefixSize);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
