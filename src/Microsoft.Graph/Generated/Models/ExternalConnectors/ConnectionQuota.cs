using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.ExternalConnectors {
    /// <summary>Provides operations to manage the collection of externalConnection entities.</summary>
    public class ConnectionQuota : Entity, IParsable {
        /// <summary>Returns the minimum number in a range that contains the following data: items remaining in the connection and remaining items at tenant-level. The following equation represents the formula used to calculate the minimum number: min(max capacity in the connection – number of items in the connection, tenant quota – number of items indexed in all connections). If the connection is nonmonetized (preview connector or preview content experience), then it returns the number of remaining items in the connection.</summary>
        public long? ItemsRemaining {
            get { return BackingStore?.Get<long?>(nameof(ItemsRemaining)); }
            set { BackingStore?.Set(nameof(ItemsRemaining), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ConnectionQuota CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ConnectionQuota();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"itemsRemaining", n => { ItemsRemaining = n.GetLongValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteLongValue("itemsRemaining", ItemsRemaining);
        }
    }
}
