using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of administrativeUnit entities.</summary>
    public class UsageRight : Entity, IParsable {
        /// <summary>Product id corresponding to the usage right.</summary>
        public string CatalogId {
            get { return BackingStore?.Get<string>(nameof(CatalogId)); }
            set { BackingStore?.Set(nameof(CatalogId), value); }
        }
        /// <summary>Identifier of the service corresponding to the usage right.</summary>
        public string ServiceIdentifier {
            get { return BackingStore?.Get<string>(nameof(ServiceIdentifier)); }
            set { BackingStore?.Set(nameof(ServiceIdentifier), value); }
        }
        /// <summary>The state of the usage right. Possible values are: active, inactive, warning, suspended.</summary>
        public UsageRightState? State {
            get { return BackingStore?.Get<UsageRightState?>(nameof(State)); }
            set { BackingStore?.Set(nameof(State), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new UsageRight CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UsageRight();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"catalogId", n => { CatalogId = n.GetStringValue(); } },
                {"serviceIdentifier", n => { ServiceIdentifier = n.GetStringValue(); } },
                {"state", n => { State = n.GetEnumValue<UsageRightState>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("catalogId", CatalogId);
            writer.WriteStringValue("serviceIdentifier", ServiceIdentifier);
            writer.WriteEnumValue<UsageRightState>("state", State);
        }
    }
}
