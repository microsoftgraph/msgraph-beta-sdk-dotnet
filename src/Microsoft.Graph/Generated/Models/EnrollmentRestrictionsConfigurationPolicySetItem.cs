using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class EnrollmentRestrictionsConfigurationPolicySetItem : PolicySetItem, IParsable {
        /// <summary>Limit of the EnrollmentRestrictionsConfigurationPolicySetItem.</summary>
        public int? Limit {
            get { return BackingStore?.Get<int?>(nameof(Limit)); }
            set { BackingStore?.Set(nameof(Limit), value); }
        }
        /// <summary>Priority of the EnrollmentRestrictionsConfigurationPolicySetItem.</summary>
        public int? Priority {
            get { return BackingStore?.Get<int?>(nameof(Priority)); }
            set { BackingStore?.Set(nameof(Priority), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new EnrollmentRestrictionsConfigurationPolicySetItem CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EnrollmentRestrictionsConfigurationPolicySetItem();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"limit", n => { Limit = n.GetIntValue(); } },
                {"priority", n => { Priority = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("limit", Limit);
            writer.WriteIntValue("priority", Priority);
        }
    }
}
