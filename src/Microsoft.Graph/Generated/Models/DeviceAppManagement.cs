using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class DeviceAppManagement : Entity, IParsable {
        /// <summary>Android managed app policies.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<AndroidManagedAppProtection>? AndroidManagedAppProtections {
            get { return BackingStore?.Get<List<AndroidManagedAppProtection>?>("androidManagedAppProtections"); }
            set { BackingStore?.Set("androidManagedAppProtections", value); }
        }
#else
        public List<AndroidManagedAppProtection> AndroidManagedAppProtections {
            get { return BackingStore?.Get<List<AndroidManagedAppProtection>>("androidManagedAppProtections"); }
            set { BackingStore?.Set("androidManagedAppProtections", value); }
        }
#endif
        /// <summary>Default managed app policies.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<DefaultManagedAppProtection>? DefaultManagedAppProtections {
            get { return BackingStore?.Get<List<DefaultManagedAppProtection>?>("defaultManagedAppProtections"); }
            set { BackingStore?.Set("defaultManagedAppProtections", value); }
        }
#else
        public List<DefaultManagedAppProtection> DefaultManagedAppProtections {
            get { return BackingStore?.Get<List<DefaultManagedAppProtection>>("defaultManagedAppProtections"); }
            set { BackingStore?.Set("defaultManagedAppProtections", value); }
        }
#endif
        /// <summary>Device app management tasks.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<DeviceAppManagementTask>? DeviceAppManagementTasks {
            get { return BackingStore?.Get<List<DeviceAppManagementTask>?>("deviceAppManagementTasks"); }
            set { BackingStore?.Set("deviceAppManagementTasks", value); }
        }
#else
        public List<DeviceAppManagementTask> DeviceAppManagementTasks {
            get { return BackingStore?.Get<List<DeviceAppManagementTask>>("deviceAppManagementTasks"); }
            set { BackingStore?.Set("deviceAppManagementTasks", value); }
        }
#endif
        /// <summary>The Windows Enterprise Code Signing Certificate.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<EnterpriseCodeSigningCertificate>? EnterpriseCodeSigningCertificates {
            get { return BackingStore?.Get<List<EnterpriseCodeSigningCertificate>?>("enterpriseCodeSigningCertificates"); }
            set { BackingStore?.Set("enterpriseCodeSigningCertificates", value); }
        }
#else
        public List<EnterpriseCodeSigningCertificate> EnterpriseCodeSigningCertificates {
            get { return BackingStore?.Get<List<EnterpriseCodeSigningCertificate>>("enterpriseCodeSigningCertificates"); }
            set { BackingStore?.Set("enterpriseCodeSigningCertificates", value); }
        }
#endif
        /// <summary>The IOS Lob App Provisioning Configurations.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<IosLobAppProvisioningConfiguration>? IosLobAppProvisioningConfigurations {
            get { return BackingStore?.Get<List<IosLobAppProvisioningConfiguration>?>("iosLobAppProvisioningConfigurations"); }
            set { BackingStore?.Set("iosLobAppProvisioningConfigurations", value); }
        }
#else
        public List<IosLobAppProvisioningConfiguration> IosLobAppProvisioningConfigurations {
            get { return BackingStore?.Get<List<IosLobAppProvisioningConfiguration>>("iosLobAppProvisioningConfigurations"); }
            set { BackingStore?.Set("iosLobAppProvisioningConfigurations", value); }
        }
#endif
        /// <summary>iOS managed app policies.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<IosManagedAppProtection>? IosManagedAppProtections {
            get { return BackingStore?.Get<List<IosManagedAppProtection>?>("iosManagedAppProtections"); }
            set { BackingStore?.Set("iosManagedAppProtections", value); }
        }
#else
        public List<IosManagedAppProtection> IosManagedAppProtections {
            get { return BackingStore?.Get<List<IosManagedAppProtection>>("iosManagedAppProtections"); }
            set { BackingStore?.Set("iosManagedAppProtections", value); }
        }
