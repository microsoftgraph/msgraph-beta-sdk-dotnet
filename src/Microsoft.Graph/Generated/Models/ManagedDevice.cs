using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class ManagedDevice : Entity, IParsable {
        /// <summary>Whether the device is Azure Active Directory registered. This property is read-only.</summary>
        public bool? AadRegistered {
            get { return BackingStore?.Get<bool?>("aadRegistered"); }
            set { BackingStore?.Set("aadRegistered", value); }
        }
        /// <summary>Code that allows the Activation Lock on a device to be bypassed. This property is read-only.</summary>
        public string ActivationLockBypassCode {
            get { return BackingStore?.Get<string>("activationLockBypassCode"); }
            set { BackingStore?.Set("activationLockBypassCode", value); }
        }
        /// <summary>Android security patch level. This property is read-only.</summary>
        public string AndroidSecurityPatchLevel {
            get { return BackingStore?.Get<string>("androidSecurityPatchLevel"); }
            set { BackingStore?.Set("androidSecurityPatchLevel", value); }
        }
        /// <summary>Managed device mobile app configuration states for this device.</summary>
        public List<Microsoft.Graph.Beta.Models.AssignmentFilterEvaluationStatusDetails> AssignmentFilterEvaluationStatusDetails {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.AssignmentFilterEvaluationStatusDetails>>("assignmentFilterEvaluationStatusDetails"); }
            set { BackingStore?.Set("assignmentFilterEvaluationStatusDetails", value); }
        }
        /// <summary>Reports if the managed device is enrolled via auto-pilot. This property is read-only.</summary>
        public bool? AutopilotEnrolled {
            get { return BackingStore?.Get<bool?>("autopilotEnrolled"); }
            set { BackingStore?.Set("autopilotEnrolled", value); }
        }
        /// <summary>The unique identifier for the Azure Active Directory device. Read only. This property is read-only.</summary>
        public string AzureActiveDirectoryDeviceId {
            get { return BackingStore?.Get<string>("azureActiveDirectoryDeviceId"); }
            set { BackingStore?.Set("azureActiveDirectoryDeviceId", value); }
        }
        /// <summary>The unique identifier for the Azure Active Directory device. Read only. This property is read-only.</summary>
        public string AzureADDeviceId {
            get { return BackingStore?.Get<string>("azureADDeviceId"); }
            set { BackingStore?.Set("azureADDeviceId", value); }
        }
        /// <summary>Whether the device is Azure Active Directory registered. This property is read-only.</summary>
        public bool? AzureADRegistered {
            get { return BackingStore?.Get<bool?>("azureADRegistered"); }
            set { BackingStore?.Set("azureADRegistered", value); }
        }
        /// <summary>Reports if the managed device has an escrowed Bootstrap Token. This is only for macOS devices. To get, include BootstrapTokenEscrowed in the select clause and query with a device id. If FALSE, no bootstrap token is escrowed. If TRUE, the device has escrowed a bootstrap token with Intune. This property is read-only.</summary>
        public bool? BootstrapTokenEscrowed {
            get { return BackingStore?.Get<bool?>("bootstrapTokenEscrowed"); }
            set { BackingStore?.Set("bootstrapTokenEscrowed", value); }
        }
        /// <summary>Chassis type.</summary>
        public Microsoft.Graph.Beta.Models.ChassisType? ChassisType {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ChassisType?>("chassisType"); }
            set { BackingStore?.Set("chassisType", value); }
        }
        /// <summary>List of properties of the ChromeOS Device.</summary>
        public List<ChromeOSDeviceProperty> ChromeOSDeviceInfo {
            get { return BackingStore?.Get<List<ChromeOSDeviceProperty>>("chromeOSDeviceInfo"); }
            set { BackingStore?.Set("chromeOSDeviceInfo", value); }
        }
        /// <summary>The cloudPcRemoteActionResults property</summary>
        public List<CloudPcRemoteActionResult> CloudPcRemoteActionResults {
            get { return BackingStore?.Get<List<CloudPcRemoteActionResult>>("cloudPcRemoteActionResults"); }
            set { BackingStore?.Set("cloudPcRemoteActionResults", value); }
        }
        /// <summary>The DateTime when device compliance grace period expires. This property is read-only.</summary>
        public DateTimeOffset? ComplianceGracePeriodExpirationDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("complianceGracePeriodExpirationDateTime"); }
            set { BackingStore?.Set("complianceGracePeriodExpirationDateTime", value); }
        }
        /// <summary>Compliance state.</summary>
        public Microsoft.Graph.Beta.Models.ComplianceState? ComplianceState {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ComplianceState?>("complianceState"); }
            set { BackingStore?.Set("complianceState", value); }
        }
        /// <summary>ConfigrMgr client enabled features. This property is read-only.</summary>
        public Microsoft.Graph.Beta.Models.ConfigurationManagerClientEnabledFeatures ConfigurationManagerClientEnabledFeatures {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ConfigurationManagerClientEnabledFeatures>("configurationManagerClientEnabledFeatures"); }
            set { BackingStore?.Set("configurationManagerClientEnabledFeatures", value); }
        }
        /// <summary>Configuration manager client health state, valid only for devices managed by MDM/ConfigMgr Agent</summary>
        public Microsoft.Graph.Beta.Models.ConfigurationManagerClientHealthState ConfigurationManagerClientHealthState {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ConfigurationManagerClientHealthState>("configurationManagerClientHealthState"); }
            set { BackingStore?.Set("configurationManagerClientHealthState", value); }
        }
        /// <summary>Configuration manager client information, valid only for devices managed, duel-managed or tri-managed by ConfigMgr Agent</summary>
        public Microsoft.Graph.Beta.Models.ConfigurationManagerClientInformation ConfigurationManagerClientInformation {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ConfigurationManagerClientInformation>("configurationManagerClientInformation"); }
            set { BackingStore?.Set("configurationManagerClientInformation", value); }
        }
        /// <summary>All applications currently installed on the device</summary>
        public List<DetectedApp> DetectedApps {
            get { return BackingStore?.Get<List<DetectedApp>>("detectedApps"); }
            set { BackingStore?.Set("detectedApps", value); }
        }
        /// <summary>List of ComplexType deviceActionResult objects. This property is read-only.</summary>
        public List<DeviceActionResult> DeviceActionResults {
            get { return BackingStore?.Get<List<DeviceActionResult>>("deviceActionResults"); }
            set { BackingStore?.Set("deviceActionResults", value); }
        }
        /// <summary>Device category</summary>
        public Microsoft.Graph.Beta.Models.DeviceCategory DeviceCategory {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DeviceCategory>("deviceCategory"); }
            set { BackingStore?.Set("deviceCategory", value); }
        }
        /// <summary>Device category display name. This property is read-only.</summary>
        public string DeviceCategoryDisplayName {
            get { return BackingStore?.Get<string>("deviceCategoryDisplayName"); }
            set { BackingStore?.Set("deviceCategoryDisplayName", value); }
        }
        /// <summary>Device compliance policy states for this device.</summary>
        public List<DeviceCompliancePolicyState> DeviceCompliancePolicyStates {
            get { return BackingStore?.Get<List<DeviceCompliancePolicyState>>("deviceCompliancePolicyStates"); }
            set { BackingStore?.Set("deviceCompliancePolicyStates", value); }
        }
        /// <summary>Device configuration states for this device.</summary>
        public List<DeviceConfigurationState> DeviceConfigurationStates {
            get { return BackingStore?.Get<List<DeviceConfigurationState>>("deviceConfigurationStates"); }
            set { BackingStore?.Set("deviceConfigurationStates", value); }
        }
        /// <summary>Possible ways of adding a mobile device to management.</summary>
        public Microsoft.Graph.Beta.Models.DeviceEnrollmentType? DeviceEnrollmentType {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DeviceEnrollmentType?>("deviceEnrollmentType"); }
            set { BackingStore?.Set("deviceEnrollmentType", value); }
        }
        /// <summary>Indicates whether the device is DFCI managed. When TRUE the device is DFCI managed. When FALSE, the device is not DFCI managed. The default value is FALSE.</summary>
        public bool? DeviceFirmwareConfigurationInterfaceManaged {
            get { return BackingStore?.Get<bool?>("deviceFirmwareConfigurationInterfaceManaged"); }
            set { BackingStore?.Set("deviceFirmwareConfigurationInterfaceManaged", value); }
        }
        /// <summary>The device health attestation state. This property is read-only.</summary>
        public Microsoft.Graph.Beta.Models.DeviceHealthAttestationState DeviceHealthAttestationState {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DeviceHealthAttestationState>("deviceHealthAttestationState"); }
            set { BackingStore?.Set("deviceHealthAttestationState", value); }
        }
        /// <summary>Name of the device. This property is read-only.</summary>
        public string DeviceName {
            get { return BackingStore?.Get<string>("deviceName"); }
            set { BackingStore?.Set("deviceName", value); }
        }
        /// <summary>Device registration status.</summary>
        public Microsoft.Graph.Beta.Models.DeviceRegistrationState? DeviceRegistrationState {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DeviceRegistrationState?>("deviceRegistrationState"); }
            set { BackingStore?.Set("deviceRegistrationState", value); }
        }
        /// <summary>Device type.</summary>
        public Microsoft.Graph.Beta.Models.DeviceType? DeviceType {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DeviceType?>("deviceType"); }
            set { BackingStore?.Set("deviceType", value); }
        }
        /// <summary>Whether the device is Exchange ActiveSync activated. This property is read-only.</summary>
        public bool? EasActivated {
            get { return BackingStore?.Get<bool?>("easActivated"); }
            set { BackingStore?.Set("easActivated", value); }
        }
        /// <summary>Exchange ActivationSync activation time of the device. This property is read-only.</summary>
        public DateTimeOffset? EasActivationDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("easActivationDateTime"); }
            set { BackingStore?.Set("easActivationDateTime", value); }
        }
        /// <summary>Exchange ActiveSync Id of the device. This property is read-only.</summary>
        public string EasDeviceId {
            get { return BackingStore?.Get<string>("easDeviceId"); }
            set { BackingStore?.Set("easDeviceId", value); }
        }
        /// <summary>Email(s) for the user associated with the device. This property is read-only.</summary>
        public string EmailAddress {
            get { return BackingStore?.Get<string>("emailAddress"); }
            set { BackingStore?.Set("emailAddress", value); }
        }
        /// <summary>Enrollment time of the device. This property is read-only.</summary>
        public DateTimeOffset? EnrolledDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("enrolledDateTime"); }
            set { BackingStore?.Set("enrolledDateTime", value); }
        }
        /// <summary>Name of the enrollment profile assigned to the device. Default value is empty string, indicating no enrollment profile was assgined. This property is read-only.</summary>
        public string EnrollmentProfileName {
            get { return BackingStore?.Get<string>("enrollmentProfileName"); }
            set { BackingStore?.Set("enrollmentProfileName", value); }
        }
        /// <summary>Ethernet MAC. This property is read-only.</summary>
        public string EthernetMacAddress {
            get { return BackingStore?.Get<string>("ethernetMacAddress"); }
            set { BackingStore?.Set("ethernetMacAddress", value); }
        }
        /// <summary>Device Exchange Access State.</summary>
        public DeviceManagementExchangeAccessState? ExchangeAccessState {
            get { return BackingStore?.Get<DeviceManagementExchangeAccessState?>("exchangeAccessState"); }
            set { BackingStore?.Set("exchangeAccessState", value); }
        }
        /// <summary>Device Exchange Access State Reason.</summary>
        public DeviceManagementExchangeAccessStateReason? ExchangeAccessStateReason {
            get { return BackingStore?.Get<DeviceManagementExchangeAccessStateReason?>("exchangeAccessStateReason"); }
            set { BackingStore?.Set("exchangeAccessStateReason", value); }
        }
        /// <summary>Last time the device contacted Exchange. This property is read-only.</summary>
        public DateTimeOffset? ExchangeLastSuccessfulSyncDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("exchangeLastSuccessfulSyncDateTime"); }
            set { BackingStore?.Set("exchangeLastSuccessfulSyncDateTime", value); }
        }
        /// <summary>Free Storage in Bytes. This property is read-only.</summary>
        public long? FreeStorageSpaceInBytes {
            get { return BackingStore?.Get<long?>("freeStorageSpaceInBytes"); }
            set { BackingStore?.Set("freeStorageSpaceInBytes", value); }
        }
        /// <summary>The hardward details for the device.  Includes information such as storage space, manufacturer, serial number, etc. This property is read-only.</summary>
        public Microsoft.Graph.Beta.Models.HardwareInformation HardwareInformation {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.HardwareInformation>("hardwareInformation"); }
            set { BackingStore?.Set("hardwareInformation", value); }
        }
        /// <summary>Integrated Circuit Card Identifier, it is A SIM card&apos;s unique identification number. This property is read-only.</summary>
        public string Iccid {
            get { return BackingStore?.Get<string>("iccid"); }
            set { BackingStore?.Set("iccid", value); }
        }
        /// <summary>IMEI. This property is read-only.</summary>
        public string Imei {
            get { return BackingStore?.Get<string>("imei"); }
            set { BackingStore?.Set("imei", value); }
        }
        /// <summary>Device encryption status. This property is read-only.</summary>
        public bool? IsEncrypted {
            get { return BackingStore?.Get<bool?>("isEncrypted"); }
            set { BackingStore?.Set("isEncrypted", value); }
        }
        /// <summary>Device supervised status. This property is read-only.</summary>
        public bool? IsSupervised {
            get { return BackingStore?.Get<bool?>("isSupervised"); }
            set { BackingStore?.Set("isSupervised", value); }
        }
        /// <summary>whether the device is jail broken or rooted. This property is read-only.</summary>
        public string JailBroken {
            get { return BackingStore?.Get<string>("jailBroken"); }
            set { BackingStore?.Set("jailBroken", value); }
        }
        /// <summary>Device enrollment join type.</summary>
        public Microsoft.Graph.Beta.Models.JoinType? JoinType {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.JoinType?>("joinType"); }
            set { BackingStore?.Set("joinType", value); }
        }
        /// <summary>The date and time that the device last completed a successful sync with Intune. This property is read-only.</summary>
        public DateTimeOffset? LastSyncDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastSyncDateTime"); }
            set { BackingStore?.Set("lastSyncDateTime", value); }
        }
        /// <summary>List of log collection requests</summary>
        public List<DeviceLogCollectionResponse> LogCollectionRequests {
            get { return BackingStore?.Get<List<DeviceLogCollectionResponse>>("logCollectionRequests"); }
            set { BackingStore?.Set("logCollectionRequests", value); }
        }
        /// <summary>State of lost mode, indicating if lost mode is enabled or disabled</summary>
        public Microsoft.Graph.Beta.Models.LostModeState? LostModeState {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.LostModeState?>("lostModeState"); }
            set { BackingStore?.Set("lostModeState", value); }
        }
        /// <summary>Managed device mobile app configuration states for this device.</summary>
        public List<ManagedDeviceMobileAppConfigurationState> ManagedDeviceMobileAppConfigurationStates {
            get { return BackingStore?.Get<List<ManagedDeviceMobileAppConfigurationState>>("managedDeviceMobileAppConfigurationStates"); }
            set { BackingStore?.Set("managedDeviceMobileAppConfigurationStates", value); }
        }
        /// <summary>Automatically generated name to identify a device. Can be overwritten to a user friendly name.</summary>
        public string ManagedDeviceName {
            get { return BackingStore?.Get<string>("managedDeviceName"); }
            set { BackingStore?.Set("managedDeviceName", value); }
        }
        /// <summary>Owner type of device.</summary>
        public Microsoft.Graph.Beta.Models.ManagedDeviceOwnerType? ManagedDeviceOwnerType {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ManagedDeviceOwnerType?>("managedDeviceOwnerType"); }
            set { BackingStore?.Set("managedDeviceOwnerType", value); }
        }
        /// <summary>Management agent type.</summary>
        public ManagementAgentType? ManagementAgent {
            get { return BackingStore?.Get<ManagementAgentType?>("managementAgent"); }
            set { BackingStore?.Set("managementAgent", value); }
        }
        /// <summary>Reports device management certificate expiration date. This property is read-only.</summary>
        public DateTimeOffset? ManagementCertificateExpirationDate {
            get { return BackingStore?.Get<DateTimeOffset?>("managementCertificateExpirationDate"); }
            set { BackingStore?.Set("managementCertificateExpirationDate", value); }
        }
        /// <summary>Device management features.</summary>
        public ManagedDeviceManagementFeatures? ManagementFeatures {
            get { return BackingStore?.Get<ManagedDeviceManagementFeatures?>("managementFeatures"); }
            set { BackingStore?.Set("managementFeatures", value); }
        }
        /// <summary>Management state of device in Microsoft Intune.</summary>
        public Microsoft.Graph.Beta.Models.ManagementState? ManagementState {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ManagementState?>("managementState"); }
            set { BackingStore?.Set("managementState", value); }
        }
        /// <summary>Manufacturer of the device. This property is read-only.</summary>
        public string Manufacturer {
            get { return BackingStore?.Get<string>("manufacturer"); }
            set { BackingStore?.Set("manufacturer", value); }
        }
        /// <summary>MEID. This property is read-only.</summary>
        public string Meid {
            get { return BackingStore?.Get<string>("meid"); }
            set { BackingStore?.Set("meid", value); }
        }
        /// <summary>Model of the device. This property is read-only.</summary>
        public string Model {
            get { return BackingStore?.Get<string>("model"); }
            set { BackingStore?.Set("model", value); }
        }
        /// <summary>Notes on the device created by IT Admin</summary>
        public string Notes {
            get { return BackingStore?.Get<string>("notes"); }
            set { BackingStore?.Set("notes", value); }
        }
        /// <summary>Operating system of the device. Windows, iOS, etc. This property is read-only.</summary>
        public string OperatingSystem {
            get { return BackingStore?.Get<string>("operatingSystem"); }
            set { BackingStore?.Set("operatingSystem", value); }
        }
        /// <summary>Operating system version of the device. This property is read-only.</summary>
        public string OsVersion {
            get { return BackingStore?.Get<string>("osVersion"); }
            set { BackingStore?.Set("osVersion", value); }
        }
        /// <summary>Owner type of device.</summary>
        public Microsoft.Graph.Beta.Models.OwnerType? OwnerType {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.OwnerType?>("ownerType"); }
            set { BackingStore?.Set("ownerType", value); }
        }
        /// <summary>Available health states for the Device Health API</summary>
        public ManagedDevicePartnerReportedHealthState? PartnerReportedThreatState {
            get { return BackingStore?.Get<ManagedDevicePartnerReportedHealthState?>("partnerReportedThreatState"); }
            set { BackingStore?.Set("partnerReportedThreatState", value); }
        }
        /// <summary>Phone number of the device. This property is read-only.</summary>
        public string PhoneNumber {
            get { return BackingStore?.Get<string>("phoneNumber"); }
            set { BackingStore?.Set("phoneNumber", value); }
        }
        /// <summary>Total Memory in Bytes. This property is read-only.</summary>
        public long? PhysicalMemoryInBytes {
            get { return BackingStore?.Get<long?>("physicalMemoryInBytes"); }
            set { BackingStore?.Set("physicalMemoryInBytes", value); }
        }
        /// <summary>Reports the DateTime the preferMdmOverGroupPolicy setting was set.  When set, the Intune MDM settings will override Group Policy settings if there is a conflict. Read Only. This property is read-only.</summary>
        public DateTimeOffset? PreferMdmOverGroupPolicyAppliedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("preferMdmOverGroupPolicyAppliedDateTime"); }
            set { BackingStore?.Set("preferMdmOverGroupPolicyAppliedDateTime", value); }
        }
        /// <summary>Processor architecture</summary>
        public ManagedDeviceArchitecture? ProcessorArchitecture {
            get { return BackingStore?.Get<ManagedDeviceArchitecture?>("processorArchitecture"); }
            set { BackingStore?.Set("processorArchitecture", value); }
        }
        /// <summary>An error string that identifies issues when creating Remote Assistance session objects. This property is read-only.</summary>
        public string RemoteAssistanceSessionErrorDetails {
            get { return BackingStore?.Get<string>("remoteAssistanceSessionErrorDetails"); }
            set { BackingStore?.Set("remoteAssistanceSessionErrorDetails", value); }
        }
        /// <summary>Url that allows a Remote Assistance session to be established with the device. This property is read-only.</summary>
        public string RemoteAssistanceSessionUrl {
            get { return BackingStore?.Get<string>("remoteAssistanceSessionUrl"); }
            set { BackingStore?.Set("remoteAssistanceSessionUrl", value); }
        }
        /// <summary>Reports if the managed iOS device is user approval enrollment. This property is read-only.</summary>
        public bool? RequireUserEnrollmentApproval {
            get { return BackingStore?.Get<bool?>("requireUserEnrollmentApproval"); }
            set { BackingStore?.Set("requireUserEnrollmentApproval", value); }
        }
        /// <summary>Indicates the time after when a device will be auto retired because of scheduled action. This property is read-only.</summary>
        public DateTimeOffset? RetireAfterDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("retireAfterDateTime"); }
            set { BackingStore?.Set("retireAfterDateTime", value); }
        }
        /// <summary>List of Scope Tag IDs for this Device instance.</summary>
        public List<string> RoleScopeTagIds {
            get { return BackingStore?.Get<List<string>>("roleScopeTagIds"); }
            set { BackingStore?.Set("roleScopeTagIds", value); }
        }
        /// <summary>Security baseline states for this device.</summary>
        public List<SecurityBaselineState> SecurityBaselineStates {
            get { return BackingStore?.Get<List<SecurityBaselineState>>("securityBaselineStates"); }
            set { BackingStore?.Set("securityBaselineStates", value); }
        }
        /// <summary>SerialNumber. This property is read-only.</summary>
        public string SerialNumber {
            get { return BackingStore?.Get<string>("serialNumber"); }
            set { BackingStore?.Set("serialNumber", value); }
        }
        /// <summary>Device sku family</summary>
        public string SkuFamily {
            get { return BackingStore?.Get<string>("skuFamily"); }
            set { BackingStore?.Set("skuFamily", value); }
        }
        /// <summary>Device sku number, see also: https://docs.microsoft.com/windows/win32/api/sysinfoapi/nf-sysinfoapi-getproductinfo. Valid values 0 to 2147483647. This property is read-only.</summary>
        public int? SkuNumber {
            get { return BackingStore?.Get<int?>("skuNumber"); }
            set { BackingStore?.Set("skuNumber", value); }
        }
        /// <summary>Specification version. This property is read-only.</summary>
        public string SpecificationVersion {
            get { return BackingStore?.Get<string>("specificationVersion"); }
            set { BackingStore?.Set("specificationVersion", value); }
        }
        /// <summary>Subscriber Carrier. This property is read-only.</summary>
        public string SubscriberCarrier {
            get { return BackingStore?.Get<string>("subscriberCarrier"); }
            set { BackingStore?.Set("subscriberCarrier", value); }
        }
        /// <summary>Total Storage in Bytes. This property is read-only.</summary>
        public long? TotalStorageSpaceInBytes {
            get { return BackingStore?.Get<long?>("totalStorageSpaceInBytes"); }
            set { BackingStore?.Set("totalStorageSpaceInBytes", value); }
        }
        /// <summary>Unique Device Identifier for iOS and macOS devices. This property is read-only.</summary>
        public string Udid {
            get { return BackingStore?.Get<string>("udid"); }
            set { BackingStore?.Set("udid", value); }
        }
        /// <summary>User display name. This property is read-only.</summary>
        public string UserDisplayName {
            get { return BackingStore?.Get<string>("userDisplayName"); }
            set { BackingStore?.Set("userDisplayName", value); }
        }
        /// <summary>Unique Identifier for the user associated with the device. This property is read-only.</summary>
        public string UserId {
            get { return BackingStore?.Get<string>("userId"); }
            set { BackingStore?.Set("userId", value); }
        }
        /// <summary>Device user principal name. This property is read-only.</summary>
        public string UserPrincipalName {
            get { return BackingStore?.Get<string>("userPrincipalName"); }
            set { BackingStore?.Set("userPrincipalName", value); }
        }
        /// <summary>The primary users associated with the managed device.</summary>
        public List<User> Users {
            get { return BackingStore?.Get<List<User>>("users"); }
            set { BackingStore?.Set("users", value); }
        }
        /// <summary>Indicates the last logged on users of a device. This property is read-only.</summary>
        public List<LoggedOnUser> UsersLoggedOn {
            get { return BackingStore?.Get<List<LoggedOnUser>>("usersLoggedOn"); }
            set { BackingStore?.Set("usersLoggedOn", value); }
        }
        /// <summary>Wi-Fi MAC. This property is read-only.</summary>
        public string WiFiMacAddress {
            get { return BackingStore?.Get<string>("wiFiMacAddress"); }
            set { BackingStore?.Set("wiFiMacAddress", value); }
        }
        /// <summary>Count of active malware for this windows device. This property is read-only.</summary>
        public int? WindowsActiveMalwareCount {
            get { return BackingStore?.Get<int?>("windowsActiveMalwareCount"); }
            set { BackingStore?.Set("windowsActiveMalwareCount", value); }
        }
        /// <summary>The device protection status. This property is read-only.</summary>
        public Microsoft.Graph.Beta.Models.WindowsProtectionState WindowsProtectionState {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.WindowsProtectionState>("windowsProtectionState"); }
            set { BackingStore?.Set("windowsProtectionState", value); }
        }
        /// <summary>Count of remediated malware for this windows device. This property is read-only.</summary>
        public int? WindowsRemediatedMalwareCount {
            get { return BackingStore?.Get<int?>("windowsRemediatedMalwareCount"); }
            set { BackingStore?.Set("windowsRemediatedMalwareCount", value); }
        }
        /// <summary>
        /// Instantiates a new ManagedDevice and sets the default values.
        /// </summary>
        public ManagedDevice() : base() {
            OdataType = "#microsoft.graph.managedDevice";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ManagedDevice CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValueNode = parseNode.GetChildNode("@odata.type");
            var mappingValue = mappingValueNode?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.windowsManagedDevice" => new WindowsManagedDevice(),
                _ => new ManagedDevice(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"aadRegistered", n => { AadRegistered = n.GetBoolValue(); } },
                {"activationLockBypassCode", n => { ActivationLockBypassCode = n.GetStringValue(); } },
                {"androidSecurityPatchLevel", n => { AndroidSecurityPatchLevel = n.GetStringValue(); } },
                {"assignmentFilterEvaluationStatusDetails", n => { AssignmentFilterEvaluationStatusDetails = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.AssignmentFilterEvaluationStatusDetails>(Microsoft.Graph.Beta.Models.AssignmentFilterEvaluationStatusDetails.CreateFromDiscriminatorValue).ToList(); } },
                {"autopilotEnrolled", n => { AutopilotEnrolled = n.GetBoolValue(); } },
                {"azureActiveDirectoryDeviceId", n => { AzureActiveDirectoryDeviceId = n.GetStringValue(); } },
                {"azureADDeviceId", n => { AzureADDeviceId = n.GetStringValue(); } },
                {"azureADRegistered", n => { AzureADRegistered = n.GetBoolValue(); } },
                {"bootstrapTokenEscrowed", n => { BootstrapTokenEscrowed = n.GetBoolValue(); } },
                {"chassisType", n => { ChassisType = n.GetEnumValue<ChassisType>(); } },
                {"chromeOSDeviceInfo", n => { ChromeOSDeviceInfo = n.GetCollectionOfObjectValues<ChromeOSDeviceProperty>(ChromeOSDeviceProperty.CreateFromDiscriminatorValue).ToList(); } },
                {"cloudPcRemoteActionResults", n => { CloudPcRemoteActionResults = n.GetCollectionOfObjectValues<CloudPcRemoteActionResult>(CloudPcRemoteActionResult.CreateFromDiscriminatorValue).ToList(); } },
                {"complianceGracePeriodExpirationDateTime", n => { ComplianceGracePeriodExpirationDateTime = n.GetDateTimeOffsetValue(); } },
                {"complianceState", n => { ComplianceState = n.GetEnumValue<ComplianceState>(); } },
                {"configurationManagerClientEnabledFeatures", n => { ConfigurationManagerClientEnabledFeatures = n.GetObjectValue<Microsoft.Graph.Beta.Models.ConfigurationManagerClientEnabledFeatures>(Microsoft.Graph.Beta.Models.ConfigurationManagerClientEnabledFeatures.CreateFromDiscriminatorValue); } },
                {"configurationManagerClientHealthState", n => { ConfigurationManagerClientHealthState = n.GetObjectValue<Microsoft.Graph.Beta.Models.ConfigurationManagerClientHealthState>(Microsoft.Graph.Beta.Models.ConfigurationManagerClientHealthState.CreateFromDiscriminatorValue); } },
                {"configurationManagerClientInformation", n => { ConfigurationManagerClientInformation = n.GetObjectValue<Microsoft.Graph.Beta.Models.ConfigurationManagerClientInformation>(Microsoft.Graph.Beta.Models.ConfigurationManagerClientInformation.CreateFromDiscriminatorValue); } },
                {"detectedApps", n => { DetectedApps = n.GetCollectionOfObjectValues<DetectedApp>(DetectedApp.CreateFromDiscriminatorValue).ToList(); } },
                {"deviceActionResults", n => { DeviceActionResults = n.GetCollectionOfObjectValues<DeviceActionResult>(DeviceActionResult.CreateFromDiscriminatorValue).ToList(); } },
                {"deviceCategory", n => { DeviceCategory = n.GetObjectValue<Microsoft.Graph.Beta.Models.DeviceCategory>(Microsoft.Graph.Beta.Models.DeviceCategory.CreateFromDiscriminatorValue); } },
                {"deviceCategoryDisplayName", n => { DeviceCategoryDisplayName = n.GetStringValue(); } },
                {"deviceCompliancePolicyStates", n => { DeviceCompliancePolicyStates = n.GetCollectionOfObjectValues<DeviceCompliancePolicyState>(DeviceCompliancePolicyState.CreateFromDiscriminatorValue).ToList(); } },
                {"deviceConfigurationStates", n => { DeviceConfigurationStates = n.GetCollectionOfObjectValues<DeviceConfigurationState>(DeviceConfigurationState.CreateFromDiscriminatorValue).ToList(); } },
                {"deviceEnrollmentType", n => { DeviceEnrollmentType = n.GetEnumValue<DeviceEnrollmentType>(); } },
                {"deviceFirmwareConfigurationInterfaceManaged", n => { DeviceFirmwareConfigurationInterfaceManaged = n.GetBoolValue(); } },
                {"deviceHealthAttestationState", n => { DeviceHealthAttestationState = n.GetObjectValue<Microsoft.Graph.Beta.Models.DeviceHealthAttestationState>(Microsoft.Graph.Beta.Models.DeviceHealthAttestationState.CreateFromDiscriminatorValue); } },
                {"deviceName", n => { DeviceName = n.GetStringValue(); } },
                {"deviceRegistrationState", n => { DeviceRegistrationState = n.GetEnumValue<DeviceRegistrationState>(); } },
                {"deviceType", n => { DeviceType = n.GetEnumValue<DeviceType>(); } },
                {"easActivated", n => { EasActivated = n.GetBoolValue(); } },
                {"easActivationDateTime", n => { EasActivationDateTime = n.GetDateTimeOffsetValue(); } },
                {"easDeviceId", n => { EasDeviceId = n.GetStringValue(); } },
                {"emailAddress", n => { EmailAddress = n.GetStringValue(); } },
                {"enrolledDateTime", n => { EnrolledDateTime = n.GetDateTimeOffsetValue(); } },
                {"enrollmentProfileName", n => { EnrollmentProfileName = n.GetStringValue(); } },
                {"ethernetMacAddress", n => { EthernetMacAddress = n.GetStringValue(); } },
                {"exchangeAccessState", n => { ExchangeAccessState = n.GetEnumValue<DeviceManagementExchangeAccessState>(); } },
                {"exchangeAccessStateReason", n => { ExchangeAccessStateReason = n.GetEnumValue<DeviceManagementExchangeAccessStateReason>(); } },
                {"exchangeLastSuccessfulSyncDateTime", n => { ExchangeLastSuccessfulSyncDateTime = n.GetDateTimeOffsetValue(); } },
                {"freeStorageSpaceInBytes", n => { FreeStorageSpaceInBytes = n.GetLongValue(); } },
                {"hardwareInformation", n => { HardwareInformation = n.GetObjectValue<Microsoft.Graph.Beta.Models.HardwareInformation>(Microsoft.Graph.Beta.Models.HardwareInformation.CreateFromDiscriminatorValue); } },
                {"iccid", n => { Iccid = n.GetStringValue(); } },
                {"imei", n => { Imei = n.GetStringValue(); } },
                {"isEncrypted", n => { IsEncrypted = n.GetBoolValue(); } },
                {"isSupervised", n => { IsSupervised = n.GetBoolValue(); } },
                {"jailBroken", n => { JailBroken = n.GetStringValue(); } },
                {"joinType", n => { JoinType = n.GetEnumValue<JoinType>(); } },
                {"lastSyncDateTime", n => { LastSyncDateTime = n.GetDateTimeOffsetValue(); } },
                {"logCollectionRequests", n => { LogCollectionRequests = n.GetCollectionOfObjectValues<DeviceLogCollectionResponse>(DeviceLogCollectionResponse.CreateFromDiscriminatorValue).ToList(); } },
                {"lostModeState", n => { LostModeState = n.GetEnumValue<LostModeState>(); } },
                {"managedDeviceMobileAppConfigurationStates", n => { ManagedDeviceMobileAppConfigurationStates = n.GetCollectionOfObjectValues<ManagedDeviceMobileAppConfigurationState>(ManagedDeviceMobileAppConfigurationState.CreateFromDiscriminatorValue).ToList(); } },
                {"managedDeviceName", n => { ManagedDeviceName = n.GetStringValue(); } },
                {"managedDeviceOwnerType", n => { ManagedDeviceOwnerType = n.GetEnumValue<ManagedDeviceOwnerType>(); } },
                {"managementAgent", n => { ManagementAgent = n.GetEnumValue<ManagementAgentType>(); } },
                {"managementCertificateExpirationDate", n => { ManagementCertificateExpirationDate = n.GetDateTimeOffsetValue(); } },
                {"managementFeatures", n => { ManagementFeatures = n.GetEnumValue<ManagedDeviceManagementFeatures>(); } },
                {"managementState", n => { ManagementState = n.GetEnumValue<ManagementState>(); } },
                {"manufacturer", n => { Manufacturer = n.GetStringValue(); } },
                {"meid", n => { Meid = n.GetStringValue(); } },
                {"model", n => { Model = n.GetStringValue(); } },
                {"notes", n => { Notes = n.GetStringValue(); } },
                {"operatingSystem", n => { OperatingSystem = n.GetStringValue(); } },
                {"osVersion", n => { OsVersion = n.GetStringValue(); } },
                {"ownerType", n => { OwnerType = n.GetEnumValue<OwnerType>(); } },
                {"partnerReportedThreatState", n => { PartnerReportedThreatState = n.GetEnumValue<ManagedDevicePartnerReportedHealthState>(); } },
                {"phoneNumber", n => { PhoneNumber = n.GetStringValue(); } },
                {"physicalMemoryInBytes", n => { PhysicalMemoryInBytes = n.GetLongValue(); } },
                {"preferMdmOverGroupPolicyAppliedDateTime", n => { PreferMdmOverGroupPolicyAppliedDateTime = n.GetDateTimeOffsetValue(); } },
                {"processorArchitecture", n => { ProcessorArchitecture = n.GetEnumValue<ManagedDeviceArchitecture>(); } },
                {"remoteAssistanceSessionErrorDetails", n => { RemoteAssistanceSessionErrorDetails = n.GetStringValue(); } },
                {"remoteAssistanceSessionUrl", n => { RemoteAssistanceSessionUrl = n.GetStringValue(); } },
                {"requireUserEnrollmentApproval", n => { RequireUserEnrollmentApproval = n.GetBoolValue(); } },
                {"retireAfterDateTime", n => { RetireAfterDateTime = n.GetDateTimeOffsetValue(); } },
                {"roleScopeTagIds", n => { RoleScopeTagIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"securityBaselineStates", n => { SecurityBaselineStates = n.GetCollectionOfObjectValues<SecurityBaselineState>(SecurityBaselineState.CreateFromDiscriminatorValue).ToList(); } },
                {"serialNumber", n => { SerialNumber = n.GetStringValue(); } },
                {"skuFamily", n => { SkuFamily = n.GetStringValue(); } },
                {"skuNumber", n => { SkuNumber = n.GetIntValue(); } },
                {"specificationVersion", n => { SpecificationVersion = n.GetStringValue(); } },
                {"subscriberCarrier", n => { SubscriberCarrier = n.GetStringValue(); } },
                {"totalStorageSpaceInBytes", n => { TotalStorageSpaceInBytes = n.GetLongValue(); } },
                {"udid", n => { Udid = n.GetStringValue(); } },
                {"userDisplayName", n => { UserDisplayName = n.GetStringValue(); } },
                {"userId", n => { UserId = n.GetStringValue(); } },
                {"userPrincipalName", n => { UserPrincipalName = n.GetStringValue(); } },
                {"users", n => { Users = n.GetCollectionOfObjectValues<User>(User.CreateFromDiscriminatorValue).ToList(); } },
                {"usersLoggedOn", n => { UsersLoggedOn = n.GetCollectionOfObjectValues<LoggedOnUser>(LoggedOnUser.CreateFromDiscriminatorValue).ToList(); } },
                {"wiFiMacAddress", n => { WiFiMacAddress = n.GetStringValue(); } },
                {"windowsActiveMalwareCount", n => { WindowsActiveMalwareCount = n.GetIntValue(); } },
                {"windowsProtectionState", n => { WindowsProtectionState = n.GetObjectValue<Microsoft.Graph.Beta.Models.WindowsProtectionState>(Microsoft.Graph.Beta.Models.WindowsProtectionState.CreateFromDiscriminatorValue); } },
                {"windowsRemediatedMalwareCount", n => { WindowsRemediatedMalwareCount = n.GetIntValue(); } },
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
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.AssignmentFilterEvaluationStatusDetails>("assignmentFilterEvaluationStatusDetails", AssignmentFilterEvaluationStatusDetails);
            writer.WriteBoolValue("autopilotEnrolled", AutopilotEnrolled);
            writer.WriteStringValue("azureActiveDirectoryDeviceId", AzureActiveDirectoryDeviceId);
            writer.WriteStringValue("azureADDeviceId", AzureADDeviceId);
            writer.WriteBoolValue("azureADRegistered", AzureADRegistered);
            writer.WriteBoolValue("bootstrapTokenEscrowed", BootstrapTokenEscrowed);
            writer.WriteEnumValue<ChassisType>("chassisType", ChassisType);
            writer.WriteCollectionOfObjectValues<ChromeOSDeviceProperty>("chromeOSDeviceInfo", ChromeOSDeviceInfo);
            writer.WriteCollectionOfObjectValues<CloudPcRemoteActionResult>("cloudPcRemoteActionResults", CloudPcRemoteActionResults);
            writer.WriteDateTimeOffsetValue("complianceGracePeriodExpirationDateTime", ComplianceGracePeriodExpirationDateTime);
            writer.WriteEnumValue<ComplianceState>("complianceState", ComplianceState);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.ConfigurationManagerClientEnabledFeatures>("configurationManagerClientEnabledFeatures", ConfigurationManagerClientEnabledFeatures);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.ConfigurationManagerClientHealthState>("configurationManagerClientHealthState", ConfigurationManagerClientHealthState);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.ConfigurationManagerClientInformation>("configurationManagerClientInformation", ConfigurationManagerClientInformation);
            writer.WriteCollectionOfObjectValues<DetectedApp>("detectedApps", DetectedApps);
            writer.WriteCollectionOfObjectValues<DeviceActionResult>("deviceActionResults", DeviceActionResults);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.DeviceCategory>("deviceCategory", DeviceCategory);
            writer.WriteStringValue("deviceCategoryDisplayName", DeviceCategoryDisplayName);
            writer.WriteCollectionOfObjectValues<DeviceCompliancePolicyState>("deviceCompliancePolicyStates", DeviceCompliancePolicyStates);
            writer.WriteCollectionOfObjectValues<DeviceConfigurationState>("deviceConfigurationStates", DeviceConfigurationStates);
            writer.WriteEnumValue<DeviceEnrollmentType>("deviceEnrollmentType", DeviceEnrollmentType);
            writer.WriteBoolValue("deviceFirmwareConfigurationInterfaceManaged", DeviceFirmwareConfigurationInterfaceManaged);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.DeviceHealthAttestationState>("deviceHealthAttestationState", DeviceHealthAttestationState);
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
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.HardwareInformation>("hardwareInformation", HardwareInformation);
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
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.WindowsProtectionState>("windowsProtectionState", WindowsProtectionState);
            writer.WriteIntValue("windowsRemediatedMalwareCount", WindowsRemediatedMalwareCount);
        }
    }
}
