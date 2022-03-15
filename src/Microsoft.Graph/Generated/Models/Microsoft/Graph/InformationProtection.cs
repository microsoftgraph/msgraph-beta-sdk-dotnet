using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public class InformationProtection : Entity, IParsable {
        public MicrosoftGraphSdk.Models.Microsoft.Graph.Bitlocker Bitlocker { get; set; }
        public List<DataLossPreventionPolicy> DataLossPreventionPolicies { get; set; }
        public InformationProtectionPolicy Policy { get; set; }
        public List<SensitivityLabel> SensitivityLabels { get; set; }
        public MicrosoftGraphSdk.Models.Microsoft.Graph.SensitivityPolicySettings SensitivityPolicySettings { get; set; }
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
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"bitlocker", (o,n) => { (o as InformationProtection).Bitlocker = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.Bitlocker>(MicrosoftGraphSdk.Models.Microsoft.Graph.Bitlocker.CreateFromDiscriminatorValue); } },
                {"dataLossPreventionPolicies", (o,n) => { (o as InformationProtection).DataLossPreventionPolicies = n.GetCollectionOfObjectValues<DataLossPreventionPolicy>(DataLossPreventionPolicy.CreateFromDiscriminatorValue).ToList(); } },
                {"policy", (o,n) => { (o as InformationProtection).Policy = n.GetObjectValue<InformationProtectionPolicy>(InformationProtectionPolicy.CreateFromDiscriminatorValue); } },
                {"sensitivityLabels", (o,n) => { (o as InformationProtection).SensitivityLabels = n.GetCollectionOfObjectValues<SensitivityLabel>(SensitivityLabel.CreateFromDiscriminatorValue).ToList(); } },
                {"sensitivityPolicySettings", (o,n) => { (o as InformationProtection).SensitivityPolicySettings = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.SensitivityPolicySettings>(MicrosoftGraphSdk.Models.Microsoft.Graph.SensitivityPolicySettings.CreateFromDiscriminatorValue); } },
                {"threatAssessmentRequests", (o,n) => { (o as InformationProtection).ThreatAssessmentRequests = n.GetCollectionOfObjectValues<ThreatAssessmentRequest>(ThreatAssessmentRequest.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.Bitlocker>("bitlocker", Bitlocker);
            writer.WriteCollectionOfObjectValues<DataLossPreventionPolicy>("dataLossPreventionPolicies", DataLossPreventionPolicies);
            writer.WriteObjectValue<InformationProtectionPolicy>("policy", Policy);
            writer.WriteCollectionOfObjectValues<SensitivityLabel>("sensitivityLabels", SensitivityLabels);
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.SensitivityPolicySettings>("sensitivityPolicySettings", SensitivityPolicySettings);
            writer.WriteCollectionOfObjectValues<ThreatAssessmentRequest>("threatAssessmentRequests", ThreatAssessmentRequests);
        }
    }
}
