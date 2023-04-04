using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class PlannerBucketPropertyRule : PlannerPropertyRule, IParsable {
        /// <summary>The order property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Order {
            get { return BackingStore?.Get<List<string>?>("order"); }
            set { BackingStore?.Set("order", value); }
        }
#nullable restore
#else
        public List<string> Order {
            get { return BackingStore?.Get<List<string>>("order"); }
            set { BackingStore?.Set("order", value); }
        }
#endif
        /// <summary>The title property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Title {
            get { return BackingStore?.Get<List<string>?>("title"); }
            set { BackingStore?.Set("title", value); }
        }
#nullable restore
#else
        public List<string> Title {
            get { return BackingStore?.Get<List<string>>("title"); }
            set { BackingStore?.Set("title", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new PlannerBucketPropertyRule and sets the default values.
        /// </summary>
        public PlannerBucketPropertyRule() : base() {
            OdataType = "#microsoft.graph.plannerBucketPropertyRule";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new PlannerBucketPropertyRule CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PlannerBucketPropertyRule();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"order", n => { Order = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"title", n => { Title = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfPrimitiveValues<string>("order", Order);
            writer.WriteCollectionOfPrimitiveValues<string>("title", Title);
        }
    }
}
