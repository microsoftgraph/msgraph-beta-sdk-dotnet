using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class EnrollmentRestrictionsConfigurationPolicySetItem : PolicySetItem, IParsable {
        /// <summary>Limit of the EnrollmentRestrictionsConfigurationPolicySetItem.</summary>
        public int? Limit {
            get { return BackingStore?.Get<int?>("limit"); }
            set { BackingStore?.Set("limit", value); }
        }
        /// <summary>Priority of the EnrollmentRestrictionsConfigurationPolicySetItem.</summary>
        public int? Priority {
            get { return BackingStore?.Get<int?>("priority"); }
            set { BackingStore?.Set("priority", value); }
        }
        /// <summary>
        /// Instantiates a new EnrollmentRestrictionsConfigurationPolicySetItem and sets the default values.
        /// </summary>
        public EnrollmentRestrictionsConfigurationPolicySetItem() : base() {
            OdataType = "#microsoft.graph.enrollmentRestrictionsConfigurationPolicySetItem";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
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
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("limit", Limit);
            writer.WriteIntValue("priority", Priority);
        }
    }
}
