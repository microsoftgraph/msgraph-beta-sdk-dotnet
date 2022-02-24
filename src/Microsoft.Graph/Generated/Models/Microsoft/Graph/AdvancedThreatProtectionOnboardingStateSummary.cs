using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class AdvancedThreatProtectionOnboardingStateSummary : Entity, IParsable {
        /// <summary>Not yet documented</summary>
        public List<AdvancedThreatProtectionOnboardingDeviceSettingState> AdvancedThreatProtectionOnboardingDeviceSettingStates { get; set; }
        /// <summary>Number of compliant devices</summary>
        public int? CompliantDeviceCount { get; set; }
        /// <summary>Number of conflict devices</summary>
        public int? ConflictDeviceCount { get; set; }
        /// <summary>Number of error devices</summary>
        public int? ErrorDeviceCount { get; set; }
        /// <summary>Number of NonCompliant devices</summary>
        public int? NonCompliantDeviceCount { get; set; }
        /// <summary>Number of not applicable devices</summary>
        public int? NotApplicableDeviceCount { get; set; }
        /// <summary>Number of not assigned devices</summary>
        public int? NotAssignedDeviceCount { get; set; }
        /// <summary>Number of remediated devices</summary>
        public int? RemediatedDeviceCount { get; set; }
        /// <summary>Number of unknown devices</summary>
        public int? UnknownDeviceCount { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"advancedThreatProtectionOnboardingDeviceSettingStates", (o,n) => { (o as AdvancedThreatProtectionOnboardingStateSummary).AdvancedThreatProtectionOnboardingDeviceSettingStates = n.GetCollectionOfObjectValues<AdvancedThreatProtectionOnboardingDeviceSettingState>().ToList(); } },
                {"compliantDeviceCount", (o,n) => { (o as AdvancedThreatProtectionOnboardingStateSummary).CompliantDeviceCount = n.GetIntValue(); } },
                {"conflictDeviceCount", (o,n) => { (o as AdvancedThreatProtectionOnboardingStateSummary).ConflictDeviceCount = n.GetIntValue(); } },
                {"errorDeviceCount", (o,n) => { (o as AdvancedThreatProtectionOnboardingStateSummary).ErrorDeviceCount = n.GetIntValue(); } },
                {"nonCompliantDeviceCount", (o,n) => { (o as AdvancedThreatProtectionOnboardingStateSummary).NonCompliantDeviceCount = n.GetIntValue(); } },
                {"notApplicableDeviceCount", (o,n) => { (o as AdvancedThreatProtectionOnboardingStateSummary).NotApplicableDeviceCount = n.GetIntValue(); } },
                {"notAssignedDeviceCount", (o,n) => { (o as AdvancedThreatProtectionOnboardingStateSummary).NotAssignedDeviceCount = n.GetIntValue(); } },
                {"remediatedDeviceCount", (o,n) => { (o as AdvancedThreatProtectionOnboardingStateSummary).RemediatedDeviceCount = n.GetIntValue(); } },
                {"unknownDeviceCount", (o,n) => { (o as AdvancedThreatProtectionOnboardingStateSummary).UnknownDeviceCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<AdvancedThreatProtectionOnboardingDeviceSettingState>("advancedThreatProtectionOnboardingDeviceSettingStates", AdvancedThreatProtectionOnboardingDeviceSettingStates);
            writer.WriteIntValue("compliantDeviceCount", CompliantDeviceCount);
            writer.WriteIntValue("conflictDeviceCount", ConflictDeviceCount);
            writer.WriteIntValue("errorDeviceCount", ErrorDeviceCount);
            writer.WriteIntValue("nonCompliantDeviceCount", NonCompliantDeviceCount);
            writer.WriteIntValue("notApplicableDeviceCount", NotApplicableDeviceCount);
            writer.WriteIntValue("notAssignedDeviceCount", NotAssignedDeviceCount);
            writer.WriteIntValue("remediatedDeviceCount", RemediatedDeviceCount);
            writer.WriteIntValue("unknownDeviceCount", UnknownDeviceCount);
        }
    }
}
