using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class ManagedDevice : Entity, IParsable {
        /// <summary>Whether the device is Azure Active Directory registered. This property is read-only.</summary>
        public bool? AadRegistered { get; set; }
        /// <summary>Code that allows the Activation Lock on a device to be bypassed. This property is read-only.</summary>
        public string ActivationLockBypassCode { get; set; }
        /// <summary>Android security patch level. This property is read-only.</summary>
        public string AndroidSecurityPatchLevel { get; set; }
        /// <summary>Managed device mobile app configuration states for this device.</summary>
        public List<MicrosoftGraphSdk.Models.Microsoft.Graph.AssignmentFilterEvaluationStatusDetails> AssignmentFilterEvaluationStatusDetails { get; set; }
        /// <summary>Reports if the managed device is enrolled via auto-pilot. This property is read-only.</summary>
        public bool? AutopilotEnrolled { get; set; }
        /// <summary>The unique identifier for the Azure Active Directory device. Read only. This property is read-only.</summary>
        public string AzureActiveDirectoryDeviceId { get; set; }
        /// <summary>The unique identifier for the Azure Active Directory device. Read only. This property is read-only.</summary>
        public string AzureADDeviceId { get; set; }
        /// <summary>Whether the device is Azure Active Directory registered. This property is read-only.</summary>
        public bool? AzureADRegistered { get; set; }
        /// <summary>Chassis type of the device. This property is read-only. Possible values are: unknown, desktop, laptop, worksWorkstation, enterpriseServer, phone, tablet, mobileOther, mobileUnknown.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.ChassisType? ChassisType { get; set; }
        /// <summary>List of properties of the ChromeOS Device.</summary>
        public List<ChromeOSDeviceProperty> ChromeOSDeviceInfo { get; set; }
        /// <summary>The cloudPcRemoteActionResults property</summary>
        public List<CloudPcRemoteActionResult> CloudPcRemoteActionResults { get; set; }
        /// <summary>The DateTime when device compliance grace period expires. This property is read-only.</summary>
        public DateTimeOffset? ComplianceGracePeriodExpirationDateTime { get; set; }
        /// <summary>Compliance state of the device. This property is read-only. Possible values are: unknown, compliant, noncompliant, conflict, error, inGracePeriod, configManager.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.ComplianceState? ComplianceState { get; set; }
        /// <summary>ConfigrMgr client enabled features. This property is read-only.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.ConfigurationManagerClientEnabledFeatures ConfigurationManagerClientEnabledFeatures { get; set; }
        /// <summary>Configuration manager client health state, valid only for devices managed by MDM/ConfigMgr Agent</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.ConfigurationManagerClientHealthState ConfigurationManagerClientHealthState { get; set; }
        /// <summary>Configuration manager client information, valid only for devices managed, duel-managed or tri-managed by ConfigMgr Agent</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.ConfigurationManagerClientInformation ConfigurationManagerClientInformation { get; set; }
        /// <summary>All applications currently installed on the device</summary>
        public List<DetectedApp> DetectedApps { get; set; }
        /// <summary>List of ComplexType deviceActionResult objects. This property is read-only.</summary>
        public List<DeviceActionResult> DeviceActionResults { get; set; }
        /// <summary>Device category</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.DeviceCategory DeviceCategory { get; set; }
        /// <summary>Device category display name. This property is read-only.</summary>
        public string DeviceCategoryDisplayName { get; set; }
        /// <summary>Device compliance policy states for this device.</summary>
        public List<DeviceCompliancePolicyState> DeviceCompliancePolicyStates { get; set; }
        /// <summary>Device configuration states for this device.</summary>
        public List<DeviceConfigurationState> DeviceConfigurationStates { get; set; }
        /// <summary>Enrollment type of the device. This property is read-only. Possible values are: unknown, userEnrollment, deviceEnrollmentManager, appleBulkWithUser, appleBulkWithoutUser, windowsAzureADJoin, windowsBulkUserless, windowsAutoEnrollment, windowsBulkAzureDomainJoin, windowsCoManagement, windowsAzureADJoinUsingDeviceAuth, appleUserEnrollment, appleUserEnrollmentWithServiceAccount.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.DeviceEnrollmentType? DeviceEnrollmentType { get; set; }
        /// <summary>The device health attestation state. This property is read-only.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.DeviceHealthAttestationState DeviceHealthAttestationState { get; set; }
        /// <summary>Name of the device. This property is read-only.</summary>
        public string DeviceName { get; set; }
        /// <summary>Device registration state. This property is read-only. Possible values are: notRegistered, registered, revoked, keyConflict, approvalPending, certificateReset, notRegisteredPendingEnrollment, unknown.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.DeviceRegistrationState? DeviceRegistrationState { get; set; }
        /// <summary>Platform of the device. This property is read-only. Possible values are: desktop, windowsRT, winMO6, nokia, windowsPhone, mac, winCE, winEmbedded, iPhone, iPad, iPod, android, iSocConsumer, unix, macMDM, holoLens, surfaceHub, androidForWork, androidEnterprise, windows10x, androidnGMS, chromeOS, linux, blackberry, palm, unknown, cloudPC.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.DeviceType? DeviceType { get; set; }
        /// <summary>Whether the device is Exchange ActiveSync activated. This property is read-only.</summary>
        public bool? EasActivated { get; set; }
        /// <summary>Exchange ActivationSync activation time of the device. This property is read-only.</summary>
        public DateTimeOffset? EasActivationDateTime { get; set; }
        /// <summary>Exchange ActiveSync Id of the device. This property is read-only.</summary>
        public string EasDeviceId { get; set; }
        /// <summary>Email(s) for the user associated with the device. This property is read-only.</summary>
        public string EmailAddress { get; set; }
        /// <summary>Enrollment time of the device. This property is read-only.</summary>
        public DateTimeOffset? EnrolledDateTime { get; set; }
        /// <summary>Name of the enrollment profile assigned to the device. Default value is empty string, indicating no enrollment profile was assgined. This property is read-only.</summary>
        public string EnrollmentProfileName { get; set; }
        /// <summary>Ethernet MAC. This property is read-only.</summary>
        public string EthernetMacAddress { get; set; }
        /// <summary>The Access State of the device in Exchange. This property is read-only. Possible values are: none, unknown, allowed, blocked, quarantined.</summary>
        public DeviceManagementExchangeAccessState? ExchangeAccessState { get; set; }
        /// <summary>The reason for the device&apos;s access state in Exchange. This property is read-only. Possible values are: none, unknown, exchangeGlobalRule, exchangeIndividualRule, exchangeDeviceRule, exchangeUpgrade, exchangeMailboxPolicy, other, compliant, notCompliant, notEnrolled, unknownLocation, mfaRequired, azureADBlockDueToAccessPolicy, compromisedPassword, deviceNotKnownWithManagedApp.</summary>
        public DeviceManagementExchangeAccessStateReason? ExchangeAccessStateReason { get; set; }
        /// <summary>Last time the device contacted Exchange. This property is read-only.</summary>
        public DateTimeOffset? ExchangeLastSuccessfulSyncDateTime { get; set; }
        /// <summary>Free Storage in Bytes. This property is read-only.</summary>
        public long? FreeStorageSpaceInBytes { get; set; }
        /// <summary>The hardward details for the device.  Includes information such as storage space, manufacturer, serial number, etc. This property is read-only.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.HardwareInformation HardwareInformation { get; set; }
        /// <summary>Integrated Circuit Card Identifier, it is A SIM card&apos;s unique identification number. This property is read-only.</summary>
        public string Iccid { get; set; }
        /// <summary>IMEI. This property is read-only.</summary>
        public string Imei { get; set; }
        /// <summary>Device encryption status. This property is read-only.</summary>
        public bool? IsEncrypted { get; set; }
        /// <summary>Device supervised status. This property is read-only.</summary>
        public bool? IsSupervised { get; set; }
        /// <summary>whether the device is jail broken or rooted. This property is read-only.</summary>
        public string JailBroken { get; set; }
        /// <summary>Device join type. Possible values are: unknown, azureADJoined, azureADRegistered, hybridAzureADJoined.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.JoinType? JoinType { get; set; }
        /// <summary>The date and time that the device last completed a successful sync with Intune. This property is read-only.</summary>
        public DateTimeOffset? LastSyncDateTime { get; set; }
        /// <summary>List of log collection requests</summary>
        public List<DeviceLogCollectionResponse> LogCollectionRequests { get; set; }
        /// <summary>Indicates if Lost mode is enabled or disabled. This property is read-only. Possible values are: disabled, enabled.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.LostModeState? LostModeState { get; set; }
        /// <summary>Managed device mobile app configuration states for this device.</summary>
        public List<ManagedDeviceMobileAppConfigurationState> ManagedDeviceMobileAppConfigurationStates { get; set; }
        /// <summary>Automatically generated name to identify a device. Can be overwritten to a user friendly name.</summary>
        public string ManagedDeviceName { get; set; }
        /// <summary>Ownership of the device. Can be &apos;company&apos; or &apos;personal&apos;. Possible values are: unknown, company, personal.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.ManagedDeviceOwnerType? ManagedDeviceOwnerType { get; set; }
        /// <summary>Management channel of the device. Intune, EAS, etc. This property is read-only. Possible values are: eas, mdm, easMdm, intuneClient, easIntuneClient, configurationManagerClient, configurationManagerClientMdm, configurationManagerClientMdmEas, unknown, jamf, googleCloudDevicePolicyController.</summary>
        public ManagementAgentType? ManagementAgent { get; set; }
        /// <summary>Reports device management certificate expiration date. This property is read-only.</summary>
        public DateTimeOffset? ManagementCertificateExpirationDate { get; set; }
        /// <summary>Device management features. Possible values are: none, microsoftManagedDesktop.</summary>
        public ManagedDeviceManagementFeatures? ManagementFeatures { get; set; }
        /// <summary>Management state of the device. This property is read-only. Possible values are: managed, retirePending, retireFailed, wipePending, wipeFailed, unhealthy, deletePending, retireIssued, wipeIssued, wipeCanceled, retireCanceled, discovered.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.ManagementState? ManagementState { get; set; }
        /// <summary>Manufacturer of the device. This property is read-only.</summary>
        public string Manufacturer { get; set; }
        /// <summary>MEID. This property is read-only.</summary>
        public string Meid { get; set; }
        /// <summary>Model of the device. This property is read-only.</summary>
        public string Model { get; set; }
        /// <summary>Notes on the device created by IT Admin</summary>
        public string Notes { get; set; }
        /// <summary>Operating system of the device. Windows, iOS, etc. This property is read-only.</summary>
        public string OperatingSystem { get; set; }
        /// <summary>Operating system version of the device. This property is read-only.</summary>
        public string OsVersion { get; set; }
        /// <summary>Ownership of the device. Can be &apos;company&apos; or &apos;personal&apos;. Possible values are: unknown, company, personal.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.OwnerType? OwnerType { get; set; }
        /// <summary>Indicates the threat state of a device when a Mobile Threat Defense partner is in use by the account and device. Read Only. This property is read-only. Possible values are: unknown, activated, deactivated, secured, lowSeverity, mediumSeverity, highSeverity, unresponsive, compromised, misconfigured.</summary>
        public ManagedDevicePartnerReportedHealthState? PartnerReportedThreatState { get; set; }
        /// <summary>Phone number of the device. This property is read-only.</summary>
        public string PhoneNumber { get; set; }
        /// <summary>Total Memory in Bytes. This property is read-only.</summary>
        public long? PhysicalMemoryInBytes { get; set; }
        /// <summary>Reports the DateTime the preferMdmOverGroupPolicy setting was set.  When set, the Intune MDM settings will override Group Policy settings if there is a conflict. Read Only. This property is read-only.</summary>
        public DateTimeOffset? PreferMdmOverGroupPolicyAppliedDateTime { get; set; }
        /// <summary>Processor architecture. This property is read-only. Possible values are: unknown, x86, x64, arm, arM64.</summary>
        public ManagedDeviceArchitecture? ProcessorArchitecture { get; set; }
        /// <summary>An error string that identifies issues when creating Remote Assistance session objects. This property is read-only.</summary>
        public string RemoteAssistanceSessionErrorDetails { get; set; }
        /// <summary>Url that allows a Remote Assistance session to be established with the device. This property is read-only.</summary>
        public string RemoteAssistanceSessionUrl { get; set; }
        /// <summary>Reports if the managed iOS device is user approval enrollment. This property is read-only.</summary>
        public bool? RequireUserEnrollmentApproval { get; set; }
        /// <summary>Indicates the time after when a device will be auto retired because of scheduled action. This property is read-only.</summary>
        public DateTimeOffset? RetireAfterDateTime { get; set; }
        /// <summary>List of Scope Tag IDs for this Device instance.</summary>
        public List<string> RoleScopeTagIds { get; set; }
        /// <summary>Security baseline states for this device.</summary>
        public List<SecurityBaselineState> SecurityBaselineStates { get; set; }
        /// <summary>SerialNumber. This property is read-only.</summary>
        public string SerialNumber { get; set; }
        /// <summary>Device sku family</summary>
        public string SkuFamily { get; set; }
        /// <summary>Device sku number, see also: GetProductInfo function. Valid values 0 to 2147483647. This property is read-only.</summary>
        public int? SkuNumber { get; set; }
        /// <summary>Specification version. This property is read-only.</summary>
        public string SpecificationVersion { get; set; }
        /// <summary>Subscriber Carrier. This property is read-only.</summary>
        public string SubscriberCarrier { get; set; }
        /// <summary>Total Storage in Bytes. This property is read-only.</summary>
        public long? TotalStorageSpaceInBytes { get; set; }
        /// <summary>Unique Device Identifier for iOS and macOS devices. This property is read-only.</summary>
        public string Udid { get; set; }
        /// <summary>User display name. This property is read-only.</summary>
        public string UserDisplayName { get; set; }
        /// <summary>Unique Identifier for the user associated with the device. This property is read-only.</summary>
        public string UserId { get; set; }
        /// <summary>Device user principal name. This property is read-only.</summary>
        public string UserPrincipalName { get; set; }
        /// <summary>The primary users associated with the managed device.</summary>
        public List<User> Users { get; set; }
        /// <summary>Indicates the last logged on users of a device. This property is read-only.</summary>
        public List<LoggedOnUser> UsersLoggedOn { get; set; }
        /// <summary>Wi-Fi MAC. This property is read-only.</summary>
        public string WiFiMacAddress { get; set; }
        /// <summary>Count of active malware for this windows device. This property is read-only.</summary>
        public int? WindowsActiveMalwareCount { get; set; }
        /// <summary>The device protection status. This property is read-only.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.WindowsProtectionState WindowsProtectionState { get; set; }
        /// <summary>Count of remediated malware for this windows device. This property is read-only.</summary>
        public int? WindowsRemediatedMalwareCount { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ManagedDevice CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ManagedDevice();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"aadRegistered", (o,n) => { (o as ManagedDevice).AadRegistered = n.GetBoolValue(); } },
                {"activationLockBypassCode", (o,n) => { (o as ManagedDevice).ActivationLockBypassCode = n.GetStringValue(); } },
                {"androidSecurityPatchLevel", (o,n) => { (o as ManagedDevice).AndroidSecurityPatchLevel = n.GetStringValue(); } },
                {"assignmentFilterEvaluationStatusDetails", (o,n) => { (o as ManagedDevice).AssignmentFilterEvaluationStatusDetails = n.GetCollectionOfObjectValues<MicrosoftGraphSdk.Models.Microsoft.Graph.AssignmentFilterEvaluationStatusDetails>(MicrosoftGraphSdk.Models.Microsoft.Graph.AssignmentFilterEvaluationStatusDetails.CreateFromDiscriminatorValue).ToList(); } },
                {"autopilotEnrolled", (o,n) => { (o as ManagedDevice).AutopilotEnrolled = n.GetBoolValue(); } },
                {"azureActiveDirectoryDeviceId", (o,n) => { (o as ManagedDevice).AzureActiveDirectoryDeviceId = n.GetStringValue(); } },
                {"azureADDeviceId", (o,n) => { (o as ManagedDevice).AzureADDeviceId = n.GetStringValue(); } },
                {"azureADRegistered", (o,n) => { (o as ManagedDevice).AzureADRegistered = n.GetBoolValue(); } },
                {"chassisType", (o,n) => { (o as ManagedDevice).ChassisType = n.GetEnumValue<ChassisType>(); } },
                {"chromeOSDeviceInfo", (o,n) => { (o as ManagedDevice).ChromeOSDeviceInfo = n.GetCollectionOfObjectValues<ChromeOSDeviceProperty>(ChromeOSDeviceProperty.CreateFromDiscriminatorValue).ToList(); } },
                {"cloudPcRemoteActionResults", (o,n) => { (o as ManagedDevice).CloudPcRemoteActionResults = n.GetCollectionOfObjectValues<CloudPcRemoteActionResult>(CloudPcRemoteActionResult.CreateFromDiscriminatorValue).ToList(); } },
                {"complianceGracePeriodExpirationDateTime", (o,n) => { (o as ManagedDevice).ComplianceGracePeriodExpirationDateTime = n.GetDateTimeOffsetValue(); } },
                {"complianceState", (o,n) => { (o as ManagedDevice).ComplianceState = n.GetEnumValue<ComplianceState>(); } },
                {"configurationManagerClientEnabledFeatures", (o,n) => { (o as ManagedDevice).ConfigurationManagerClientEnabledFeatures = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.ConfigurationManagerClientEnabledFeatures>(MicrosoftGraphSdk.Models.Microsoft.Graph.ConfigurationManagerClientEnabledFeatures.CreateFromDiscriminatorValue); } },
                {"configurationManagerClientHealthState", (o,n) => { (o as ManagedDevice).ConfigurationManagerClientHealthState = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.ConfigurationManagerClientHealthState>(MicrosoftGraphSdk.Models.Microsoft.Graph.ConfigurationManagerClientHealthState.CreateFromDiscriminatorValue); } },
                {"configurationManagerClientInformation", (o,n) => { (o as ManagedDevice).ConfigurationManagerClientInformation = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.ConfigurationManagerClientInformation>(MicrosoftGraphSdk.Models.Microsoft.Graph.ConfigurationManagerClientInformation.CreateFromDiscriminatorValue); } },
                {"detectedApps", (o,n) => { (o as ManagedDevice).DetectedApps = n.GetCollectionOfObjectValues<DetectedApp>(DetectedApp.CreateFromDiscriminatorValue).ToList(); } },
                {"deviceActionResults", (o,n) => { (o as ManagedDevice).DeviceActionResults = n.GetCollectionOfObjectValues<DeviceActionResult>(DeviceActionResult.CreateFromDiscriminatorValue).ToList(); } },
                {"deviceCategory", (o,n) => { (o as ManagedDevice).DeviceCategory = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.DeviceCategory>(MicrosoftGraphSdk.Models.Microsoft.Graph.DeviceCategory.CreateFromDiscriminatorValue); } },
                {"deviceCategoryDisplayName", (o,n) => { (o as ManagedDevice).DeviceCategoryDisplayName = n.GetStringValue(); } },
                {"deviceCompliancePolicyStates", (o,n) => { (o as ManagedDevice).DeviceCompliancePolicyStates = n.GetCollectionOfObjectValues<DeviceCompliancePolicyState>(DeviceCompliancePolicyState.CreateFromDiscriminatorValue).ToList(); } },
                {"deviceConfigurationStates", (o,n) => { (o as ManagedDevice).DeviceConfigurationStates = n.GetCollectionOfObjectValues<DeviceConfigurationState>(DeviceConfigurationState.CreateFromDiscriminatorValue).ToList(); } },
                {"deviceEnrollmentType", (o,n) => { (o as ManagedDevice).DeviceEnrollmentType = n.GetEnumValue<DeviceEnrollmentType>(); } },
                {"deviceHealthAttestationState", (o,n) => { (o as ManagedDevice).DeviceHealthAttestationState = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.DeviceHealthAttestationState>(MicrosoftGraphSdk.Models.Microsoft.Graph.DeviceHealthAttestationState.CreateFromDiscriminatorValue); } },
                {"deviceName", (o,n) => { (o as ManagedDevice).DeviceName = n.GetStringValue(); } },
                {"deviceRegistrationState", (o,n) => { (o as ManagedDevice).DeviceRegistrationState = n.GetEnumValue<DeviceRegistrationState>(); } },
                {"deviceType", (o,n) => { (o as ManagedDevice).DeviceType = n.GetEnumValue<DeviceType>(); } },
                {"easActivated", (o,n) => { (o as ManagedDevice).EasActivated = n.GetBoolValue(); } },
                {"easActivationDateTime", (o,n) => { (o as ManagedDevice).EasActivationDateTime = n.GetDateTimeOffsetValue(); } },
                {"easDeviceId", (o,n) => { (o as ManagedDevice).EasDeviceId = n.GetStringValue(); } },
                {"emailAddress", (o,n) => { (o as ManagedDevice).EmailAddress = n.GetStringValue(); } },
                {"enrolledDateTime", (o,n) => { (o as ManagedDevice).EnrolledDateTime = n.GetDateTimeOffsetValue(); } },
                {"enrollmentProfileName", (o,n) => { (o as ManagedDevice).EnrollmentProfileName = n.GetStringValue(); } },
                {"ethernetMacAddress", (o,n) => { (o as ManagedDevice).EthernetMacAddress = n.GetStringValue(); } },
                {"exchangeAccessState", (o,n) => { (o as ManagedDevice).ExchangeAccessState = n.GetEnumValue<DeviceManagementExchangeAccessState>(); } },
                {"exchangeAccessStateReason", (o,n) => { (o as ManagedDevice).ExchangeAccessStateReason = n.GetEnumValue<DeviceManagementExchangeAccessStateReason>(); } },
                {"exchangeLastSuccessfulSyncDateTime", (o,n) => { (o as ManagedDevice).ExchangeLastSuccessfulSyncDateTime = n.GetDateTimeOffsetValue(); } },
                {"freeStorageSpaceInBytes", (o,n) => { (o as ManagedDevice).FreeStorageSpaceInBytes = n.GetLongValue(); } },
                {"hardwareInformation", (o,n) => { (o as ManagedDevice).HardwareInformation = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.HardwareInformation>(MicrosoftGraphSdk.Models.Microsoft.Graph.HardwareInformation.CreateFromDiscriminatorValue); } },
                {"iccid", (o,n) => { (o as ManagedDevice).Iccid = n.GetStringValue(); } },
                {"imei", (o,n) => { (o as ManagedDevice).Imei = n.GetStringValue(); } },
                {"isEncrypted", (o,n) => { (o as ManagedDevice).IsEncrypted = n.GetBoolValue(); } },
                {"isSupervised", (o,n) => { (o as ManagedDevice).IsSupervised = n.GetBoolValue(); } },
                {"jailBroken", (o,n) => { (o as ManagedDevice).JailBroken = n.GetStringValue(); } },
                {"joinType", (o,n) => { (o as ManagedDevice).JoinType = n.GetEnumValue<JoinType>(); } },
                {"lastSyncDateTime", (o,n) => { (o as ManagedDevice).LastSyncDateTime = n.GetDateTimeOffsetValue(); } },
                {"logCollectionRequests", (o,n) => { (o as ManagedDevice).LogCollectionRequests = n.GetCollectionOfObjectValues<DeviceLogCollectionResponse>(DeviceLogCollectionResponse.CreateFromDiscriminatorValue).ToList(); } },
                {"lostModeState", (o,n) => { (o as ManagedDevice).LostModeState = n.GetEnumValue<LostModeState>(); } },
                {"managedDeviceMobileAppConfigurationStates", (o,n) => { (o as ManagedDevice).ManagedDeviceMobileAppConfigurationStates = n.GetCollectionOfObjectValues<ManagedDeviceMobileAppConfigurationState>(ManagedDeviceMobileAppConfigurationState.CreateFromDiscriminatorValue).ToList(); } },
                {"managedDeviceName", (o,n) => { (o as ManagedDevice).ManagedDeviceName = n.GetStringValue(); } },
                {"managedDeviceOwnerType", (o,n) => { (o as ManagedDevice).ManagedDeviceOwnerType = n.GetEnumValue<ManagedDeviceOwnerType>(); } },
                {"managementAgent", (o,n) => { (o as ManagedDevice).ManagementAgent = n.GetEnumValue<ManagementAgentType>(); } },
                {"managementCertificateExpirationDate", (o,n) => { (o as ManagedDevice).ManagementCertificateExpirationDate = n.GetDateTimeOffsetValue(); } },
                {"managementFeatures", (o,n) => { (o as ManagedDevice).ManagementFeatures = n.GetEnumValue<ManagedDeviceManagementFeatures>(); } },
                {"managementState", (o,n) => { (o as ManagedDevice).ManagementState = n.GetEnumValue<ManagementState>(); } },
                {"manufacturer", (o,n) => { (o as ManagedDevice).Manufacturer = n.GetStringValue(); } },
                {"meid", (o,n) => { (o as ManagedDevice).Meid = n.GetStringValue(); } },
                {"model", (o,n) => { (o as ManagedDevice).Model = n.GetStringValue(); } },
                {"notes", (o,n) => { (o as ManagedDevice).Notes = n.GetStringValue(); } },
                {"operatingSystem", (o,n) => { (o as ManagedDevice).OperatingSystem = n.GetStringValue(); } },
                {"osVersion", (o,n) => { (o as ManagedDevice).OsVersion = n.GetStringValue(); } },
                {"ownerType", (o,n) => { (o as ManagedDevice).OwnerType = n.GetEnumValue<OwnerType>(); } },
                {"partnerReportedThreatState", (o,n) => { (o as ManagedDevice).PartnerReportedThreatState = n.GetEnumValue<ManagedDevicePartnerReportedHealthState>(); } },
                {"phoneNumber", (o,n) => { (o as ManagedDevice).PhoneNumber = n.GetStringValue(); } },
                {"physicalMemoryInBytes", (o,n) => { (o as ManagedDevice).PhysicalMemoryInBytes = n.GetLongValue(); } },
                {"preferMdmOverGroupPolicyAppliedDateTime", (o,n) => { (o as ManagedDevice).PreferMdmOverGroupPolicyAppliedDateTime = n.GetDateTimeOffsetValue(); } },
                {"processorArchitecture", (o,n) => { (o as ManagedDevice).ProcessorArchitecture = n.GetEnumValue<ManagedDeviceArchitecture>(); } },
                {"remoteAssistanceSessionErrorDetails", (o,n) => { (o as ManagedDevice).RemoteAssistanceSessionErrorDetails = n.GetStringValue(); } },
                {"remoteAssistanceSessionUrl", (o,n) => { (o as ManagedDevice).RemoteAssistanceSessionUrl = n.GetStringValue(); } },
                {"requireUserEnrollmentApproval", (o,n) => { (o as ManagedDevice).RequireUserEnrollmentApproval = n.GetBoolValue(); } },
                {"retireAfterDateTime", (o,n) => { (o as ManagedDevice).RetireAfterDateTime = n.GetDateTimeOffsetValue(); } },
                {"roleScopeTagIds", (o,n) => { (o as ManagedDevice).RoleScopeTagIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"securityBaselineStates", (o,n) => { (o as ManagedDevice).SecurityBaselineStates = n.GetCollectionOfObjectValues<SecurityBaselineState>(SecurityBaselineState.CreateFromDiscriminatorValue).ToList(); } },
                {"serialNumber", (o,n) => { (o as ManagedDevice).SerialNumber = n.GetStringValue(); } },
                {"skuFamily", (o,n) => { (o as ManagedDevice).SkuFamily = n.GetStringValue(); } },
                {"skuNumber", (o,n) => { (o as ManagedDevice).SkuNumber = n.GetIntValue(); } },
                {"specificationVersion", (o,n) => { (o as ManagedDevice).SpecificationVersion = n.GetStringValue(); } },
                {"subscriberCarrier", (o,n) => { (o as ManagedDevice).SubscriberCarrier = n.GetStringValue(); } },
                {"totalStorageSpaceInBytes", (o,n) => { (o as ManagedDevice).TotalStorageSpaceInBytes = n.GetLongValue(); } },
                {"udid", (o,n) => { (o as ManagedDevice).Udid = n.GetStringValue(); } },
                {"userDisplayName", (o,n) => { (o as ManagedDevice).UserDisplayName = n.GetStringValue(); } },
                {"userId", (o,n) => { (o as ManagedDevice).UserId = n.GetStringValue(); } },
                {"userPrincipalName", (o,n) => { (o as ManagedDevice).UserPrincipalName = n.GetStringValue(); } },
                {"users", (o,n) => { (o as ManagedDevice).Users = n.GetCollectionOfObjectValues<User>(User.CreateFromDiscriminatorValue).ToList(); } },
                {"usersLoggedOn", (o,n) => { (o as ManagedDevice).UsersLoggedOn = n.GetCollectionOfObjectValues<LoggedOnUser>(LoggedOnUser.CreateFromDiscriminatorValue).ToList(); } },
                {"wiFiMacAddress", (o,n) => { (o as ManagedDevice).WiFiMacAddress = n.GetStringValue(); } },
                {"windowsActiveMalwareCount", (o,n) => { (o as ManagedDevice).WindowsActiveMalwareCount = n.GetIntValue(); } },
                {"windowsProtectionState", (o,n) => { (o as ManagedDevice).WindowsProtectionState = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.WindowsProtectionState>(MicrosoftGraphSdk.Models.Microsoft.Graph.WindowsProtectionState.CreateFromDiscriminatorValue); } },
                {"windowsRemediatedMalwareCount", (o,n) => { (o as ManagedDevice).WindowsRemediatedMalwareCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("aadRegistered", AadRegistered);
            writer.WriteStringValue("activationLockBypassCode", ActivationLockBypassCode);
            writer.WriteStringValue("androidSecurityPatchLevel", AndroidSecurityPatchLevel);
            writer.WriteCollectionOfObjectValues<MicrosoftGraphSdk.Models.Microsoft.Graph.AssignmentFilterEvaluationStatusDetails>("assignmentFilterEvaluationStatusDetails", AssignmentFilterEvaluationStatusDetails);
            writer.WriteBoolValue("autopilotEnrolled", AutopilotEnrolled);
            writer.WriteStringValue("azureActiveDirectoryDeviceId", AzureActiveDirectoryDeviceId);
            writer.WriteStringValue("azureADDeviceId", AzureADDeviceId);
            writer.WriteBoolValue("azureADRegistered", AzureADRegistered);
            writer.WriteEnumValue<ChassisType>("chassisType", ChassisType);
            writer.WriteCollectionOfObjectValues<ChromeOSDeviceProperty>("chromeOSDeviceInfo", ChromeOSDeviceInfo);
            writer.WriteCollectionOfObjectValues<CloudPcRemoteActionResult>("cloudPcRemoteActionResults", CloudPcRemoteActionResults);
            writer.WriteDateTimeOffsetValue("complianceGracePeriodExpirationDateTime", ComplianceGracePeriodExpirationDateTime);
            writer.WriteEnumValue<ComplianceState>("complianceState", ComplianceState);
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.ConfigurationManagerClientEnabledFeatures>("configurationManagerClientEnabledFeatures", ConfigurationManagerClientEnabledFeatures);
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.ConfigurationManagerClientHealthState>("configurationManagerClientHealthState", ConfigurationManagerClientHealthState);
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.ConfigurationManagerClientInformation>("configurationManagerClientInformation", ConfigurationManagerClientInformation);
            writer.WriteCollectionOfObjectValues<DetectedApp>("detectedApps", DetectedApps);
            writer.WriteCollectionOfObjectValues<DeviceActionResult>("deviceActionResults", DeviceActionResults);
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.DeviceCategory>("deviceCategory", DeviceCategory);
            writer.WriteStringValue("deviceCategoryDisplayName", DeviceCategoryDisplayName);
            writer.WriteCollectionOfObjectValues<DeviceCompliancePolicyState>("deviceCompliancePolicyStates", DeviceCompliancePolicyStates);
            writer.WriteCollectionOfObjectValues<DeviceConfigurationState>("deviceConfigurationStates", DeviceConfigurationStates);
            writer.WriteEnumValue<DeviceEnrollmentType>("deviceEnrollmentType", DeviceEnrollmentType);
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.DeviceHealthAttestationState>("deviceHealthAttestationState", DeviceHealthAttestationState);
            writer.WriteStringValue("deviceName", DeviceName);
            writer.WriteEnumValue<DeviceRegistrationState>("deviceRegistrationState", DeviceRegistrationState);
            writer.WriteEnumValue<DeviceType>("deviceType", DeviceType);
            writer.WriteBoolValue("easActivated", EasActivated);
            writer.WriteDateTimeOffsetValue("easActivationDateTime", EasActivationDateTime);
            writer.WriteStringValue("easDeviceId", EasDeviceId);
            writer.WriteStringValue("emailAddress", EmailAddress);
            writer.WriteDateTimeOffsetValue("enrolledDateTime", EnrolledDateTime);
            writer.WriteStringValue("enrollmentProfileName", EnrollmentProfileName);
            writer.WriteStringValue("ethernetMacAddress", EthernetMacAddress);
            writer.WriteEnumValue<DeviceManagementExchangeAccessState>("exchangeAccessState", ExchangeAccessState);
            writer.WriteEnumValue<DeviceManagementExchangeAccessStateReason>("exchangeAccessStateReason", ExchangeAccessStateReason);
            writer.WriteDateTimeOffsetValue("exchangeLastSuccessfulSyncDateTime", ExchangeLastSuccessfulSyncDateTime);
            writer.WriteLongValue("freeStorageSpaceInBytes", FreeStorageSpaceInBytes);
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.HardwareInformation>("hardwareInformation", HardwareInformation);
            writer.WriteStringValue("iccid", Iccid);
            writer.WriteStringValue("imei", Imei);
            writer.WriteBoolValue("isEncrypted", IsEncrypted);
            writer.WriteBoolValue("isSupervised", IsSupervised);
            writer.WriteStringValue("jailBroken", JailBroken);
            writer.WriteEnumValue<JoinType>("joinType", JoinType);
            writer.WriteDateTimeOffsetValue("lastSyncDateTime", LastSyncDateTime);
            writer.WriteCollectionOfObjectValues<DeviceLogCollectionResponse>("logCollectionRequests", LogCollectionRequests);
            writer.WriteEnumValue<LostModeState>("lostModeState", LostModeState);
            writer.WriteCollectionOfObjectValues<ManagedDeviceMobileAppConfigurationState>("managedDeviceMobileAppConfigurationStates", ManagedDeviceMobileAppConfigurationStates);
            writer.WriteStringValue("managedDeviceName", ManagedDeviceName);
            writer.WriteEnumValue<ManagedDeviceOwnerType>("managedDeviceOwnerType", ManagedDeviceOwnerType);
            writer.WriteEnumValue<ManagementAgentType>("managementAgent", ManagementAgent);
            writer.WriteDateTimeOffsetValue("managementCertificateExpirationDate", ManagementCertificateExpirationDate);
            writer.WriteEnumValue<ManagedDeviceManagementFeatures>("managementFeatures", ManagementFeatures);
            writer.WriteEnumValue<ManagementState>("managementState", ManagementState);
            writer.WriteStringValue("manufacturer", Manufacturer);
            writer.WriteStringValue("meid", Meid);
            writer.WriteStringValue("model", Model);
            writer.WriteStringValue("notes", Notes);
            writer.WriteStringValue("operatingSystem", OperatingSystem);
            writer.WriteStringValue("osVersion", OsVersion);
            writer.WriteEnumValue<OwnerType>("ownerType", OwnerType);
            writer.WriteEnumValue<ManagedDevicePartnerReportedHealthState>("partnerReportedThreatState", PartnerReportedThreatState);
            writer.WriteStringValue("phoneNumber", PhoneNumber);
            writer.WriteLongValue("physicalMemoryInBytes", PhysicalMemoryInBytes);
            writer.WriteDateTimeOffsetValue("preferMdmOverGroupPolicyAppliedDateTime", PreferMdmOverGroupPolicyAppliedDateTime);
            writer.WriteEnumValue<ManagedDeviceArchitecture>("processorArchitecture", ProcessorArchitecture);
            writer.WriteStringValue("remoteAssistanceSessionErrorDetails", RemoteAssistanceSessionErrorDetails);
            writer.WriteStringValue("remoteAssistanceSessionUrl", RemoteAssistanceSessionUrl);
            writer.WriteBoolValue("requireUserEnrollmentApproval", RequireUserEnrollmentApproval);
            writer.WriteDateTimeOffsetValue("retireAfterDateTime", RetireAfterDateTime);
            writer.WriteCollectionOfPrimitiveValues<string>("roleScopeTagIds", RoleScopeTagIds);
            writer.WriteCollectionOfObjectValues<SecurityBaselineState>("securityBaselineStates", SecurityBaselineStates);
            writer.WriteStringValue("serialNumber", SerialNumber);
            writer.WriteStringValue("skuFamily", SkuFamily);
            writer.WriteIntValue("skuNumber", SkuNumber);
            writer.WriteStringValue("specificationVersion", SpecificationVersion);
            writer.WriteStringValue("subscriberCarrier", SubscriberCarrier);
            writer.WriteLongValue("totalStorageSpaceInBytes", TotalStorageSpaceInBytes);
            writer.WriteStringValue("udid", Udid);
            writer.WriteStringValue("userDisplayName", UserDisplayName);
            writer.WriteStringValue("userId", UserId);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
            writer.WriteCollectionOfObjectValues<User>("users", Users);
            writer.WriteCollectionOfObjectValues<LoggedOnUser>("usersLoggedOn", UsersLoggedOn);
            writer.WriteStringValue("wiFiMacAddress", WiFiMacAddress);
            writer.WriteIntValue("windowsActiveMalwareCount", WindowsActiveMalwareCount);
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.WindowsProtectionState>("windowsProtectionState", WindowsProtectionState);
            writer.WriteIntValue("windowsRemediatedMalwareCount", WindowsRemediatedMalwareCount);
        }
    }
}
