using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Policy status detail item contained by an autopilot event.</summary>
    public class DeviceManagementAutopilotPolicyStatusDetail : Entity, IParsable {
        /// <summary>The policy compliance status. Possible values are: unknown, compliant, installed, notCompliant, notInstalled, error.</summary>
        public DeviceManagementAutopilotPolicyComplianceStatus? ComplianceStatus {
            get { return BackingStore?.Get<DeviceManagementAutopilotPolicyComplianceStatus?>(nameof(ComplianceStatus)); }
            set { BackingStore?.Set(nameof(ComplianceStatus), value); }
        }
        /// <summary>The friendly name of the policy.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>(nameof(DisplayName)); }
            set { BackingStore?.Set(nameof(DisplayName), value); }
        }
        /// <summary>The errorode associated with the compliance or enforcement status of the policy. Error code for enforcement status takes precedence if it exists.</summary>
        public int? ErrorCode {
            get { return BackingStore?.Get<int?>(nameof(ErrorCode)); }
            set { BackingStore?.Set(nameof(ErrorCode), value); }
        }
        /// <summary>Timestamp of the reported policy status</summary>
        public DateTimeOffset? LastReportedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(LastReportedDateTime)); }
            set { BackingStore?.Set(nameof(LastReportedDateTime), value); }
        }
        /// <summary>The type of policy. Possible values are: unknown, application, appModel, configurationPolicy.</summary>
        public DeviceManagementAutopilotPolicyType? PolicyType {
            get { return BackingStore?.Get<DeviceManagementAutopilotPolicyType?>(nameof(PolicyType)); }
            set { BackingStore?.Set(nameof(PolicyType), value); }
        }
        /// <summary>Indicates if this prolicy was tracked as part of the autopilot bootstrap enrollment sync session</summary>
        public bool? TrackedOnEnrollmentStatus {
            get { return BackingStore?.Get<bool?>(nameof(TrackedOnEnrollmentStatus)); }
            set { BackingStore?.Set(nameof(TrackedOnEnrollmentStatus), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DeviceManagementAutopilotPolicyStatusDetail CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceManagementAutopilotPolicyStatusDetail();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"complianceStatus", n => { ComplianceStatus = n.GetEnumValue<DeviceManagementAutopilotPolicyComplianceStatus>(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"errorCode", n => { ErrorCode = n.GetIntValue(); } },
                {"lastReportedDateTime", n => { LastReportedDateTime = n.GetDateTimeOffsetValue(); } },
                {"policyType", n => { PolicyType = n.GetEnumValue<DeviceManagementAutopilotPolicyType>(); } },
                {"trackedOnEnrollmentStatus", n => { TrackedOnEnrollmentStatus = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<DeviceManagementAutopilotPolicyComplianceStatus>("complianceStatus", ComplianceStatus);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteIntValue("errorCode", ErrorCode);
            writer.WriteDateTimeOffsetValue("lastReportedDateTime", LastReportedDateTime);
            writer.WriteEnumValue<DeviceManagementAutopilotPolicyType>("policyType", PolicyType);
            writer.WriteBoolValue("trackedOnEnrollmentStatus", TrackedOnEnrollmentStatus);
        }
    }
}
