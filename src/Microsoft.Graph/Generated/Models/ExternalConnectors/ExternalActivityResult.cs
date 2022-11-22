using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.ExternalConnectors {
    public class ExternalActivityResult : ExternalActivity, IParsable {
        /// <summary>Error information explaining failure to process external activity.</summary>
        public Microsoft.Graph.Beta.Models.PublicError Error {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.PublicError>("error"); }
            set { BackingStore?.Set("error", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ExternalActivityResult CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ExternalActivityResult();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"error", n => { Error = n.GetObjectValue<Microsoft.Graph.Beta.Models.PublicError>(Microsoft.Graph.Beta.Models.PublicError.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.PublicError>("error", Error);
        }
    }
}
