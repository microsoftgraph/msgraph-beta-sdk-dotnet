using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class TermsAndConditionsGroupAssignment : Entity, IParsable {
        /// <summary>Unique identifier of a group that the T&C policy is assigned to.</summary>
        public string TargetGroupId { get; set; }
        /// <summary>Navigation link to the terms and conditions that are assigned.</summary>
        public TermsAndConditions TermsAndConditions { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"targetGroupId", (o,n) => { (o as TermsAndConditionsGroupAssignment).TargetGroupId = n.GetStringValue(); } },
                {"termsAndConditions", (o,n) => { (o as TermsAndConditionsGroupAssignment).TermsAndConditions = n.GetObjectValue<TermsAndConditions>(); } },
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
            writer.WriteObjectValue<TermsAndConditions>("termsAndConditions", TermsAndConditions);
        }
    }
}
