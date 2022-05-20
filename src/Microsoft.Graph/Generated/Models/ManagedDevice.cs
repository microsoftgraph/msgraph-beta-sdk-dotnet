using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Devices that are managed or pre-enrolled through Intune</summary>
    public class ManagedDevice : Entity, IParsable {
        /// <summary>Whether the device is Azure Active Directory registered. This property is read-only.</summary>
        public bool? AadRegistered {
            get { return BackingStore?.Get<bool?>(nameof(AadRegistered)); }
            set { BackingStore?.Set(nameof(AadRegistered), value); }
        }
        /// <summary>Code that allows the Activation Lock on a device to be bypassed. This property is read-only.</summary>
        public string ActivationLockBypassCode {
            get { return BackingStore?.Get<string>(nameof(ActivationLockBypassCode)); }
            set { BackingStore?.Set(nameof(ActivationLockBypassCode), value); }
        }
        /// <summary>Android security patch level. This property is read-only.</summary>
        public string AndroidSecurityPatchLevel {
            get { return BackingStore?.Get<string>(nameof(AndroidSecurityPatchLevel)); }
            set { BackingStore?.Set(nameof(AndroidSecurityPatchLevel), value); }
        }
        /// <summary>Managed device mobile app configuration states for this device.</summary>
        public List<Microsoft.Graph.Beta.Models.AssignmentFilterEvaluationStatusDetails> AssignmentFilterEvaluationStatusDetails {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.AssignmentFilterEvaluationStatusDetails>>(nameof(AssignmentFilterEvaluationStatusDetails)); }
            set { BackingStore?.Set(nameof(AssignmentFilterEvaluationStatusDetails), value); }
        }
        /// <summary>Reports if the managed device is enrolled via auto-pilot. This property is read-only.</summary>
        public bool? AutopilotEnrolled {
            get { return BackingStore?.Get<bool?>(nameof(AutopilotEnrolled)); }
            set { BackingStore?.Set(nameof(AutopilotEnrolled), value); }
        }
        /// <summary>The unique identifier for the Azure Active Directory device. Read only. This property is read-only.</summary>
        public string AzureActiveDirectoryDeviceId {
            get { return BackingStore?.Get<string>(nameof(AzureActiveDirectoryDeviceId)); }
            set { BackingStore?.Set(nameof(AzureActiveDirectoryDeviceId), value); }
        }
        /// <summary>The unique identifier for the Azure Active Directory device. Read only. This property is read-only.</summary>
        public string AzureADDeviceId {
            get { return BackingStore?.Get<string>(nameof(AzureADDeviceId)); }
            set { BackingStore?.Set(nameof(AzureADDeviceId), value); }
        }
        /// <summary>Whether the device is Azure Active Directory registered. This property is read-only.</summary>
        public bool? AzureADRegistered {
            get { return BackingStore?.Get<bool?>(nameof(AzureADRegistered)); }
            set { BackingStore?.Set(nameof(AzureADRegistered), value); }
        }
        /// <summary>Chassis type of the device. This property is read-only. Possible values are: unknown, desktop, laptop, worksWorkstation, enterpriseServer, phone, tablet, mobileOther, mobileUnknown.</summary>
        public Microsoft.Graph.Beta.Models.ChassisType? ChassisType {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ChassisType?>(nameof(ChassisType)); }
            set { BackingStore?.Set(nameof(ChassisType), value); }
        }
        /// <summary>List of properties of the ChromeOS Device.</summary>
        public List<ChromeOSDeviceProperty> ChromeOSDeviceInfo {
            get { return BackingStore?.Get<List<ChromeOSDeviceProperty>>(nameof(ChromeOSDeviceInfo)); }
            set { BackingStore?.Set(nameof(ChromeOSDeviceInfo), value); }
        }
        /// <summary>The cloudPcRemoteActionResults property</summary>
        public List<CloudPcRemoteActionResult> CloudPcRemoteActionResults {
            get { return BackingStore?.Get<List<CloudPcRemoteActionResult>>(nameof(CloudPcRemoteActionResults)); }
            set { BackingStore?.Set(nameof(CloudPcRemoteActionResults), value); }
        }
        /// <summary>The DateTime when device compliance grace period expires. This property is read-only.</summary>
        public DateTimeOffset? ComplianceGracePeriodExpirationDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(ComplianceGracePeriodExpirationDateTime)); }
            set { BackingStore?.Set(nameof(ComplianceGracePeriodExpirationDateTime), value); }
        }
        /// <summary>Compliance state of the device. This property is read-only. Possible values are: unknown, compliant, noncompliant, conflict, error, inGracePeriod, configManager.</summary>
        public Microsoft.Graph.Beta.Models.ComplianceState? ComplianceState {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ComplianceState?>(nameof(ComplianceState)); }
            set { BackingStore?.Set(nameof(ComplianceState), value); }
        }
        /// <summary>ConfigrMgr client enabled features. This property is read-only.</summary>
        public Microsoft.Graph.Beta.Models.ConfigurationManagerClientEnabledFeatures ConfigurationManagerClientEnabledFeatures {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ConfigurationManagerClientEnabledFeatures>(nameof(ConfigurationManagerClientEnabledFeatures)); }
            set { BackingStore?.Set(nameof(ConfigurationManagerClientEnabledFeatures), value); }
        }
        /// <summary>Configuration manager client health state, valid only for devices managed by MDM/ConfigMgr Agent</summary>
        public Microsoft.Graph.Beta.Models.ConfigurationManagerClientHealthState ConfigurationManagerClientHealthState {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ConfigurationManagerClientHealthState>(nameof(ConfigurationManagerClientHealthState)); }
            set { BackingStore?.Set(nameof(ConfigurationManagerClientHealthState), value); }
        }
        /// <summary>Configuration manager client information, valid only for devices managed, duel-managed or tri-managed by ConfigMgr Agent</summary>
        public Microsoft.Graph.Beta.Models.ConfigurationManagerClientInformation ConfigurationManagerClientInformation {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ConfigurationManagerClientInformation>(nameof(ConfigurationManagerClientInformation)); }
            set { BackingStore?.Set(nameof(ConfigurationManagerClientInformation), value); }
        }
        /// <summary>All applications currently installed on the device</summary>
        public List<DetectedApp> DetectedApps {
            get { return BackingStore?.Get<List<DetectedApp>>(nameof(DetectedApps)); }
            set { BackingStore?.Set(nameof(DetectedApps), value); }
        }
        /// <summary>List of ComplexType deviceActionResult objects. This property is read-only.</summary>
        public List<DeviceActionResult> DeviceActionResults {
            get { return BackingStore?.Get<List<DeviceActionResult>>(nameof(DeviceActionResults)); }
            set { BackingStore?.Set(nameof(DeviceActionResults), value); }
        }
        /// <summary>Device category</summary>
        public Microsoft.Graph.Beta.Models.DeviceCategory DeviceCategory {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DeviceCategory>(nameof(DeviceCategory)); }
            set { BackingStore?.Set(nameof(DeviceCategory), value); }
        }
        /// <summary>Device category display name. This property is read-only.</summary>
        public string DeviceCategoryDisplayName {
            get { return BackingStore?.Get<string>(nameof(DeviceCategoryDisplayName)); }
            set { BackingStore?.Set(nameof(DeviceCategoryDisplayName), value); }
        }
        /// <summary>Device compliance policy states for this device.</summary>
        public List<DeviceCompliancePolicyState> DeviceCompliancePolicyStates {
            get { return BackingStore?.Get<List<DeviceCompliancePolicyState>>(nameof(DeviceCompliancePolicyStates)); }
            set { BackingStore?.Set(nameof(DeviceCompliancePolicyStates), value); }
        }
        /// <summary>Device configuration states for this device.</summary>
        public List<DeviceConfigurationState> DeviceConfigurationStates {
            get { return BackingStore?.Get<List<DeviceConfigurationState>>(nameof(DeviceConfigurationStates)); }
            set { BackingStore?.Set(nameof(DeviceConfigurationStates), value); }
        }
        /// <summary>Enrollment type of the device. This property is read-only. Possible values are: unknown, userEnrollment, deviceEnrollmentManager, appleBulkWithUser, appleBulkWithoutUser, windowsAzureADJoin, windowsBulkUserless, windowsAutoEnrollment, windowsBulkAzureDomainJoin, windowsCoManagement, windowsAzureADJoinUsingDeviceAuth, appleUserEnrollment, appleUserEnrollmentWithServiceAccount, azureAdJoinUsingAzureVmExtension, androidEnterpriseDedicatedDevice, androidEnterpriseFullyManaged, androidEnterpriseCorporateWorkProfile.</summary>
        public Microsoft.Graph.Beta.Models.DeviceEnrollmentType? DeviceEnrollmentType {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DeviceEnrollmentType?>(nameof(DeviceEnrollmentType)); }
            set { BackingStore?.Set(nameof(DeviceEnrollmentType), value); }
        }
        /// <summary>The device health attestation state. This property is read-only.</summary>
        public Microsoft.Graph.Beta.Models.DeviceHealthAttestationState DeviceHealthAttestationState {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DeviceHealthAttestationState>(nameof(DeviceHealthAttestationState)); }
            set { BackingStore?.Set(nameof(DeviceHealthAttestationState), value); }
        }
        /// <summary>Name of the device. This property is read-only.</summary>
        public string DeviceName {
            get { return BackingStore?.Get<string>(nameof(DeviceName)); }
            set { BackingStore?.Set(nameof(DeviceName), value); }
        }
        /// <summary>Device registration state. This property is read-only. Possible values are: notRegistered, registered, revoked, keyConflict, approvalPending, certificateReset, notRegisteredPendingEnrollment, unknown.</summary>
        public Microsoft.Graph.Beta.Models.DeviceRegistrationState? DeviceRegistrationState {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DeviceRegistrationState?>(nameof(DeviceRegistrationState)); }
            set { BackingStore?.Set(nameof(DeviceRegistrationState), value); }
        }
        /// <summary>Platform of the device. This property is read-only. Possible values are: desktop, windowsRT, winMO6, nokia, windowsPhone, mac, winCE, winEmbedded, iPhone, iPad, iPod, android, iSocConsumer, unix, macMDM, holoLens, surfaceHub, androidForWork, androidEnterprise, windows10x, androidnGMS, chromeOS, linux, blackberry, palm, unknown, cloudPC.</summary>
        public Microsoft.Graph.Beta.Models.DeviceType? DeviceType {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DeviceType?>(nameof(DeviceType)); }
            set { BackingStore?.Set(nameof(DeviceType), value); }
        }
        /// <summary>Whether the device is Exchange ActiveSync activated. This property is read-only.</summary>
        public bool? EasActivated {
            get { return BackingStore?.Get<bool?>(nameof(EasActivated)); }
            set { BackingStore?.Set(nameof(EasActivated), value); }
        }
        /// <summary>Exchange ActivationSync activation time of the device. This property is read-only.</summary>
        public DateTimeOffset? EasActivationDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(EasActivationDateTime)); }
            set { BackingStore?.Set(nameof(EasActivationDateTime), value); }
        }
        /// <summary>Exchange ActiveSync Id of the device. This property is read-only.</summary>
        public string EasDeviceId {
            get { return BackingStore?.Get<string>(nameof(EasDeviceId)); }
            set { BackingStore?.Set(nameof(EasDeviceId), value); }
        }
        /// <summary>Email(s) for the user associated with the device. This property is read-only.</summary>
        public string EmailAddress {
            get { return BackingStore?.Get<string>(nameof(EmailAddress)); }
            set { BackingStore?.Set(nameof(EmailAddress), value); }
        }
        /// <summary>Enrollment time of the device. This property is read-only.</summary>
        public DateTimeOffset? EnrolledDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(EnrolledDateTime)); }
            set { BackingStore?.Set(nameof(EnrolledDateTime), value); }
        }
        /// <summary>Name of the enrollment profile assigned to the device. Default value is empty string, indicating no enrollment profile was assgined. This property is read-only.</summary>
        public string EnrollmentProfileName {
            get { return BackingStore?.Get<string>(nameof(EnrollmentProfileName)); }
            set { BackingStore?.Set(nameof(EnrollmentProfileName), value); }
        }
        /// <summary>Ethernet MAC. This property is read-only.</summary>
        public string EthernetMacAddress {
            get { return BackingStore?.Get<string>(nameof(EthernetMacAddress)); }
            set { BackingStore?.Set(nameof(EthernetMacAddress), value); }
        }
        /// <summary>The Access State of the device in Exchange. This property is read-only. Possible values are: none, unknown, allowed, blocked, quarantined.</summary>
        public DeviceManagementExchangeAccessState? ExchangeAccessState {
            get { return BackingStore?.Get<DeviceManagementExchangeAccessState?>(nameof(ExchangeAccessState)); }
            set { BackingStore?.Set(nameof(ExchangeAccessState), value); }
        }
        /// <summary>The reason for the device&apos;s access state in Exchange. This property is read-only. Possible values are: none, unknown, exchangeGlobalRule, exchangeIndividualRule, exchangeDeviceRule, exchangeUpgrade, exchangeMailboxPolicy, other, compliant, notCompliant, notEnrolled, unknownLocation, mfaRequired, azureADBlockDueToAccessPolicy, compromisedPassword, deviceNotKnownWithManagedApp.</summary>
        public DeviceManagementExchangeAccessStateReason? ExchangeAccessStateReason {
            get { return BackingStore?.Get<DeviceManagementExchangeAccessStateReason?>(nameof(ExchangeAccessStateReason)); }
            set { BackingStore?.Set(nameof(ExchangeAccessStateReason), value); }
        }
        /// <summary>Last time the device contacted Exchange. This property is read-only.</summary>
        public DateTimeOffset? ExchangeLastSuccessfulSyncDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(ExchangeLastSuccessfulSyncDateTime)); }
            set { BackingStore?.Set(nameof(ExchangeLastSuccessfulSyncDateTime), value); }
        }
        /// <summary>Free Storage in Bytes. This property is read-only.</summary>
        public long? FreeStorageSpaceInBytes {
            get { return BackingStore?.Get<long?>(nameof(FreeStorageSpaceInBytes)); }
            set { BackingStore?.Set(nameof(FreeStorageSpaceInBytes), value); }
        }
        /// <summary>The hardward details for the device.  Includes information such as storage space, manufacturer, serial number, etc. This property is read-only.</summary>
        public Microsoft.Graph.Beta.Models.HardwareInformation HardwareInformation {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.HardwareInformation>(nameof(HardwareInformation)); }
            set { BackingStore?.Set(nameof(HardwareInformation), value); }
        }
        /// <summary>Integrated Circuit Card Identifier, it is A SIM card&apos;s unique identification number. This property is read-only.</summary>
        public string Iccid {
            get { return BackingStore?.Get<string>(nameof(Iccid)); }
            set { BackingStore?.Set(nameof(Iccid), value); }
        }
        /// <summary>IMEI. This property is read-only.</summary>
        public string Imei {
            get { return BackingStore?.Get<string>(nameof(Imei)); }
            set { BackingStore?.Set(nameof(Imei), value); }
        }
        /// <summary>Device encryption status. This property is read-only.</summary>
        public bool? IsEncrypted {
            get { return BackingStore?.Get<bool?>(nameof(IsEncrypted)); }
            set { BackingStore?.Set(nameof(IsEncrypted), value); }
        }
        /// <summary>Device supervised status. This property is read-only.</summary>
        public bool? IsSupervised {
            get { return BackingStore?.Get<bool?>(nameof(IsSupervised)); }
            set { BackingStore?.Set(nameof(IsSupervised), value); }
        }
        /// <summary>whether the device is jail broken or rooted. This property is read-only.</summary>
        public string JailBroken {
            get { return BackingStore?.Get<string>(nameof(JailBroken)); }
            set { BackingStore?.Set(nameof(JailBroken), value); }
        }
        /// <summary>Device join type. Possible values are: unknown, azureADJoined, azureADRegistered, hybridAzureADJoined.</summary>
        public Microsoft.Graph.Beta.Models.JoinType? JoinType {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.JoinType?>(nameof(JoinType)); }
            set { BackingStore?.Set(nameof(JoinType), value); }
        }
        /// <summary>The date and time that the device last completed a successful sync with Intune. This property is read-only.</summary>
        public DateTimeOffset? LastSyncDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(LastSyncDateTime)); }
            set { BackingStore?.Set(nameof(LastSyncDateTime), value); }
        }
        /// <summary>List of log collection requests</summary>
        public List<DeviceLogCollectionResponse> LogCollectionRequests {
            get { return BackingStore?.Get<List<DeviceLogCollectionResponse>>(nameof(LogCollectionRequests)); }
            set { BackingStore?.Set(nameof(LogCollectionRequests), value); }
        }
        /// <summary>Indicates if Lost mode is enabled or disabled. This property is read-only. Possible values are: disabled, enabled.</summary>
        public Microsoft.Graph.Beta.Models.LostModeState? LostModeState {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.LostModeState?>(nameof(LostModeState)); }
            set { BackingStore?.Set(nameof(LostModeState), value); }
        }
        /// <summary>Managed device mobile app configuration states for this device.</summary>
        public List<ManagedDeviceMobileAppConfigurationState> ManagedDeviceMobileAppConfigurationStates {
            get { return BackingStore?.Get<List<ManagedDeviceMobileAppConfigurationState>>(nameof(ManagedDeviceMobileAppConfigurationStates)); }
            set { BackingStore?.Set(nameof(ManagedDeviceMobileAppConfigurationStates), value); }
        }
        /// <summary>Automatically generated name to identify a device. Can be overwritten to a user friendly name.</summary>
        public string ManagedDeviceName {
            get { return BackingStore?.Get<string>(nameof(ManagedDeviceName)); }
            set { BackingStore?.Set(nameof(ManagedDeviceName), value); }
        }
        /// <summary>Ownership of the device. Can be &apos;company&apos; or &apos;personal&apos;. Possible values are: unknown, company, personal.</summary>
        public Microsoft.Graph.Beta.Models.ManagedDeviceOwnerType? ManagedDeviceOwnerType {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ManagedDeviceOwnerType?>(nameof(ManagedDeviceOwnerType)); }
            set { BackingStore?.Set(nameof(ManagedDeviceOwnerType), value); }
        }
        /// <summary>Management channel of the device. Intune, EAS, etc. This property is read-only. Possible values are: eas, mdm, easMdm, intuneClient, easIntuneClient, configurationManagerClient, configurationManagerClientMdm, configurationManagerClientMdmEas, unknown, jamf, googleCloudDevicePolicyController, microsoft365ManagedMdm, msSense, intuneAosp.</summary>
        public ManagementAgentType? ManagementAgent {
            get { return BackingStore?.Get<ManagementAgentType?>(nameof(ManagementAgent)); }
            set { BackingStore?.Set(nameof(ManagementAgent), value); }
        }
        /// <summary>Reports device management certificate expiration date. This property is read-only.</summary>
        public DateTimeOffset? ManagementCertificateExpirationDate {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(ManagementCertificateExpirationDate)); }
            set { BackingStore?.Set(nameof(ManagementCertificateExpirationDate), value); }
        }
        /// <summary>Device management features. Possible values are: none, microsoftManagedDesktop.</summary>
        public ManagedDeviceManagementFeatures? ManagementFeatures {
            get { return BackingStore?.Get<ManagedDeviceManagementFeatures?>(nameof(ManagementFeatures)); }
            set { BackingStore?.Set(nameof(ManagementFeatures), value); }
        }
        /// <summary>Management state of the device. This property is read-only. Possible values are: managed, retirePending, retireFailed, wipePending, wipeFailed, unhealthy, deletePending, retireIssued, wipeIssued, wipeCanceled, retireCanceled, discovered.</summary>
        public Microsoft.Graph.Beta.Models.ManagementState? ManagementState {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ManagementState?>(nameof(ManagementState)); }
            set { BackingStore?.Set(nameof(ManagementState), value); }
        }
        /// <summary>Manufacturer of the device. This property is read-only.</summary>
        public string Manufacturer {
            get { return BackingStore?.Get<string>(nameof(Manufacturer)); }
            set { BackingStore?.Set(nameof(Manufacturer), value); }
        }
        /// <summary>MEID. This property is read-only.</summary>
        public string Meid {
            get { return BackingStore?.Get<string>(nameof(Meid)); }
            set { BackingStore?.Set(nameof(Meid), value); }
        }
        /// <summary>Model of the device. This property is read-only.</summary>
        public string Model {
            get { return BackingStore?.Get<string>(nameof(Model)); }
            set { BackingStore?.Set(nameof(Model), value); }
        }
        /// <summary>Notes on the device created by IT Admin</summary>
        public string Notes {
            get { return BackingStore?.Get<string>(nameof(Notes)); }
            set { BackingStore?.Set(nameof(Notes), value); }
        }
        /// <summary>Operating system of the device. Windows, iOS, etc. This property is read-only.</summary>
        public string OperatingSystem {
            get { return BackingStore?.Get<string>(nameof(OperatingSystem)); }
            set { BackingStore?.Set(nameof(OperatingSystem), value); }
        }
        /// <summary>Operating system version of the device. This property is read-only.</summary>
        public string OsVersion {
            get { return BackingStore?.Get<string>(nameof(OsVersion)); }
            set { BackingStore?.Set(nameof(OsVersion), value); }
        }
        /// <summary>Ownership of the device. Can be &apos;company&apos; or &apos;personal&apos;. Possible values are: unknown, company, personal.</summary>
        public Microsoft.Graph.Beta.Models.OwnerType? OwnerType {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.OwnerType?>(nameof(OwnerType)); }
            set { BackingStore?.Set(nameof(OwnerType), value); }
        }
        /// <summary>Indicates the threat state of a device when a Mobile Threat Defense partner is in use by the account and device. Read Only. This property is read-only. Possible values are: unknown, activated, deactivated, secured, lowSeverity, mediumSeverity, highSeverity, unresponsive, compromised, misconfigured.</summary>
        public ManagedDevicePartnerReportedHealthState? PartnerReportedThreatState {
            get { return BackingStore?.Get<ManagedDevicePartnerReportedHealthState?>(nameof(PartnerReportedThreatState)); }
            set { BackingStore?.Set(nameof(PartnerReportedThreatState), value); }
        }
        /// <summary>Phone number of the device. This property is read-only.</summary>
        public string PhoneNumber {
            get { return BackingStore?.Get<string>(nameof(PhoneNumber)); }
            set { BackingStore?.Set(nameof(PhoneNumber), value); }
        }
        /// <summary>Total Memory in Bytes. This property is read-only.</summary>
        public long? PhysicalMemoryInBytes {
            get { return BackingStore?.Get<long?>(nameof(PhysicalMemoryInBytes)); }
            set { BackingStore?.Set(nameof(PhysicalMemoryInBytes), value); }
        }
        /// <summary>Reports the DateTime the preferMdmOverGroupPolicy setting was set.  When set, the Intune MDM settings will override Group Policy settings if there is a conflict. Read Only. This property is read-only.</summary>
        public DateTimeOffset? PreferMdmOverGroupPolicyAppliedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(PreferMdmOverGroupPolicyAppliedDateTime)); }
            set { BackingStore?.Set(nameof(PreferMdmOverGroupPolicyAppliedDateTime), value); }
        }
        /// <summary>Processor architecture. This property is read-only. Possible values are: unknown, x86, x64, arm, arM64.</summary>
        public ManagedDeviceArchitecture? ProcessorArchitecture {
            get { return BackingStore?.Get<ManagedDeviceArchitecture?>(nameof(ProcessorArchitecture)); }
            set { BackingStore?.Set(nameof(ProcessorArchitecture), value); }
        }
        /// <summary>An error string that identifies issues when creating Remote Assistance session objects. This property is read-only.</summary>
        public string RemoteAssistanceSessionErrorDetails {
            get { return BackingStore?.Get<string>(nameof(RemoteAssistanceSessionErrorDetails)); }
            set { BackingStore?.Set(nameof(RemoteAssistanceSessionErrorDetails), value); }
        }
        /// <summary>Url that allows a Remote Assistance session to be established with the device. This property is read-only.</summary>
        public string RemoteAssistanceSessionUrl {
            get { return BackingStore?.Get<string>(nameof(RemoteAssistanceSessionUrl)); }
            set { BackingStore?.Set(nameof(RemoteAssistanceSessionUrl), value); }
        }
        /// <summary>Reports if the managed iOS device is user approval enrollment. This property is read-only.</summary>
        public bool? RequireUserEnrollmentApproval {
            get { return BackingStore?.Get<bool?>(nameof(RequireUserEnrollmentApproval)); }
            set { BackingStore?.Set(nameof(RequireUserEnrollmentApproval), value); }
        }
        /// <summary>Indicates the time after when a device will be auto retired because of scheduled action. This property is read-only.</summary>
        public DateTimeOffset? RetireAfterDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(RetireAfterDateTime)); }
            set { BackingStore?.Set(nameof(RetireAfterDateTime), value); }
        }
        /// <summary>List of Scope Tag IDs for this Device instance.</summary>
        public List<string> RoleScopeTagIds {
            get { return BackingStore?.Get<List<string>>(nameof(RoleScopeTagIds)); }
            set { BackingStore?.Set(nameof(RoleScopeTagIds), value); }
        }
        /// <summary>Security baseline states for this device.</summary>
        public List<SecurityBaselineState> SecurityBaselineStates {
            get { return BackingStore?.Get<List<SecurityBaselineState>>(nameof(SecurityBaselineStates)); }
            set { BackingStore?.Set(nameof(SecurityBaselineStates), value); }
        }
        /// <summary>SerialNumber. This property is read-only.</summary>
        public string SerialNumber {
            get { return BackingStore?.Get<string>(nameof(SerialNumber)); }
            set { BackingStore?.Set(nameof(SerialNumber), value); }
        }
        /// <summary>Device sku family</summary>
        public string SkuFamily {
            get { return BackingStore?.Get<string>(nameof(SkuFamily)); }
            set { BackingStore?.Set(nameof(SkuFamily), value); }
        }
        /// <summary>Device sku number, see also: https://docs.microsoft.com/windows/win32/api/sysinfoapi/nf-sysinfoapi-getproductinfo. Valid values 0 to 2147483647. This property is read-only.</summary>
        public int? SkuNumber {
            get { return BackingStore?.Get<int?>(nameof(SkuNumber)); }
            set { BackingStore?.Set(nameof(SkuNumber), value); }
        }
        /// <summary>Specification version. This property is read-only.</summary>
        public string SpecificationVersion {
            get { return BackingStore?.Get<string>(nameof(SpecificationVersion)); }
            set { BackingStore?.Set(nameof(SpecificationVersion), value); }
        }
        /// <summary>Subscriber Carrier. This property is read-only.</summary>
        public string SubscriberCarrier {
            get { return BackingStore?.Get<string>(nameof(SubscriberCarrier)); }
            set { BackingStore?.Set(nameof(SubscriberCarrier), value); }
        }
        /// <summary>Total Storage in Bytes. This property is read-only.</summary>
        public long? TotalStorageSpaceInBytes {
            get { return BackingStore?.Get<long?>(nameof(TotalStorageSpaceInBytes)); }
            set { BackingStore?.Set(nameof(TotalStorageSpaceInBytes), value); }
        }
        /// <summary>Unique Device Identifier for iOS and macOS devices. This property is read-only.</summary>
        public string Udid {
            get { return BackingStore?.Get<string>(nameof(Udid)); }
            set { BackingStore?.Set(nameof(Udid), value); }
        }
        /// <summary>User display name. This property is read-only.</summary>
        public string UserDisplayName {
            get { return BackingStore?.Get<string>(nameof(UserDisplayName)); }
            set { BackingStore?.Set(nameof(UserDisplayName), value); }
        }
        /// <summary>Unique Identifier for the user associated with the device. This property is read-only.</summary>
        public string UserId {
            get { return BackingStore?.Get<string>(nameof(UserId)); }
            set { BackingStore?.Set(nameof(UserId), value); }
        }
        /// <summary>Device user principal name. This property is read-only.</summary>
        public string UserPrincipalName {
            get { return BackingStore?.Get<string>(nameof(UserPrincipalName)); }
            set { BackingStore?.Set(nameof(UserPrincipalName), value); }
        }
        /// <summary>The primary users associated with the managed device.</summary>
        public List<User> Users {
            get { return BackingStore?.Get<List<User>>(nameof(Users)); }
            set { BackingStore?.Set(nameof(Users), value); }
        }
        /// <summary>Indicates the last logged on users of a device. This property is read-only.</summary>
        public List<LoggedOnUser> UsersLoggedOn {
            get { return BackingStore?.Get<List<LoggedOnUser>>(nameof(UsersLoggedOn)); }
            set { BackingStore?.Set(nameof(UsersLoggedOn), value); }
        }
        /// <summary>Wi-Fi MAC. This property is read-only.</summary>
        public string WiFiMacAddress {
            get { return BackingStore?.Get<string>(nameof(WiFiMacAddress)); }
            set { BackingStore?.Set(nameof(WiFiMacAddress), value); }
        }
        /// <summary>Count of active malware for this windows device. This property is read-only.</summary>
        public int? WindowsActiveMalwareCount {
            get { return BackingStore?.Get<int?>(nameof(WindowsActiveMalwareCount)); }
            set { BackingStore?.Set(nameof(WindowsActiveMalwareCount), value); }
        }
        /// <summary>The device protection status. This property is read-only.</summary>
        public Microsoft.Graph.Beta.Models.WindowsProtectionState WindowsProtectionState {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.WindowsProtectionState>(nameof(WindowsProtectionState)); }
            set { BackingStore?.Set(nameof(WindowsProtectionState), value); }
        }
        /// <summary>Count of remediated malware for this windows device. This property is read-only.</summary>
        public int? WindowsRemediatedMalwareCount {
            get { return BackingStore?.Get<int?>(nameof(WindowsRemediatedMalwareCount)); }
            set { BackingStore?.Set(nameof(WindowsRemediatedMalwareCount), value); }
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
                "#microsoft.graph.managedDevice" => new ManagedDevice(),
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