#endif
        /// <summary>Whether the account is enabled for syncing applications from the Microsoft Store for Business.</summary>
        public bool? IsEnabledForMicrosoftStoreForBusiness {
            get { return BackingStore?.Get<bool?>("isEnabledForMicrosoftStoreForBusiness"); }
            set { BackingStore?.Set("isEnabledForMicrosoftStoreForBusiness", value); }
        }
        /// <summary>Managed app policies.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<ManagedAppPolicy>? ManagedAppPolicies {
            get { return BackingStore?.Get<List<ManagedAppPolicy>?>("managedAppPolicies"); }
            set { BackingStore?.Set("managedAppPolicies", value); }
        }
#else
        public List<ManagedAppPolicy> ManagedAppPolicies {
            get { return BackingStore?.Get<List<ManagedAppPolicy>>("managedAppPolicies"); }
            set { BackingStore?.Set("managedAppPolicies", value); }
        }
#endif
        /// <summary>The managed app registrations.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<ManagedAppRegistration>? ManagedAppRegistrations {
            get { return BackingStore?.Get<List<ManagedAppRegistration>?>("managedAppRegistrations"); }
            set { BackingStore?.Set("managedAppRegistrations", value); }
        }
#else
        public List<ManagedAppRegistration> ManagedAppRegistrations {
            get { return BackingStore?.Get<List<ManagedAppRegistration>>("managedAppRegistrations"); }
            set { BackingStore?.Set("managedAppRegistrations", value); }
        }
#endif
        /// <summary>The managed app statuses.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<ManagedAppStatus>? ManagedAppStatuses {
            get { return BackingStore?.Get<List<ManagedAppStatus>?>("managedAppStatuses"); }
            set { BackingStore?.Set("managedAppStatuses", value); }
        }
#else
        public List<ManagedAppStatus> ManagedAppStatuses {
            get { return BackingStore?.Get<List<ManagedAppStatus>>("managedAppStatuses"); }
            set { BackingStore?.Set("managedAppStatuses", value); }
        }
#endif
        /// <summary>The mobile eBook categories.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<ManagedEBookCategory>? ManagedEBookCategories {
            get { return BackingStore?.Get<List<ManagedEBookCategory>?>("managedEBookCategories"); }
            set { BackingStore?.Set("managedEBookCategories", value); }
        }
#else
        public List<ManagedEBookCategory> ManagedEBookCategories {
            get { return BackingStore?.Get<List<ManagedEBookCategory>>("managedEBookCategories"); }
            set { BackingStore?.Set("managedEBookCategories", value); }
        }
#endif
        /// <summary>The Managed eBook.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<ManagedEBook>? ManagedEBooks {
            get { return BackingStore?.Get<List<ManagedEBook>?>("managedEBooks"); }
            set { BackingStore?.Set("managedEBooks", value); }
        }
#else
        public List<ManagedEBook> ManagedEBooks {
            get { return BackingStore?.Get<List<ManagedEBook>>("managedEBooks"); }
            set { BackingStore?.Set("managedEBooks", value); }
        }
#endif
        /// <summary>Windows information protection for apps running on devices which are MDM enrolled.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<MdmWindowsInformationProtectionPolicy>? MdmWindowsInformationProtectionPolicies {
            get { return BackingStore?.Get<List<MdmWindowsInformationProtectionPolicy>?>("mdmWindowsInformationProtectionPolicies"); }
            set { BackingStore?.Set("mdmWindowsInformationProtectionPolicies", value); }
        }
#else
        public List<MdmWindowsInformationProtectionPolicy> MdmWindowsInformationProtectionPolicies {
            get { return BackingStore?.Get<List<MdmWindowsInformationProtectionPolicy>>("mdmWindowsInformationProtectionPolicies"); }
            set { BackingStore?.Set("mdmWindowsInformationProtectionPolicies", value); }
        }
#endif
        /// <summary>The locale information used to sync applications from the Microsoft Store for Business. Cultures that are specific to a country/region. The names of these cultures follow RFC 4646 (Windows Vista and later). The format is -&lt;country/regioncode2&gt;, where  is a lowercase two-letter code derived from ISO 639-1 and &lt;country/regioncode2&gt; is an uppercase two-letter code derived from ISO 3166. For example, en-US for English (United States) is a specific culture.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? MicrosoftStoreForBusinessLanguage {
            get { return BackingStore?.Get<string?>("microsoftStoreForBusinessLanguage"); }
            set { BackingStore?.Set("microsoftStoreForBusinessLanguage", value); }
        }
