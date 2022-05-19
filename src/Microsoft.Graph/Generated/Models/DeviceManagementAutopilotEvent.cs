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
            get { return BackingStore?.Get<TimeSpan?>(nameof(AccountSetupDuration)); }
            set { BackingStore?.Set(nameof(AccountSetupDuration), value); }
        }
        /// <summary>Deployment status for the enrollment status page account setup phase. Possible values are: unknown, success, inProgress, failure, successWithTimeout, notAttempted, disabled.</summary>
        public WindowsAutopilotDeploymentState? AccountSetupStatus {
            get { return BackingStore?.Get<WindowsAutopilotDeploymentState?>(nameof(AccountSetupStatus)); }
            set { BackingStore?.Set(nameof(AccountSetupStatus), value); }
        }
        /// <summary>Autopilot deployment duration including enrollment.</summary>
        public TimeSpan? DeploymentDuration {
            get { return BackingStore?.Get<TimeSpan?>(nameof(DeploymentDuration)); }
            set { BackingStore?.Set(nameof(DeploymentDuration), value); }
        }
        /// <summary>Deployment end time.</summary>
        public DateTimeOffset? DeploymentEndDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(DeploymentEndDateTime)); }
            set { BackingStore?.Set(nameof(DeploymentEndDateTime), value); }
        }
        /// <summary>Deployment start time.</summary>
        public DateTimeOffset? DeploymentStartDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(DeploymentStartDateTime)); }
            set { BackingStore?.Set(nameof(DeploymentStartDateTime), value); }
        }
        /// <summary>Deployment state like Success, Failure, InProgress, SuccessWithTimeout. Possible values are: unknown, success, inProgress, failure, successWithTimeout, notAttempted, disabled.</summary>
        public WindowsAutopilotDeploymentState? DeploymentState {
            get { return BackingStore?.Get<WindowsAutopilotDeploymentState?>(nameof(DeploymentState)); }
            set { BackingStore?.Set(nameof(DeploymentState), value); }
        }
        /// <summary>Total deployment duration from enrollment to Desktop screen.</summary>
        public TimeSpan? DeploymentTotalDuration {
            get { return BackingStore?.Get<TimeSpan?>(nameof(DeploymentTotalDuration)); }
            set { BackingStore?.Set(nameof(DeploymentTotalDuration), value); }
        }
        /// <summary>Device id associated with the object</summary>
        public string DeviceId {
            get { return BackingStore?.Get<string>(nameof(DeviceId)); }
            set { BackingStore?.Set(nameof(DeviceId), value); }
        }
        /// <summary>Time spent in device enrollment.</summary>
        public TimeSpan? DevicePreparationDuration {
            get { return BackingStore?.Get<TimeSpan?>(nameof(DevicePreparationDuration)); }
            set { BackingStore?.Set(nameof(DevicePreparationDuration), value); }
        }
        /// <summary>Device registration date.</summary>
        public DateTimeOffset? DeviceRegisteredDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(DeviceRegisteredDateTime)); }
            set { BackingStore?.Set(nameof(DeviceRegisteredDateTime), value); }
        }
        /// <summary>Device serial number.</summary>
        public string DeviceSerialNumber {
            get { return BackingStore?.Get<string>(nameof(DeviceSerialNumber)); }
            set { BackingStore?.Set(nameof(DeviceSerialNumber), value); }
        }
        /// <summary>Time spent in device ESP.</summary>
        public TimeSpan? DeviceSetupDuration {
            get { return BackingStore?.Get<TimeSpan?>(nameof(DeviceSetupDuration)); }
            set { BackingStore?.Set(nameof(DeviceSetupDuration), value); }
        }
        /// <summary>Deployment status for the enrollment status page device setup phase. Possible values are: unknown, success, inProgress, failure, successWithTimeout, notAttempted, disabled.</summary>
        public WindowsAutopilotDeploymentState? DeviceSetupStatus {
            get { return BackingStore?.Get<WindowsAutopilotDeploymentState?>(nameof(DeviceSetupStatus)); }
            set { BackingStore?.Set(nameof(DeviceSetupStatus), value); }
        }
        /// <summary>Enrollment failure details.</summary>
        public string EnrollmentFailureDetails {
            get { return BackingStore?.Get<string>(nameof(EnrollmentFailureDetails)); }
            set { BackingStore?.Set(nameof(EnrollmentFailureDetails), value); }
        }
        /// <summary>Device enrollment start date.</summary>
        public DateTimeOffset? EnrollmentStartDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(EnrollmentStartDateTime)); }
            set { BackingStore?.Set(nameof(EnrollmentStartDateTime), value); }
        }
        /// <summary>Enrollment state like Enrolled, Failed. Possible values are: unknown, enrolled, pendingReset, failed, notContacted, blocked.</summary>
        public Microsoft.Graph.Beta.Models.EnrollmentState? EnrollmentState {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.EnrollmentState?>(nameof(EnrollmentState)); }
            set { BackingStore?.Set(nameof(EnrollmentState), value); }
        }
        /// <summary>Enrollment type. Possible values are: unknown, azureADJoinedWithAutopilotProfile, offlineDomainJoined, azureADJoinedUsingDeviceAuthWithAutopilotProfile, azureADJoinedUsingDeviceAuthWithoutAutopilotProfile, azureADJoinedWithOfflineAutopilotProfile, azureADJoinedWithWhiteGlove, offlineDomainJoinedWithWhiteGlove, offlineDomainJoinedWithOfflineAutopilotProfile.</summary>
        public WindowsAutopilotEnrollmentType? EnrollmentType {
            get { return BackingStore?.Get<WindowsAutopilotEnrollmentType?>(nameof(EnrollmentType)); }
            set { BackingStore?.Set(nameof(EnrollmentType), value); }
        }
        /// <summary>Time when the event occurred .</summary>
        public DateTimeOffset? EventDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(EventDateTime)); }
            set { BackingStore?.Set(nameof(EventDateTime), value); }
        }
        /// <summary>Managed device name.</summary>
        public string ManagedDeviceName {
            get { return BackingStore?.Get<string>(nameof(ManagedDeviceName)); }
            set { BackingStore?.Set(nameof(ManagedDeviceName), value); }
        }
        /// <summary>Device operating system version.</summary>
        public string OsVersion {
            get { return BackingStore?.Get<string>(nameof(OsVersion)); }
            set { BackingStore?.Set(nameof(OsVersion), value); }
        }
        /// <summary>Policy and application status details for this device.</summary>
        public List<DeviceManagementAutopilotPolicyStatusDetail> PolicyStatusDetails {
            get { return BackingStore?.Get<List<DeviceManagementAutopilotPolicyStatusDetail>>(nameof(PolicyStatusDetails)); }
            set { BackingStore?.Set(nameof(PolicyStatusDetails), value); }
        }
        /// <summary>Count of applications targeted.</summary>
        public int? TargetedAppCount {
            get { return BackingStore?.Get<int?>(nameof(TargetedAppCount)); }
            set { BackingStore?.Set(nameof(TargetedAppCount), value); }
        }
        /// <summary>Count of policies targeted.</summary>
        public int? TargetedPolicyCount {
            get { return BackingStore?.Get<int?>(nameof(TargetedPolicyCount)); }
            set { BackingStore?.Set(nameof(TargetedPolicyCount), value); }
        }
        /// <summary>User principal name used to enroll the device.</summary>
        public string UserPrincipalName {
            get { return BackingStore?.Get<string>(nameof(UserPrincipalName)); }
            set { BackingStore?.Set(nameof(UserPrincipalName), value); }
        }
        /// <summary>Enrollment Status Page profile name</summary>
        public string Windows10EnrollmentCompletionPageConfigurationDisplayName {
            get { return BackingStore?.Get<string>(nameof(Windows10EnrollmentCompletionPageConfigurationDisplayName)); }
            set { BackingStore?.Set(nameof(Windows10EnrollmentCompletionPageConfigurationDisplayName), value); }
        }
        /// <summary>Enrollment Status Page profile ID</summary>
        public string Windows10EnrollmentCompletionPageConfigurationId {
            get { return BackingStore?.Get<string>(nameof(Windows10EnrollmentCompletionPageConfigurationId)); }
            set { BackingStore?.Set(nameof(Windows10EnrollmentCompletionPageConfigurationId), value); }
        }
        /// <summary>Autopilot profile name.</summary>
        public string WindowsAutopilotDeploymentProfileDisplayName {
            get { return BackingStore?.Get<string>(nameof(WindowsAutopilotDeploymentProfileDisplayName)); }
            set { BackingStore?.Set(nameof(WindowsAutopilotDeploymentProfileDisplayName), value); }
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
                {"policyStatusDetails", n => { PolicyStatusDetails = n.GetCollectionOfObjectValues<DeviceManagementAutopilotPolicyStatusDetail>(DeviceManagementAutopilotPolicyStatusDetail.CreateFromDiscriminatorValue).ToList(); } },
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
