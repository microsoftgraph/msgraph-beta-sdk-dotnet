using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>A termsAndConditionsGroupAssignment entity represents the assignment of a given Terms and Conditions (T&amp;C) policy to a given group. Users in the group will be required to accept the terms in order to have devices enrolled into Intune.</summary>
    public class TermsAndConditionsGroupAssignment : Entity, IParsable {
        /// <summary>Unique identifier of a group that the T&amp;C policy is assigned to.</summary>
        public string TargetGroupId {
            get { return BackingStore?.Get<string>("targetGroupId"); }
            set { BackingStore?.Set("targetGroupId", value); }
        }
        /// <summary>Navigation link to the terms and conditions that are assigned.</summary>
        public Microsoft.Graph.Beta.Models.TermsAndConditions TermsAndConditions {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.TermsAndConditions>("termsAndConditions"); }
            set { BackingStore?.Set("termsAndConditions", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new TermsAndConditionsGroupAssignment CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TermsAndConditionsGroupAssignment();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"targetGroupId", n => { TargetGroupId = n.GetStringValue(); } },
                {"termsAndConditions", n => { TermsAndConditions = n.GetObjectValue<Microsoft.Graph.Beta.Models.TermsAndConditions>(Microsoft.Graph.Beta.Models.TermsAndConditions.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("targetGroupId", TargetGroupId);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.TermsAndConditions>("termsAndConditions", TermsAndConditions);
        }
    }
}
