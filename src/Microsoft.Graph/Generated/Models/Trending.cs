using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of activityStatistics entities.</summary>
    public class Trending : Entity, IParsable {
        /// <summary>The lastModifiedDateTime property</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>Used for navigating to the trending document.</summary>
        public Entity Resource {
            get { return BackingStore?.Get<Entity>("resource"); }
            set { BackingStore?.Set("resource", value); }
        }
        /// <summary>Reference properties of the trending document, such as the url and type of the document.</summary>
        public Microsoft.Graph.Beta.Models.ResourceReference ResourceReference {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ResourceReference>("resourceReference"); }
            set { BackingStore?.Set("resourceReference", value); }
        }
        /// <summary>Properties that you can use to visualize the document in your experience.</summary>
        public Microsoft.Graph.Beta.Models.ResourceVisualization ResourceVisualization {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ResourceVisualization>("resourceVisualization"); }
            set { BackingStore?.Set("resourceVisualization", value); }
        }
        /// <summary>Value indicating how much the document is currently trending. The larger the number, the more the document is currently trending around the user (the more relevant it is). Returned documents are sorted by this value.</summary>
        public double? Weight {
            get { return BackingStore?.Get<double?>("weight"); }
            set { BackingStore?.Set("weight", value); }
        }
        /// <summary>
        /// Instantiates a new trending and sets the default values.
        /// </summary>
        public Trending() : base() {
            OdataType = "#microsoft.graph.trending";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Trending CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Trending();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"resource", n => { Resource = n.GetObjectValue<Entity>(Entity.CreateFromDiscriminatorValue); } },
                {"resourceReference", n => { ResourceReference = n.GetObjectValue<Microsoft.Graph.Beta.Models.ResourceReference>(Microsoft.Graph.Beta.Models.ResourceReference.CreateFromDiscriminatorValue); } },
                {"resourceVisualization", n => { ResourceVisualization = n.GetObjectValue<Microsoft.Graph.Beta.Models.ResourceVisualization>(Microsoft.Graph.Beta.Models.ResourceVisualization.CreateFromDiscriminatorValue); } },
                {"weight", n => { Weight = n.GetDoubleValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteObjectValue<Entity>("resource", Resource);
            writer.WriteDoubleValue("weight", Weight);
        }
    }
}
