using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// Provides operations to manage the collection of accessReviewDecision entities.
    /// </summary>
    public class TeamTemplate : Entity, IParsable {
        /// <summary>The definitions property</summary>
        public List<TeamTemplateDefinition> Definitions {
            get { return BackingStore?.Get<List<TeamTemplateDefinition>>("definitions"); }
            set { BackingStore?.Set("definitions", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new TeamTemplate CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TeamTemplate();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"definitions", n => { Definitions = n.GetCollectionOfObjectValues<TeamTemplateDefinition>(TeamTemplateDefinition.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<TeamTemplateDefinition>("definitions", Definitions);
        }
    }
}
