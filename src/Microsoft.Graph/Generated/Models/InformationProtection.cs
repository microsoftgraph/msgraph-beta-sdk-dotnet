using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class InformationProtection : Entity, IParsable {
        /// <summary>The bitlocker property</summary>
        public Microsoft.Graph.Beta.Models.Bitlocker Bitlocker { get; set; }
        /// <summary>The dataLossPreventionPolicies property</summary>
        public List<DataLossPreventionPolicy> DataLossPreventionPolicies { get; set; }
        /// <summary>The policy property</summary>
        public InformationProtectionPolicy Policy { get; set; }
        /// <summary>The sensitivityLabels property</summary>
        public List<SensitivityLabel> SensitivityLabels { get; set; }
        /// <summary>The sensitivityPolicySettings property</summary>
        public Microsoft.Graph.Beta.Models.SensitivityPolicySettings SensitivityPolicySettings { get; set; }
        /// <summary>The threatAssessmentRequests property</summary>
        public List<ThreatAssessmentRequest> ThreatAssessmentRequests { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new InformationProtection CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new InformationProtection();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"bitlocker", n => { Bitlocker = n.GetObjectValue<Microsoft.Graph.Beta.Models.Bitlocker>(Microsoft.Graph.Beta.Models.Bitlocker.CreateFromDiscriminatorValue); } },
                {"dataLossPreventionPolicies", n => { DataLossPreventionPolicies = n.GetCollectionOfObjectValues<DataLossPreventionPolicy>(DataLossPreventionPolicy.CreateFromDiscriminatorValue).ToList(); } },
                {"policy", n => { Policy = n.GetObjectValue<InformationProtectionPolicy>(InformationProtectionPolicy.CreateFromDiscriminatorValue); } },
                {"sensitivityLabels", n => { SensitivityLabels = n.GetCollectionOfObjectValues<SensitivityLabel>(SensitivityLabel.CreateFromDiscriminatorValue).ToList(); } },
                {"sensitivityPolicySettings", n => { SensitivityPolicySettings = n.GetObjectValue<Microsoft.Graph.Beta.Models.SensitivityPolicySettings>(Microsoft.Graph.Beta.Models.SensitivityPolicySettings.CreateFromDiscriminatorValue); } },
                {"threatAssessmentRequests", n => { ThreatAssessmentRequests = n.GetCollectionOfObjectValues<ThreatAssessmentRequest>(ThreatAssessmentRequest.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Bitlocker>("bitlocker", Bitlocker);
            writer.WriteCollectionOfObjectValues<DataLossPreventionPolicy>("dataLossPreventionPolicies", DataLossPreventionPolicies);
            writer.WriteObjectValue<InformationProtectionPolicy>("policy", Policy);
            writer.WriteCollectionOfObjectValues<SensitivityLabel>("sensitivityLabels", SensitivityLabels);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.SensitivityPolicySettings>("sensitivityPolicySettings", SensitivityPolicySettings);
            writer.WriteCollectionOfObjectValues<ThreatAssessmentRequest>("threatAssessmentRequests", ThreatAssessmentRequests);
        }
    }
}