#else
        public string MicrosoftStoreForBusinessLanguage {
            get { return BackingStore?.Get<string>("microsoftStoreForBusinessLanguage"); }
            set { BackingStore?.Set("microsoftStoreForBusinessLanguage", value); }
        }
#endif
        /// <summary>The last time an application sync from the Microsoft Store for Business was completed.</summary>
        public DateTimeOffset? MicrosoftStoreForBusinessLastCompletedApplicationSyncTime {
            get { return BackingStore?.Get<DateTimeOffset?>("microsoftStoreForBusinessLastCompletedApplicationSyncTime"); }
            set { BackingStore?.Set("microsoftStoreForBusinessLastCompletedApplicationSyncTime", value); }
        }
        /// <summary>The last time the apps from the Microsoft Store for Business were synced successfully for the account.</summary>
        public DateTimeOffset? MicrosoftStoreForBusinessLastSuccessfulSyncDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("microsoftStoreForBusinessLastSuccessfulSyncDateTime"); }
            set { BackingStore?.Set("microsoftStoreForBusinessLastSuccessfulSyncDateTime", value); }
        }
        /// <summary>Portal to which admin syncs available Microsoft Store for Business apps. This is available in the Intune Admin Console.</summary>
        public MicrosoftStoreForBusinessPortalSelectionOptions? MicrosoftStoreForBusinessPortalSelection {
            get { return BackingStore?.Get<MicrosoftStoreForBusinessPortalSelectionOptions?>("microsoftStoreForBusinessPortalSelection"); }
            set { BackingStore?.Set("microsoftStoreForBusinessPortalSelection", value); }
        }
        /// <summary>The mobile app categories.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<MobileAppCategory>? MobileAppCategories {
            get { return BackingStore?.Get<List<MobileAppCategory>?>("mobileAppCategories"); }
            set { BackingStore?.Set("mobileAppCategories", value); }
        }
#else
        public List<MobileAppCategory> MobileAppCategories {
            get { return BackingStore?.Get<List<MobileAppCategory>>("mobileAppCategories"); }
            set { BackingStore?.Set("mobileAppCategories", value); }
        }
#endif
        /// <summary>The Managed Device Mobile Application Configurations.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<ManagedDeviceMobileAppConfiguration>? MobileAppConfigurations {
            get { return BackingStore?.Get<List<ManagedDeviceMobileAppConfiguration>?>("mobileAppConfigurations"); }
            set { BackingStore?.Set("mobileAppConfigurations", value); }
        }
#else
        public List<ManagedDeviceMobileAppConfiguration> MobileAppConfigurations {
            get { return BackingStore?.Get<List<ManagedDeviceMobileAppConfiguration>>("mobileAppConfigurations"); }
            set { BackingStore?.Set("mobileAppConfigurations", value); }
        }
#endif
        /// <summary>The mobile apps.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<MobileApp>? MobileApps {
            get { return BackingStore?.Get<List<MobileApp>?>("mobileApps"); }
            set { BackingStore?.Set("mobileApps", value); }
        }
#else
        public List<MobileApp> MobileApps {
            get { return BackingStore?.Get<List<MobileApp>>("mobileApps"); }
            set { BackingStore?.Set("mobileApps", value); }
        }
#endif
        /// <summary>The PolicySet of Policies and Applications</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<PolicySet>? PolicySets {
            get { return BackingStore?.Get<List<PolicySet>?>("policySets"); }
            set { BackingStore?.Set("policySets", value); }
        }
#else
        public List<PolicySet> PolicySets {
            get { return BackingStore?.Get<List<PolicySet>>("policySets"); }
            set { BackingStore?.Set("policySets", value); }
        }
#endif
        /// <summary>The WinPhone Symantec Code Signing Certificate.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public Microsoft.Graph.Beta.Models.SymantecCodeSigningCertificate? SymantecCodeSigningCertificate {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.SymantecCodeSigningCertificate?>("symantecCodeSigningCertificate"); }
            set { BackingStore?.Set("symantecCodeSigningCertificate", value); }
        }
#else
        public Microsoft.Graph.Beta.Models.SymantecCodeSigningCertificate SymantecCodeSigningCertificate {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.SymantecCodeSigningCertificate>("symantecCodeSigningCertificate"); }
            set { BackingStore?.Set("symantecCodeSigningCertificate", value); }
        }
