using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of accessReview entities.</summary>
    public class OfficeGraphInsights : Entity, IParsable {
        /// <summary>Access this property from the derived type itemInsights.</summary>
        public List<SharedInsight> Shared {
            get { return BackingStore?.Get<List<SharedInsight>>(nameof(Shared)); }
            set { BackingStore?.Set(nameof(Shared), value); }
        }
        /// <summary>Access this property from the derived type itemInsights.</summary>
        public List<Microsoft.Graph.Beta.Models.Trending> Trending {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.Trending>>(nameof(Trending)); }
            set { BackingStore?.Set(nameof(Trending), value); }
        }
        /// <summary>Access this property from the derived type itemInsights.</summary>
        public List<UsedInsight> Used {
            get { return BackingStore?.Get<List<UsedInsight>>(nameof(Used)); }
            set { BackingStore?.Set(nameof(Used), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new OfficeGraphInsights CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValueNode = parseNode.GetChildNode("@odata.type");
            var mappingValue = mappingValueNode?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.itemInsights" => new ItemInsights(),
                _ => new OfficeGraphInsights(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"shared", n => { Shared = n.GetCollectionOfObjectValues<SharedInsight>(SharedInsight.CreateFromDiscriminatorValue).ToList(); } },
                {"trending", n => { Trending = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Trending>(Microsoft.Graph.Beta.Models.Trending.CreateFromDiscriminatorValue).ToList(); } },
                {"used", n => { Used = n.GetCollectionOfObjectValues<UsedInsight>(UsedInsight.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<SharedInsight>("shared", Shared);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Trending>("trending", Trending);
            writer.WriteCollectionOfObjectValues<UsedInsight>("used", Used);
        }
    }
}
