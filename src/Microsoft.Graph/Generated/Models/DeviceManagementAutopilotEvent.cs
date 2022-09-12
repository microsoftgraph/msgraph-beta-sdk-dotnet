using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Represents an Autopilot flow event.</summary>
    public class DeviceManagementAutopilotEvent : Entity, IParsable {
        /// <summary>Time spent in user ESP.</summary>
        public TimeSpan? AccountSetupDuration {
            get { return BackingStore?.Get<TimeSpan?>("accountSetupDuration"); }
            set { BackingStore?.Set("accountSetupDuration", value); }
        }
        /// <summary>The accountSetupStatus property</summary>
        public WindowsAutopilotDeploymentState? AccountSetupStatus {
            get { return BackingStore?.Get<WindowsAutopilotDeploymentState?>("accountSetupStatus"); }
            set { BackingStore?.Set("accountSetupStatus", value); }
        }
        /// <summary>Autopilot deployment duration including enrollment.</summary>
        public TimeSpan? DeploymentDuration {
            get { return BackingStore?.Get<TimeSpan?>("deploymentDuration"); }
            set { BackingStore?.Set("deploymentDuration", value); }
        }
        /// <summary>Deployment end time.</summary>
        public DateTimeOffset? DeploymentEndDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("deploymentEndDateTime"); }
            set { BackingStore?.Set("deploymentEndDateTime", value); }
        }
        /// <summary>Deployment start time.</summary>
        public DateTimeOffset? DeploymentStartDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("deploymentStartDateTime"); }
            set { BackingStore?.Set("deploymentStartDateTime", value); }
        }
        /// <summary>The deploymentState property</summary>
        public WindowsAutopilotDeploymentState? DeploymentState {
            get { return BackingStore?.Get<WindowsAutopilotDeploymentState?>("deploymentState"); }
            set { BackingStore?.Set("deploymentState", value); }
        }
        /// <summary>Total deployment duration from enrollment to Desktop screen.</summary>
        public TimeSpan? DeploymentTotalDuration {
            get { return BackingStore?.Get<TimeSpan?>("deploymentTotalDuration"); }
            set { BackingStore?.Set("deploymentTotalDuration", value); }
        }
        /// <summary>Device id associated with the object</summary>
        public string DeviceId {
            get { return BackingStore?.Get<string>("deviceId"); }
            set { BackingStore?.Set("deviceId", value); }
        }
        /// <summary>Time spent in device enrollment.</summary>
        public TimeSpan? DevicePreparationDuration {
            get { return BackingStore?.Get<TimeSpan?>("devicePreparationDuration"); }
            set { BackingStore?.Set("devicePreparationDuration", value); }
        }
        /// <summary>Device registration date.</summary>
        public DateTimeOffset? DeviceRegisteredDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("deviceRegisteredDateTime"); }
            set { BackingStore?.Set("deviceRegisteredDateTime", value); }
        }
        /// <summary>Device serial number.</summary>
        public string DeviceSerialNumber {
            get { return BackingStore?.Get<string>("deviceSerialNumber"); }
            set { BackingStore?.Set("deviceSerialNumber", value); }
        }
        /// <summary>Time spent in device ESP.</summary>
        public TimeSpan? DeviceSetupDuration {
            get { return BackingStore?.Get<TimeSpan?>("deviceSetupDuration"); }
            set { BackingStore?.Set("deviceSetupDuration", value); }
        }
        /// <summary>The deviceSetupStatus property</summary>
        public WindowsAutopilotDeploymentState? DeviceSetupStatus {
            get { return BackingStore?.Get<WindowsAutopilotDeploymentState?>("deviceSetupStatus"); }
            set { BackingStore?.Set("deviceSetupStatus", value); }
        }
        /// <summary>Enrollment failure details.</summary>
        public string EnrollmentFailureDetails {
            get { return BackingStore?.Get<string>("enrollmentFailureDetails"); }
            set { BackingStore?.Set("enrollmentFailureDetails", value); }
        }
        /// <summary>Device enrollment start date.</summary>
        public DateTimeOffset? EnrollmentStartDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("enrollmentStartDateTime"); }
            set { BackingStore?.Set("enrollmentStartDateTime", value); }
        }
        /// <summary>The enrollmentState property</summary>
        public Microsoft.Graph.Beta.Models.EnrollmentState? EnrollmentState {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.EnrollmentState?>("enrollmentState"); }
            set { BackingStore?.Set("enrollmentState", value); }
        }
        /// <summary>The enrollmentType property</summary>
        public WindowsAutopilotEnrollmentType? EnrollmentType {
            get { return BackingStore?.Get<WindowsAutopilotEnrollmentType?>("enrollmentType"); }
            set { BackingStore?.Set("enrollmentType", value); }
        }
        /// <summary>Time when the event occurred .</summary>
        public DateTimeOffset? EventDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("eventDateTime"); }
            set { BackingStore?.Set("eventDateTime", value); }
        }
        /// <summary>Managed device name.</summary>
        public string ManagedDeviceName {
            get { return BackingStore?.Get<string>("managedDeviceName"); }
            set { BackingStore?.Set("managedDeviceName", value); }
        }
        /// <summary>Device operating system version.</summary>
        public string OsVersion {
            get { return BackingStore?.Get<string>("osVersion"); }
            set { BackingStore?.Set("osVersion", value); }
        }
        /// <summary>Policy and application status details for this device.</summary>
        public List<DeviceManagementAutopilotPolicyStatusDetail> PolicyStatusDetails {
            get { return BackingStore?.Get<List<DeviceManagementAutopilotPolicyStatusDetail>>("policyStatusDetails"); }
            set { BackingStore?.Set("policyStatusDetails", value); }
        }
        /// <summary>Count of applications targeted.</summary>
        public int? TargetedAppCount {
            get { return BackingStore?.Get<int?>("targetedAppCount"); }
            set { BackingStore?.Set("targetedAppCount", value); }
        }
        /// <summary>Count of policies targeted.</summary>
        public int? TargetedPolicyCount {
            get { return BackingStore?.Get<int?>("targetedPolicyCount"); }
            set { BackingStore?.Set("targetedPolicyCount", value); }
        }
        /// <summary>User principal name used to enroll the device.</summary>
        public string UserPrincipalName {
            get { return BackingStore?.Get<string>("userPrincipalName"); }
            set { BackingStore?.Set("userPrincipalName", value); }
        }
        /// <summary>Enrollment Status Page profile name</summary>
        public string Windows10EnrollmentCompletionPageConfigurationDisplayName {
            get { return BackingStore?.Get<string>("windows10EnrollmentCompletionPageConfigurationDisplayName"); }
            set { BackingStore?.Set("windows10EnrollmentCompletionPageConfigurationDisplayName", value); }
        }
        /// <summary>Enrollment Status Page profile ID</summary>
        public string Windows10EnrollmentCompletionPageConfigurationId {
            get { return BackingStore?.Get<string>("windows10EnrollmentCompletionPageConfigurationId"); }
            set { BackingStore?.Set("windows10EnrollmentCompletionPageConfigurationId", value); }
        }
        /// <summary>Autopilot profile name.</summary>
        public string WindowsAutopilotDeploymentProfileDisplayName {
            get { return BackingStore?.Get<string>("windowsAutopilotDeploymentProfileDisplayName"); }
            set { BackingStore?.Set("windowsAutopilotDeploymentProfileDisplayName", value); }
        }
        /// <summary>
        /// Instantiates a new deviceManagementAutopilotEvent and sets the default values.
        /// </summary>
        public DeviceManagementAutopilotEvent() : base() {
            OdataType = "#microsoft.graph.deviceManagementAutopilotEvent";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DeviceManagementAutopilotEvent CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceManagementAutopilotEvent();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"accountSetupDuration", n => { AccountSetupDuration = n.GetTimeSpanValue(); } },
                {"accountSetupStatus", n => { AccountSetupStatus = n.GetEnumValue<WindowsAutopilotDeploymentState>(); } },
                {"deploymentDuration", n => { DeploymentDuration = n.GetTimeSpanValue(); } },
                {"deploymentEndDateTime", n => { DeploymentEndDateTime = n.GetDateTimeOffsetValue(); } },
                {"deploymentStartDateTime", n => { DeploymentStartDateTime = n.GetDateTimeOffsetValue(); } },
                {"deploymentState", n => { DeploymentState = n.GetEnumValue<WindowsAutopilotDeploymentState>(); } },
                {"deploymentTotalDuration", n => { DeploymentTotalDuration = n.GetTimeSpanValue(); } },
                {"deviceId", n => { DeviceId = n.GetStringValue(); } },
                {"devicePreparationDuration", n => { DevicePreparationDuration = n.GetTimeSpanValue(); } },
                {"deviceRegisteredDateTime", n => { DeviceRegisteredDateTime = n.GetDateTimeOffsetValue(); } },
                {"deviceSerialNumber", n => { DeviceSerialNumber = n.GetStringValue(); } },
                {"deviceSetupDuration", n => { DeviceSetupDuration = n.GetTimeSpanValue(); } },
                {"deviceSetupStatus", n => { DeviceSetupStatus = n.GetEnumValue<WindowsAutopilotDeploymentState>(); } },
                {"enrollmentFailureDetails", n => { EnrollmentFailureDetails = n.GetStringValue(); } },
                {"enrollmentStartDateTime", n => { EnrollmentStartDateTime = n.GetDateTimeOffsetValue(); } },
                {"enrollmentState", n => { EnrollmentState = n.GetEnumValue<EnrollmentState>(); } },
                {"enrollmentType", n => { EnrollmentType = n.GetEnumValue<WindowsAutopilotEnrollmentType>(); } },
                {"eventDateTime", n => { EventDateTime = n.GetDateTimeOffsetValue(); } },
                {"managedDeviceName", n => { ManagedDeviceName = n.GetStringValue(); } },
                {"osVersion", n => { OsVersion = n.GetStringValue(); } },
                {"policyStatusDetails", n => { PolicyStatusDetails = n.GetCollectionOfObjectValues<DeviceManagementAutopilotPolicyStatusDetail>(DeviceManagementAutopilotPolicyStatusDetail.CreateFromDiscriminatorValue)?.ToList(); } },
                {"targetedAppCount", n => { TargetedAppCount = n.GetIntValue(); } },
                {"targetedPolicyCount", n => { TargetedPolicyCount = n.GetIntValue(); } },
                {"userPrincipalName", n => { UserPrincipalName = n.GetStringValue(); } },
                {"windows10EnrollmentCompletionPageConfigurationDisplayName", n => { Windows10EnrollmentCompletionPageConfigurationDisplayName = n.GetStringValue(); } },
                {"windows10EnrollmentCompletionPageConfigurationId", n => { Windows10EnrollmentCompletionPageConfigurationId = n.GetStringValue(); } },
                {"windowsAutopilotDeploymentProfileDisplayName", n => { WindowsAutopilotDeploymentProfileDisplayName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteTimeSpanValue("accountSetupDuration", AccountSetupDuration);
            writer.WriteEnumValue<WindowsAutopilotDeploymentState>("accountSetupStatus", AccountSetupStatus);
            writer.WriteTimeSpanValue("deploymentDuration", DeploymentDuration);
            writer.WriteDateTimeOffsetValue("deploymentEndDateTime", DeploymentEndDateTime);
            writer.WriteDateTimeOffsetValue("deploymentStartDateTime", DeploymentStartDateTime);
            writer.WriteEnumValue<WindowsAutopilotDeploymentState>("deploymentState", DeploymentState);
            writer.WriteTimeSpanValue("deploymentTotalDuration", DeploymentTotalDuration);
            writer.WriteStringValue("deviceId", DeviceId);
            writer.WriteTimeSpanValue("devicePreparationDuration", DevicePreparationDuration);
            writer.WriteDateTimeOffsetValue("deviceRegisteredDateTime", DeviceRegisteredDateTime);
            writer.WriteStringValue("deviceSerialNumber", DeviceSerialNumber);
            writer.WriteTimeSpanValue("deviceSetupDuration", DeviceSetupDuration);
            writer.WriteEnumValue<WindowsAutopilotDeploymentState>("deviceSetupStatus", DeviceSetupStatus);
            writer.WriteStringValue("enrollmentFailureDetails", EnrollmentFailureDetails);
            writer.WriteDateTimeOffsetValue("enrollmentStartDateTime", EnrollmentStartDateTime);
            writer.WriteEnumValue<EnrollmentState>("enrollmentState", EnrollmentState);
            writer.WriteEnumValue<WindowsAutopilotEnrollmentType>("enrollmentType", EnrollmentType);
            writer.WriteDateTimeOffsetValue("eventDateTime", EventDateTime);
            writer.WriteStringValue("managedDeviceName", ManagedDeviceName);
            writer.WriteStringValue("osVersion", OsVersion);
            writer.WriteCollectionOfObjectValues<DeviceManagementAutopilotPolicyStatusDetail>("policyStatusDetails", PolicyStatusDetails);
            writer.WriteIntValue("targetedAppCount", TargetedAppCount);
            writer.WriteIntValue("targetedPolicyCount", TargetedPolicyCount);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
            writer.WriteStringValue("windows10EnrollmentCompletionPageConfigurationDisplayName", Windows10EnrollmentCompletionPageConfigurationDisplayName);
            writer.WriteStringValue("windows10EnrollmentCompletionPageConfigurationId", Windows10EnrollmentCompletionPageConfigurationId);
            writer.WriteStringValue("windowsAutopilotDeploymentProfileDisplayName", WindowsAutopilotDeploymentProfileDisplayName);
        }
    }
}
