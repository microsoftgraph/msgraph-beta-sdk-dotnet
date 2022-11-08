using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.WindowsUpdates {
    public class ExpeditedQualityUpdateReference : QualityUpdateReference, IParsable {
        /// <summary>Specifies other content to consider as equivalent. Supports a subset of the values for equivalentContentOption. Default value is latestSecurity. Possible values are: latestSecurity, unknownFutureValue.</summary>
        public EquivalentContentOption? EquivalentContent {
            get { return BackingStore?.Get<EquivalentContentOption?>("equivalentContent"); }
            set { BackingStore?.Set("equivalentContent", value); }
        }
        /// <summary>
        /// Instantiates a new ExpeditedQualityUpdateReference and sets the default values.
        /// </summary>
        public ExpeditedQualityUpdateReference() : base() {
            OdataType = "#microsoft.graph.windowsUpdates.expeditedQualityUpdateReference";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ExpeditedQualityUpdateReference CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ExpeditedQualityUpdateReference();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"equivalentContent", n => { EquivalentContent = n.GetEnumValue<EquivalentContentOption>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<EquivalentContentOption>("equivalentContent", EquivalentContent);
        }
    }
}
