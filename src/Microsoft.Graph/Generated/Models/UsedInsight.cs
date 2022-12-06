using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of accessReviewDecision entities.</summary>
    public class UsedInsight : Entity, IParsable {
        /// <summary>Information about when the item was last viewed or modified by the user. Read only.</summary>
        public UsageDetails LastUsed {
            get { return BackingStore?.Get<UsageDetails>("lastUsed"); }
            set { BackingStore?.Set("lastUsed", value); }
        }
        /// <summary>Used for navigating to the item that was used. For file attachments, the type is fileAttachment. For linked attachments, the type is driveItem.</summary>
        public Entity Resource {
            get { return BackingStore?.Get<Entity>("resource"); }
            set { BackingStore?.Set("resource", value); }
        }
        /// <summary>Reference properties of the used document, such as the url and type of the document. Read-only</summary>
        public Microsoft.Graph.Beta.Models.ResourceReference ResourceReference {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ResourceReference>("resourceReference"); }
            set { BackingStore?.Set("resourceReference", value); }
        }
        /// <summary>Properties that you can use to visualize the document in your experience. Read-only</summary>
        public Microsoft.Graph.Beta.Models.ResourceVisualization ResourceVisualization {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ResourceVisualization>("resourceVisualization"); }
            set { BackingStore?.Set("resourceVisualization", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new UsedInsight CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UsedInsight();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"lastUsed", n => { LastUsed = n.GetObjectValue<UsageDetails>(UsageDetails.CreateFromDiscriminatorValue); } },
                {"resource", n => { Resource = n.GetObjectValue<Entity>(Entity.CreateFromDiscriminatorValue); } },
                {"resourceReference", n => { ResourceReference = n.GetObjectValue<Microsoft.Graph.Beta.Models.ResourceReference>(Microsoft.Graph.Beta.Models.ResourceReference.CreateFromDiscriminatorValue); } },
                {"resourceVisualization", n => { ResourceVisualization = n.GetObjectValue<Microsoft.Graph.Beta.Models.ResourceVisualization>(Microsoft.Graph.Beta.Models.ResourceVisualization.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<UsageDetails>("lastUsed", LastUsed);
            writer.WriteObjectValue<Entity>("resource", Resource);
        }
    }
}
