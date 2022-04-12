using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class ExternalIdentitiesPolicy : PolicyBase, IParsable {
        /// <summary>The allowDeletedIdentitiesDataRemoval property</summary>
        public bool? AllowDeletedIdentitiesDataRemoval { get; set; }
        /// <summary>The allowExternalIdentitiesToLeave property</summary>
        public bool? AllowExternalIdentitiesToLeave { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ExternalIdentitiesPolicy CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ExternalIdentitiesPolicy();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"allowDeletedIdentitiesDataRemoval", n => { AllowDeletedIdentitiesDataRemoval = n.GetBoolValue(); } },
                {"allowExternalIdentitiesToLeave", n => { AllowExternalIdentitiesToLeave = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("allowDeletedIdentitiesDataRemoval", AllowDeletedIdentitiesDataRemoval);
            writer.WriteBoolValue("allowExternalIdentitiesToLeave", AllowExternalIdentitiesToLeave);
        }
    }
}
