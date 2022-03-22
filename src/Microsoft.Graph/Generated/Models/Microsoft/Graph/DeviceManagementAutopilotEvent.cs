using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class DeviceManagementAutopilotEvent : Entity, IParsable {
        /// <summary>Time spent in user ESP.</summary>
        public TimeSpan? AccountSetupDuration { get; set; }
        /// <summary>Deployment status for the enrollment status page account setup phase. Possible values are: unknown, success, inProgress, failure, successWithTimeout, notAttempted, disabled.</summary>
        public WindowsAutopilotDeploymentState? AccountSetupStatus { get; set; }
        /// <summary>Autopilot deployment duration including enrollment.</summary>
        public TimeSpan? DeploymentDuration { get; set; }
        /// <summary>Deployment end time.</summary>
        public DateTimeOffset? DeploymentEndDateTime { get; set; }
        /// <summary>Deployment start time.</summary>
        public DateTimeOffset? DeploymentStartDateTime { get; set; }
        /// <summary>Deployment state like Success, Failure, InProgress, SuccessWithTimeout. Possible values are: unknown, success, inProgress, failure, successWithTimeout, notAttempted, disabled.</summary>
        public WindowsAutopilotDeploymentState? DeploymentState { get; set; }
        /// <summary>Total deployment duration from enrollment to Desktop screen.</summary>
        public TimeSpan? DeploymentTotalDuration { get; set; }
        /// <summary>Device id associated with the object</summary>
        public string DeviceId { get; set; }
        /// <summary>Time spent in device enrollment.</summary>
        public TimeSpan? DevicePreparationDuration { get; set; }
        /// <summary>Device registration date.</summary>
        public DateTimeOffset? DeviceRegisteredDateTime { get; set; }
        /// <summary>Device serial number.</summary>
        public string DeviceSerialNumber { get; set; }
        /// <summary>Time spent in device ESP.</summary>
        public TimeSpan? DeviceSetupDuration { get; set; }
        /// <summary>Deployment status for the enrollment status page device setup phase. Possible values are: unknown, success, inProgress, failure, successWithTimeout, notAttempted, disabled.</summary>
        public WindowsAutopilotDeploymentState? DeviceSetupStatus { get; set; }
        /// <summary>Enrollment failure details.</summary>
        public string EnrollmentFailureDetails { get; set; }
        /// <summary>Device enrollment start date.</summary>
        public DateTimeOffset? EnrollmentStartDateTime { get; set; }
        /// <summary>Enrollment state like Enrolled, Failed. Possible values are: unknown, enrolled, pendingReset, failed, notContacted, blocked.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.EnrollmentState? EnrollmentState { get; set; }
        /// <summary>Enrollment type. Possible values are: unknown, azureADJoinedWithAutopilotProfile, offlineDomainJoined, azureADJoinedUsingDeviceAuthWithAutopilotProfile, azureADJoinedUsingDeviceAuthWithoutAutopilotProfile, azureADJoinedWithOfflineAutopilotProfile, azureADJoinedWithWhiteGlove, offlineDomainJoinedWithWhiteGlove, offlineDomainJoinedWithOfflineAutopilotProfile.</summary>
        public WindowsAutopilotEnrollmentType? EnrollmentType { get; set; }
        /// <summary>Time when the event occurred .</summary>
        public DateTimeOffset? EventDateTime { get; set; }
        /// <summary>Managed device name.</summary>
        public string ManagedDeviceName { get; set; }
        /// <summary>Device operating system version.</summary>
        public string OsVersion { get; set; }
        /// <summary>Policy and application status details for this device.</summary>
        public List<DeviceManagementAutopilotPolicyStatusDetail> PolicyStatusDetails { get; set; }
        /// <summary>Count of applications targeted.</summary>
        public int? TargetedAppCount { get; set; }
        /// <summary>Count of policies targeted.</summary>
        public int? TargetedPolicyCount { get; set; }
        /// <summary>User principal name used to enroll the device.</summary>
        public string UserPrincipalName { get; set; }
        /// <summary>Enrollment Status Page profile name</summary>
        public string Windows10EnrollmentCompletionPageConfigurationDisplayName { get; set; }
        /// <summary>Enrollment Status Page profile ID</summary>
        public string Windows10EnrollmentCompletionPageConfigurationId { get; set; }
        /// <summary>Autopilot profile name.</summary>
        public string WindowsAutopilotDeploymentProfileDisplayName { get; set; }
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
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"accountSetupDuration", (o,n) => { (o as DeviceManagementAutopilotEvent).AccountSetupDuration = n.GetTimeSpanValue(); } },
                {"accountSetupStatus", (o,n) => { (o as DeviceManagementAutopilotEvent).AccountSetupStatus = n.GetEnumValue<WindowsAutopilotDeploymentState>(); } },
                {"deploymentDuration", (o,n) => { (o as DeviceManagementAutopilotEvent).DeploymentDuration = n.GetTimeSpanValue(); } },
                {"deploymentEndDateTime", (o,n) => { (o as DeviceManagementAutopilotEvent).DeploymentEndDateTime = n.GetDateTimeOffsetValue(); } },
                {"deploymentStartDateTime", (o,n) => { (o as DeviceManagementAutopilotEvent).DeploymentStartDateTime = n.GetDateTimeOffsetValue(); } },
                {"deploymentState", (o,n) => { (o as DeviceManagementAutopilotEvent).DeploymentState = n.GetEnumValue<WindowsAutopilotDeploymentState>(); } },
                {"deploymentTotalDuration", (o,n) => { (o as DeviceManagementAutopilotEvent).DeploymentTotalDuration = n.GetTimeSpanValue(); } },
                {"deviceId", (o,n) => { (o as DeviceManagementAutopilotEvent).DeviceId = n.GetStringValue(); } },
                {"devicePreparationDuration", (o,n) => { (o as DeviceManagementAutopilotEvent).DevicePreparationDuration = n.GetTimeSpanValue(); } },
                {"deviceRegisteredDateTime", (o,n) => { (o as DeviceManagementAutopilotEvent).DeviceRegisteredDateTime = n.GetDateTimeOffsetValue(); } },
                {"deviceSerialNumber", (o,n) => { (o as DeviceManagementAutopilotEvent).DeviceSerialNumber = n.GetStringValue(); } },
                {"deviceSetupDuration", (o,n) => { (o as DeviceManagementAutopilotEvent).DeviceSetupDuration = n.GetTimeSpanValue(); } },
                {"deviceSetupStatus", (o,n) => { (o as DeviceManagementAutopilotEvent).DeviceSetupStatus = n.GetEnumValue<WindowsAutopilotDeploymentState>(); } },
                {"enrollmentFailureDetails", (o,n) => { (o as DeviceManagementAutopilotEvent).EnrollmentFailureDetails = n.GetStringValue(); } },
                {"enrollmentStartDateTime", (o,n) => { (o as DeviceManagementAutopilotEvent).EnrollmentStartDateTime = n.GetDateTimeOffsetValue(); } },
                {"enrollmentState", (o,n) => { (o as DeviceManagementAutopilotEvent).EnrollmentState = n.GetEnumValue<EnrollmentState>(); } },
                {"enrollmentType", (o,n) => { (o as DeviceManagementAutopilotEvent).EnrollmentType = n.GetEnumValue<WindowsAutopilotEnrollmentType>(); } },
                {"eventDateTime", (o,n) => { (o as DeviceManagementAutopilotEvent).EventDateTime = n.GetDateTimeOffsetValue(); } },
                {"managedDeviceName", (o,n) => { (o as DeviceManagementAutopilotEvent).ManagedDeviceName = n.GetStringValue(); } },
                {"osVersion", (o,n) => { (o as DeviceManagementAutopilotEvent).OsVersion = n.GetStringValue(); } },
                {"policyStatusDetails", (o,n) => { (o as DeviceManagementAutopilotEvent).PolicyStatusDetails = n.GetCollectionOfObjectValues<DeviceManagementAutopilotPolicyStatusDetail>(DeviceManagementAutopilotPolicyStatusDetail.CreateFromDiscriminatorValue).ToList(); } },
                {"targetedAppCount", (o,n) => { (o as DeviceManagementAutopilotEvent).TargetedAppCount = n.GetIntValue(); } },
                {"targetedPolicyCount", (o,n) => { (o as DeviceManagementAutopilotEvent).TargetedPolicyCount = n.GetIntValue(); } },
                {"userPrincipalName", (o,n) => { (o as DeviceManagementAutopilotEvent).UserPrincipalName = n.GetStringValue(); } },
                {"windows10EnrollmentCompletionPageConfigurationDisplayName", (o,n) => { (o as DeviceManagementAutopilotEvent).Windows10EnrollmentCompletionPageConfigurationDisplayName = n.GetStringValue(); } },
                {"windows10EnrollmentCompletionPageConfigurationId", (o,n) => { (o as DeviceManagementAutopilotEvent).Windows10EnrollmentCompletionPageConfigurationId = n.GetStringValue(); } },
                {"windowsAutopilotDeploymentProfileDisplayName", (o,n) => { (o as DeviceManagementAutopilotEvent).WindowsAutopilotDeploymentProfileDisplayName = n.GetStringValue(); } },
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
