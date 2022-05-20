using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class CallRoute : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The final property</summary>
        public IdentitySet Final {
            get { return BackingStore?.Get<IdentitySet>(nameof(Final)); }
            set { BackingStore?.Set(nameof(Final), value); }
        }
        /// <summary>The original property</summary>
        public IdentitySet Original {
            get { return BackingStore?.Get<IdentitySet>(nameof(Original)); }
            set { BackingStore?.Set(nameof(Original), value); }
        }
        /// <summary>Possible values are: forwarded, lookup, selfFork.</summary>
        public Microsoft.Graph.Beta.Models.RoutingType? RoutingType {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.RoutingType?>(nameof(RoutingType)); }
            set { BackingStore?.Set(nameof(RoutingType), value); }
        }
        /// <summary>
        /// Instantiates a new callRoute and sets the default values.
        /// </summary>
        public CallRoute() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static CallRoute CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CallRoute();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"final", n => { Final = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"original", n => { Original = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"routingType", n => { RoutingType = n.GetEnumValue<RoutingType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<IdentitySet>("final", Final);
            writer.WriteObjectValue<IdentitySet>("original", Original);
            writer.WriteEnumValue<RoutingType>("routingType", RoutingType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
