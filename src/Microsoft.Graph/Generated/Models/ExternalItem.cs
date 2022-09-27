using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of activityStatistics entities.</summary>
    public class ExternalItem : Entity, IParsable {
        /// <summary>The acl property</summary>
        public List<Microsoft.Graph.Beta.Models.Acl> Acl {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.Acl>>("acl"); }
            set { BackingStore?.Set("acl", value); }
        }
        /// <summary>The content property</summary>
        public ExternalItemContent Content {
            get { return BackingStore?.Get<ExternalItemContent>("content"); }
            set { BackingStore?.Set("content", value); }
        }
        /// <summary>The properties property</summary>
        public Microsoft.Graph.Beta.Models.Properties Properties {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Properties>("properties"); }
            set { BackingStore?.Set("properties", value); }
        }
        /// <summary>
        /// Instantiates a new externalItem and sets the default values.
        /// </summary>
        public ExternalItem() : base() {
            OdataType = "#microsoft.graph.externalItem";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ExternalItem CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ExternalItem();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"acl", n => { Acl = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Acl>(Microsoft.Graph.Beta.Models.Acl.CreateFromDiscriminatorValue)?.ToList(); } },
                {"content", n => { Content = n.GetObjectValue<ExternalItemContent>(ExternalItemContent.CreateFromDiscriminatorValue); } },
                {"properties", n => { Properties = n.GetObjectValue<Microsoft.Graph.Beta.Models.Properties>(Microsoft.Graph.Beta.Models.Properties.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Acl>("acl", Acl);
            writer.WriteObjectValue<ExternalItemContent>("content", Content);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Properties>("properties", Properties);
        }
    }
}
