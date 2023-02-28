using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class InformationProtectionPolicy : Entity, IParsable {
        /// <summary>The labels property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<InformationProtectionLabel>? Labels {
            get { return BackingStore?.Get<List<InformationProtectionLabel>?>("labels"); }
            set { BackingStore?.Set("labels", value); }
        }
#nullable restore
#else
        public List<InformationProtectionLabel> Labels {
            get { return BackingStore?.Get<List<InformationProtectionLabel>>("labels"); }
            set { BackingStore?.Set("labels", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new InformationProtectionPolicy CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new InformationProtectionPolicy();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"labels", n => { Labels = n.GetCollectionOfObjectValues<InformationProtectionLabel>(InformationProtectionLabel.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<InformationProtectionLabel>("labels", Labels);
        }
    }
}
