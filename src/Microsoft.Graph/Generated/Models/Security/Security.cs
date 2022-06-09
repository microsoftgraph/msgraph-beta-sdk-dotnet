using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.Security {
    /// <summary>Provides operations to manage the collection of administrativeUnit entities.</summary>
    public class Security : Entity, IParsable {
        /// <summary>The informationProtection property</summary>
        public Microsoft.Graph.Beta.Models.Security.InformationProtection InformationProtection {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Security.InformationProtection>(nameof(InformationProtection)); }
            set { BackingStore?.Set(nameof(InformationProtection), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Security CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Security();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"informationProtection", n => { InformationProtection = n.GetObjectValue<Microsoft.Graph.Beta.Models.Security.InformationProtection>(Microsoft.Graph.Beta.Models.Security.InformationProtection.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Security.InformationProtection>("informationProtection", InformationProtection);
        }
    }
}
