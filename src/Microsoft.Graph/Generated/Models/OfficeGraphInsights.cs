using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class OfficeGraphInsights : Entity, IParsable {
        /// <summary>Access this property from the derived type itemInsights.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<SharedInsight>? Shared {
            get { return BackingStore?.Get<List<SharedInsight>?>("shared"); }
            set { BackingStore?.Set("shared", value); }
        }
#nullable restore
#else
        public List<SharedInsight> Shared {
            get { return BackingStore?.Get<List<SharedInsight>>("shared"); }
            set { BackingStore?.Set("shared", value); }
        }
#endif
        /// <summary>Access this property from the derived type itemInsights.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.Trending>? Trending {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.Trending>?>("trending"); }
            set { BackingStore?.Set("trending", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.Trending> Trending {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.Trending>>("trending"); }
            set { BackingStore?.Set("trending", value); }
        }
#endif
        /// <summary>Access this property from the derived type itemInsights.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<UsedInsight>? Used {
            get { return BackingStore?.Get<List<UsedInsight>?>("used"); }
            set { BackingStore?.Set("used", value); }
        }
#nullable restore
#else
        public List<UsedInsight> Used {
            get { return BackingStore?.Get<List<UsedInsight>>("used"); }
            set { BackingStore?.Set("used", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new OfficeGraphInsights CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
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
                {"shared", n => { Shared = n.GetCollectionOfObjectValues<SharedInsight>(SharedInsight.CreateFromDiscriminatorValue)?.ToList(); } },
                {"trending", n => { Trending = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Trending>(Microsoft.Graph.Beta.Models.Trending.CreateFromDiscriminatorValue)?.ToList(); } },
                {"used", n => { Used = n.GetCollectionOfObjectValues<UsedInsight>(UsedInsight.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<SharedInsight>("shared", Shared);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Trending>("trending", Trending);
            writer.WriteCollectionOfObjectValues<UsedInsight>("used", Used);
        }
    }
}