#endif
        /// <summary>Targeted managed app configurations.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<TargetedManagedAppConfiguration>? TargetedManagedAppConfigurations {
            get { return BackingStore?.Get<List<TargetedManagedAppConfiguration>?>("targetedManagedAppConfigurations"); }
            set { BackingStore?.Set("targetedManagedAppConfigurations", value); }
        }
#else
        public List<TargetedManagedAppConfiguration> TargetedManagedAppConfigurations {
            get { return BackingStore?.Get<List<TargetedManagedAppConfiguration>>("targetedManagedAppConfigurations"); }
            set { BackingStore?.Set("targetedManagedAppConfigurations", value); }
        }
#endif
        /// <summary>List of Vpp tokens for this organization.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<VppToken>? VppTokens {
            get { return BackingStore?.Get<List<VppToken>?>("vppTokens"); }
            set { BackingStore?.Set("vppTokens", value); }
        }
#else
        public List<VppToken> VppTokens {
            get { return BackingStore?.Get<List<VppToken>>("vppTokens"); }
            set { BackingStore?.Set("vppTokens", value); }
        }
#endif
        /// <summary>The collection of Windows Defender Application Control Supplemental Policies.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<WindowsDefenderApplicationControlSupplementalPolicy>? WdacSupplementalPolicies {
            get { return BackingStore?.Get<List<WindowsDefenderApplicationControlSupplementalPolicy>?>("wdacSupplementalPolicies"); }
            set { BackingStore?.Set("wdacSupplementalPolicies", value); }
        }
#else
        public List<WindowsDefenderApplicationControlSupplementalPolicy> WdacSupplementalPolicies {
            get { return BackingStore?.Get<List<WindowsDefenderApplicationControlSupplementalPolicy>>("wdacSupplementalPolicies"); }
            set { BackingStore?.Set("wdacSupplementalPolicies", value); }
        }
#endif
        /// <summary>Windows information protection device registrations that are not MDM enrolled.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<WindowsInformationProtectionDeviceRegistration>? WindowsInformationProtectionDeviceRegistrations {
            get { return BackingStore?.Get<List<WindowsInformationProtectionDeviceRegistration>?>("windowsInformationProtectionDeviceRegistrations"); }
            set { BackingStore?.Set("windowsInformationProtectionDeviceRegistrations", value); }
        }
#else
        public List<WindowsInformationProtectionDeviceRegistration> WindowsInformationProtectionDeviceRegistrations {
            get { return BackingStore?.Get<List<WindowsInformationProtectionDeviceRegistration>>("windowsInformationProtectionDeviceRegistrations"); }
            set { BackingStore?.Set("windowsInformationProtectionDeviceRegistrations", value); }
        }
#endif
        /// <summary>Windows information protection for apps running on devices which are not MDM enrolled.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<WindowsInformationProtectionPolicy>? WindowsInformationProtectionPolicies {
            get { return BackingStore?.Get<List<WindowsInformationProtectionPolicy>?>("windowsInformationProtectionPolicies"); }
            set { BackingStore?.Set("windowsInformationProtectionPolicies", value); }
        }
#else
        public List<WindowsInformationProtectionPolicy> WindowsInformationProtectionPolicies {
            get { return BackingStore?.Get<List<WindowsInformationProtectionPolicy>>("windowsInformationProtectionPolicies"); }
            set { BackingStore?.Set("windowsInformationProtectionPolicies", value); }
        }
#endif
        /// <summary>Windows information protection wipe actions.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<WindowsInformationProtectionWipeAction>? WindowsInformationProtectionWipeActions {
            get { return BackingStore?.Get<List<WindowsInformationProtectionWipeAction>?>("windowsInformationProtectionWipeActions"); }
            set { BackingStore?.Set("windowsInformationProtectionWipeActions", value); }
        }
#else
        public List<WindowsInformationProtectionWipeAction> WindowsInformationProtectionWipeActions {
            get { return BackingStore?.Get<List<WindowsInformationProtectionWipeAction>>("windowsInformationProtectionWipeActions"); }
            set { BackingStore?.Set("windowsInformationProtectionWipeActions", value); }
        }
