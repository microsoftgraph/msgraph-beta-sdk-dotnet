using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class ConditionalAccessEnumeratedExternalTenants : ConditionalAccessExternalTenants, IParsable {
        /// <summary>Represents a collection of tenant ids in the scope of Conditional Access for guests and external users policy targeting.</summary>
        public List<string> Members {
            get { return BackingStore?.Get<List<string>>("members"); }
            set { BackingStore?.Set("members", value); }
        }
        /// <summary>
        /// Instantiates a new ConditionalAccessEnumeratedExternalTenants and sets the default values.
        /// </summary>
        public ConditionalAccessEnumeratedExternalTenants() : base() {
            OdataType = "#microsoft.graph.conditionalAccessEnumeratedExternalTenants";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ConditionalAccessEnumeratedExternalTenants CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ConditionalAccessEnumeratedExternalTenants();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"members", n => { Members = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfPrimitiveValues<string>("members", Members);
        }
    }
}