#endif
        /// <summary>Windows managed app policies.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<WindowsManagedAppProtection>? WindowsManagedAppProtections {
            get { return BackingStore?.Get<List<WindowsManagedAppProtection>?>("windowsManagedAppProtections"); }
            set { BackingStore?.Set("windowsManagedAppProtections", value); }
        }
#else
        public List<WindowsManagedAppProtection> WindowsManagedAppProtections {
            get { return BackingStore?.Get<List<WindowsManagedAppProtection>>("windowsManagedAppProtections"); }
            set { BackingStore?.Set("windowsManagedAppProtections", value); }
        }
#endif
        /// <summary>Windows management app.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public Microsoft.Graph.Beta.Models.WindowsManagementApp? WindowsManagementApp {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.WindowsManagementApp?>("windowsManagementApp"); }
            set { BackingStore?.Set("windowsManagementApp", value); }
        }
#else
        public Microsoft.Graph.Beta.Models.WindowsManagementApp WindowsManagementApp {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.WindowsManagementApp>("windowsManagementApp"); }
            set { BackingStore?.Set("windowsManagementApp", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DeviceAppManagement CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceAppManagement();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"androidManagedAppProtections", n => { AndroidManagedAppProtections = n.GetCollectionOfObjectValues<AndroidManagedAppProtection>(AndroidManagedAppProtection.CreateFromDiscriminatorValue)?.ToList(); } },
                {"defaultManagedAppProtections", n => { DefaultManagedAppProtections = n.GetCollectionOfObjectValues<DefaultManagedAppProtection>(DefaultManagedAppProtection.CreateFromDiscriminatorValue)?.ToList(); } },
                {"deviceAppManagementTasks", n => { DeviceAppManagementTasks = n.GetCollectionOfObjectValues<DeviceAppManagementTask>(DeviceAppManagementTask.CreateFromDiscriminatorValue)?.ToList(); } },
                {"enterpriseCodeSigningCertificates", n => { EnterpriseCodeSigningCertificates = n.GetCollectionOfObjectValues<EnterpriseCodeSigningCertificate>(EnterpriseCodeSigningCertificate.CreateFromDiscriminatorValue)?.ToList(); } },
                {"iosLobAppProvisioningConfigurations", n => { IosLobAppProvisioningConfigurations = n.GetCollectionOfObjectValues<IosLobAppProvisioningConfiguration>(IosLobAppProvisioningConfiguration.CreateFromDiscriminatorValue)?.ToList(); } },
                {"iosManagedAppProtections", n => { IosManagedAppProtections = n.GetCollectionOfObjectValues<IosManagedAppProtection>(IosManagedAppProtection.CreateFromDiscriminatorValue)?.ToList(); } },
                {"isEnabledForMicrosoftStoreForBusiness", n => { IsEnabledForMicrosoftStoreForBusiness = n.GetBoolValue(); } },
                {"managedAppPolicies", n => { ManagedAppPolicies = n.GetCollectionOfObjectValues<ManagedAppPolicy>(ManagedAppPolicy.CreateFromDiscriminatorValue)?.ToList(); } },
                {"managedAppRegistrations", n => { ManagedAppRegistrations = n.GetCollectionOfObjectValues<ManagedAppRegistration>(ManagedAppRegistration.CreateFromDiscriminatorValue)?.ToList(); } },
                {"managedAppStatuses", n => { ManagedAppStatuses = n.GetCollectionOfObjectValues<ManagedAppStatus>(ManagedAppStatus.CreateFromDiscriminatorValue)?.ToList(); } },
                {"managedEBookCategories", n => { ManagedEBookCategories = n.GetCollectionOfObjectValues<ManagedEBookCategory>(ManagedEBookCategory.CreateFromDiscriminatorValue)?.ToList(); } },
                {"managedEBooks", n => { ManagedEBooks = n.GetCollectionOfObjectValues<ManagedEBook>(ManagedEBook.CreateFromDiscriminatorValue)?.ToList(); } },
                {"mdmWindowsInformationProtectionPolicies", n => { MdmWindowsInformationProtectionPolicies = n.GetCollectionOfObjectValues<MdmWindowsInformationProtectionPolicy>(MdmWindowsInformationProtectionPolicy.CreateFromDiscriminatorValue)?.ToList(); } },
                {"microsoftStoreForBusinessLanguage", n => { MicrosoftStoreForBusinessLanguage = n.GetStringValue(); } },
                {"microsoftStoreForBusinessLastCompletedApplicationSyncTime", n => { MicrosoftStoreForBusinessLastCompletedApplicationSyncTime = n.GetDateTimeOffsetValue(); } },
                {"microsoftStoreForBusinessLastSuccessfulSyncDateTime", n => { MicrosoftStoreForBusinessLastSuccessfulSyncDateTime = n.GetDateTimeOffsetValue(); } },
                {"microsoftStoreForBusinessPortalSelection", n => { MicrosoftStoreForBusinessPortalSelection = n.GetEnumValue<MicrosoftStoreForBusinessPortalSelectionOptions>(); } },
                {"mobileAppCategories", n => { MobileAppCategories = n.GetCollectionOfObjectValues<MobileAppCategory>(MobileAppCategory.CreateFromDiscriminatorValue)?.ToList(); } },
                {"mobileAppConfigurations", n => { MobileAppConfigurations = n.GetCollectionOfObjectValues<ManagedDeviceMobileAppConfiguration>(ManagedDeviceMobileAppConfiguration.CreateFromDiscriminatorValue)?.ToList(); } },
                {"mobileApps", n => { MobileApps = n.GetCollectionOfObjectValues<MobileApp>(MobileApp.CreateFromDiscriminatorValue)?.ToList(); } },
                {"policySets", n => { PolicySets = n.GetCollectionOfObjectValues<PolicySet>(PolicySet.CreateFromDiscriminatorValue)?.ToList(); } },
                {"symantecCodeSigningCertificate", n => { SymantecCodeSigningCertificate = n.GetObjectValue<Microsoft.Graph.Beta.Models.SymantecCodeSigningCertificate>(Microsoft.Graph.Beta.Models.SymantecCodeSigningCertificate.CreateFromDiscriminatorValue); } },
                {"targetedManagedAppConfigurations", n => { TargetedManagedAppConfigurations = n.GetCollectionOfObjectValues<TargetedManagedAppConfiguration>(TargetedManagedAppConfiguration.CreateFromDiscriminatorValue)?.ToList(); } },
                {"vppTokens", n => { VppTokens = n.GetCollectionOfObjectValues<VppToken>(VppToken.CreateFromDiscriminatorValue)?.ToList(); } },
                {"wdacSupplementalPolicies", n => { WdacSupplementalPolicies = n.GetCollectionOfObjectValues<WindowsDefenderApplicationControlSupplementalPolicy>(WindowsDefenderApplicationControlSupplementalPolicy.CreateFromDiscriminatorValue)?.ToList(); } },
                {"windowsInformationProtectionDeviceRegistrations", n => { WindowsInformationProtectionDeviceRegistrations = n.GetCollectionOfObjectValues<WindowsInformationProtectionDeviceRegistration>(WindowsInformationProtectionDeviceRegistration.CreateFromDiscriminatorValue)?.ToList(); } },
                {"windowsInformationProtectionPolicies", n => { WindowsInformationProtectionPolicies = n.GetCollectionOfObjectValues<WindowsInformationProtectionPolicy>(WindowsInformationProtectionPolicy.CreateFromDiscriminatorValue)?.ToList(); } },
                {"windowsInformationProtectionWipeActions", n => { WindowsInformationProtectionWipeActions = n.GetCollectionOfObjectValues<WindowsInformationProtectionWipeAction>(WindowsInformationProtectionWipeAction.CreateFromDiscriminatorValue)?.ToList(); } },
                {"windowsManagedAppProtections", n => { WindowsManagedAppProtections = n.GetCollectionOfObjectValues<WindowsManagedAppProtection>(WindowsManagedAppProtection.CreateFromDiscriminatorValue)?.ToList(); } },
                {"windowsManagementApp", n => { WindowsManagementApp = n.GetObjectValue<Microsoft.Graph.Beta.Models.WindowsManagementApp>(Microsoft.Graph.Beta.Models.WindowsManagementApp.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<AndroidManagedAppProtection>("androidManagedAppProtections", AndroidManagedAppProtections);
            writer.WriteCollectionOfObjectValues<DefaultManagedAppProtection>("defaultManagedAppProtections", DefaultManagedAppProtections);
            writer.WriteCollectionOfObjectValues<DeviceAppManagementTask>("deviceAppManagementTasks", DeviceAppManagementTasks);
            writer.WriteCollectionOfObjectValues<EnterpriseCodeSigningCertificate>("enterpriseCodeSigningCertificates", EnterpriseCodeSigningCertificates);
            writer.WriteCollectionOfObjectValues<IosLobAppProvisioningConfiguration>("iosLobAppProvisioningConfigurations", IosLobAppProvisioningConfigurations);
            writer.WriteCollectionOfObjectValues<IosManagedAppProtection>("iosManagedAppProtections", IosManagedAppProtections);
            writer.WriteBoolValue("isEnabledForMicrosoftStoreForBusiness", IsEnabledForMicrosoftStoreForBusiness);
            writer.WriteCollectionOfObjectValues<ManagedAppPolicy>("managedAppPolicies", ManagedAppPolicies);
            writer.WriteCollectionOfObjectValues<ManagedAppRegistration>("managedAppRegistrations", ManagedAppRegistrations);
            writer.WriteCollectionOfObjectValues<ManagedAppStatus>("managedAppStatuses", ManagedAppStatuses);
            writer.WriteCollectionOfObjectValues<ManagedEBookCategory>("managedEBookCategories", ManagedEBookCategories);
            writer.WriteCollectionOfObjectValues<ManagedEBook>("managedEBooks", ManagedEBooks);
            writer.WriteCollectionOfObjectValues<MdmWindowsInformationProtectionPolicy>("mdmWindowsInformationProtectionPolicies", MdmWindowsInformationProtectionPolicies);
            writer.WriteStringValue("microsoftStoreForBusinessLanguage", MicrosoftStoreForBusinessLanguage);
            writer.WriteDateTimeOffsetValue("microsoftStoreForBusinessLastCompletedApplicationSyncTime", MicrosoftStoreForBusinessLastCompletedApplicationSyncTime);
            writer.WriteDateTimeOffsetValue("microsoftStoreForBusinessLastSuccessfulSyncDateTime", MicrosoftStoreForBusinessLastSuccessfulSyncDateTime);
            writer.WriteEnumValue<MicrosoftStoreForBusinessPortalSelectionOptions>("microsoftStoreForBusinessPortalSelection", MicrosoftStoreForBusinessPortalSelection);
            writer.WriteCollectionOfObjectValues<MobileAppCategory>("mobileAppCategories", MobileAppCategories);
            writer.WriteCollectionOfObjectValues<ManagedDeviceMobileAppConfiguration>("mobileAppConfigurations", MobileAppConfigurations);
            writer.WriteCollectionOfObjectValues<MobileApp>("mobileApps", MobileApps);
            writer.WriteCollectionOfObjectValues<PolicySet>("policySets", PolicySets);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.SymantecCodeSigningCertificate>("symantecCodeSigningCertificate", SymantecCodeSigningCertificate);
            writer.WriteCollectionOfObjectValues<TargetedManagedAppConfiguration>("targetedManagedAppConfigurations", TargetedManagedAppConfigurations);
            writer.WriteCollectionOfObjectValues<VppToken>("vppTokens", VppTokens);
            writer.WriteCollectionOfObjectValues<WindowsDefenderApplicationControlSupplementalPolicy>("wdacSupplementalPolicies", WdacSupplementalPolicies);
            writer.WriteCollectionOfObjectValues<WindowsInformationProtectionDeviceRegistration>("windowsInformationProtectionDeviceRegistrations", WindowsInformationProtectionDeviceRegistrations);
            writer.WriteCollectionOfObjectValues<WindowsInformationProtectionPolicy>("windowsInformationProtectionPolicies", WindowsInformationProtectionPolicies);
            writer.WriteCollectionOfObjectValues<WindowsInformationProtectionWipeAction>("windowsInformationProtectionWipeActions", WindowsInformationProtectionWipeActions);
            writer.WriteCollectionOfObjectValues<WindowsManagedAppProtection>("windowsManagedAppProtections", WindowsManagedAppProtections);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.WindowsManagementApp>("windowsManagementApp", WindowsManagementApp);
        }
    }
}
