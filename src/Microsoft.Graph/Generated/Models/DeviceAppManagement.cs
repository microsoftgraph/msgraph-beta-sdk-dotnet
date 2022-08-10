using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Singleton entity that acts as a container for all device app management functionality.</summary>
    public class DeviceAppManagement : Entity, IParsable {
        /// <summary>Android managed app policies.</summary>
        public List<AndroidManagedAppProtection> AndroidManagedAppProtections {
            get { return BackingStore?.Get<List<AndroidManagedAppProtection>>("androidManagedAppProtections"); }
            set { BackingStore?.Set("androidManagedAppProtections", value); }
        }
        /// <summary>Default managed app policies.</summary>
        public List<DefaultManagedAppProtection> DefaultManagedAppProtections {
            get { return BackingStore?.Get<List<DefaultManagedAppProtection>>("defaultManagedAppProtections"); }
            set { BackingStore?.Set("defaultManagedAppProtections", value); }
        }
        /// <summary>Device app management tasks.</summary>
        public List<DeviceAppManagementTask> DeviceAppManagementTasks {
            get { return BackingStore?.Get<List<DeviceAppManagementTask>>("deviceAppManagementTasks"); }
            set { BackingStore?.Set("deviceAppManagementTasks", value); }
        }
        /// <summary>The Windows Enterprise Code Signing Certificate.</summary>
        public List<EnterpriseCodeSigningCertificate> EnterpriseCodeSigningCertificates {
            get { return BackingStore?.Get<List<EnterpriseCodeSigningCertificate>>("enterpriseCodeSigningCertificates"); }
            set { BackingStore?.Set("enterpriseCodeSigningCertificates", value); }
        }
        /// <summary>The IOS Lob App Provisioning Configurations.</summary>
        public List<IosLobAppProvisioningConfiguration> IosLobAppProvisioningConfigurations {
            get { return BackingStore?.Get<List<IosLobAppProvisioningConfiguration>>("iosLobAppProvisioningConfigurations"); }
            set { BackingStore?.Set("iosLobAppProvisioningConfigurations", value); }
        }
        /// <summary>iOS managed app policies.</summary>
        public List<IosManagedAppProtection> IosManagedAppProtections {
            get { return BackingStore?.Get<List<IosManagedAppProtection>>("iosManagedAppProtections"); }
            set { BackingStore?.Set("iosManagedAppProtections", value); }
        }
        /// <summary>Whether the account is enabled for syncing applications from the Microsoft Store for Business.</summary>
        public bool? IsEnabledForMicrosoftStoreForBusiness {
            get { return BackingStore?.Get<bool?>("isEnabledForMicrosoftStoreForBusiness"); }
            set { BackingStore?.Set("isEnabledForMicrosoftStoreForBusiness", value); }
        }
        /// <summary>Managed app policies.</summary>
        public List<ManagedAppPolicy> ManagedAppPolicies {
            get { return BackingStore?.Get<List<ManagedAppPolicy>>("managedAppPolicies"); }
            set { BackingStore?.Set("managedAppPolicies", value); }
        }
        /// <summary>The managed app registrations.</summary>
        public List<ManagedAppRegistration> ManagedAppRegistrations {
            get { return BackingStore?.Get<List<ManagedAppRegistration>>("managedAppRegistrations"); }
            set { BackingStore?.Set("managedAppRegistrations", value); }
        }
        /// <summary>The managed app statuses.</summary>
        public List<ManagedAppStatus> ManagedAppStatuses {
            get { return BackingStore?.Get<List<ManagedAppStatus>>("managedAppStatuses"); }
            set { BackingStore?.Set("managedAppStatuses", value); }
        }
        /// <summary>The mobile eBook categories.</summary>
        public List<ManagedEBookCategory> ManagedEBookCategories {
            get { return BackingStore?.Get<List<ManagedEBookCategory>>("managedEBookCategories"); }
            set { BackingStore?.Set("managedEBookCategories", value); }
        }
        /// <summary>The Managed eBook.</summary>
        public List<ManagedEBook> ManagedEBooks {
            get { return BackingStore?.Get<List<ManagedEBook>>("managedEBooks"); }
            set { BackingStore?.Set("managedEBooks", value); }
        }
        /// <summary>Windows information protection for apps running on devices which are MDM enrolled.</summary>
        public List<MdmWindowsInformationProtectionPolicy> MdmWindowsInformationProtectionPolicies {
            get { return BackingStore?.Get<List<MdmWindowsInformationProtectionPolicy>>("mdmWindowsInformationProtectionPolicies"); }
            set { BackingStore?.Set("mdmWindowsInformationProtectionPolicies", value); }
        }
        /// <summary>The locale information used to sync applications from the Microsoft Store for Business. Cultures that are specific to a country/region. The names of these cultures follow RFC 4646 (Windows Vista and later). The format is -&lt;country/regioncode2&gt;, where  is a lowercase two-letter code derived from ISO 639-1 and &lt;country/regioncode2&gt; is an uppercase two-letter code derived from ISO 3166. For example, en-US for English (United States) is a specific culture.</summary>
        public string MicrosoftStoreForBusinessLanguage {
            get { return BackingStore?.Get<string>("microsoftStoreForBusinessLanguage"); }
            set { BackingStore?.Set("microsoftStoreForBusinessLanguage", value); }
        }
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
        public List<MobileAppCategory> MobileAppCategories {
            get { return BackingStore?.Get<List<MobileAppCategory>>("mobileAppCategories"); }
            set { BackingStore?.Set("mobileAppCategories", value); }
        }
        /// <summary>The Managed Device Mobile Application Configurations.</summary>
        public List<ManagedDeviceMobileAppConfiguration> MobileAppConfigurations {
            get { return BackingStore?.Get<List<ManagedDeviceMobileAppConfiguration>>("mobileAppConfigurations"); }
            set { BackingStore?.Set("mobileAppConfigurations", value); }
        }
        /// <summary>The mobile apps.</summary>
        public List<MobileApp> MobileApps {
            get { return BackingStore?.Get<List<MobileApp>>("mobileApps"); }
            set { BackingStore?.Set("mobileApps", value); }
        }
        /// <summary>The PolicySet of Policies and Applications</summary>
        public List<PolicySet> PolicySets {
            get { return BackingStore?.Get<List<PolicySet>>("policySets"); }
            set { BackingStore?.Set("policySets", value); }
        }
        /// <summary>Side Loading Keys that are required for the Windows 8 and 8.1 Apps installation.</summary>
        public List<SideLoadingKey> SideLoadingKeys {
            get { return BackingStore?.Get<List<SideLoadingKey>>("sideLoadingKeys"); }
            set { BackingStore?.Set("sideLoadingKeys", value); }
        }
        /// <summary>The WinPhone Symantec Code Signing Certificate.</summary>
        public Microsoft.Graph.Beta.Models.SymantecCodeSigningCertificate SymantecCodeSigningCertificate {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.SymantecCodeSigningCertificate>("symantecCodeSigningCertificate"); }
            set { BackingStore?.Set("symantecCodeSigningCertificate", value); }
        }
        /// <summary>Targeted managed app configurations.</summary>
        public List<TargetedManagedAppConfiguration> TargetedManagedAppConfigurations {
            get { return BackingStore?.Get<List<TargetedManagedAppConfiguration>>("targetedManagedAppConfigurations"); }
            set { BackingStore?.Set("targetedManagedAppConfigurations", value); }
        }
        /// <summary>List of Vpp tokens for this organization.</summary>
        public List<VppToken> VppTokens {
            get { return BackingStore?.Get<List<VppToken>>("vppTokens"); }
            set { BackingStore?.Set("vppTokens", value); }
        }
        /// <summary>The collection of Windows Defender Application Control Supplemental Policies.</summary>
        public List<WindowsDefenderApplicationControlSupplementalPolicy> WdacSupplementalPolicies {
            get { return BackingStore?.Get<List<WindowsDefenderApplicationControlSupplementalPolicy>>("wdacSupplementalPolicies"); }
            set { BackingStore?.Set("wdacSupplementalPolicies", value); }
        }
        /// <summary>Windows information protection device registrations that are not MDM enrolled.</summary>
        public List<WindowsInformationProtectionDeviceRegistration> WindowsInformationProtectionDeviceRegistrations {
            get { return BackingStore?.Get<List<WindowsInformationProtectionDeviceRegistration>>("windowsInformationProtectionDeviceRegistrations"); }
            set { BackingStore?.Set("windowsInformationProtectionDeviceRegistrations", value); }
        }
        /// <summary>Windows information protection for apps running on devices which are not MDM enrolled.</summary>
        public List<WindowsInformationProtectionPolicy> WindowsInformationProtectionPolicies {
            get { return BackingStore?.Get<List<WindowsInformationProtectionPolicy>>("windowsInformationProtectionPolicies"); }
            set { BackingStore?.Set("windowsInformationProtectionPolicies", value); }
        }
        /// <summary>Windows information protection wipe actions.</summary>
        public List<WindowsInformationProtectionWipeAction> WindowsInformationProtectionWipeActions {
            get { return BackingStore?.Get<List<WindowsInformationProtectionWipeAction>>("windowsInformationProtectionWipeActions"); }
            set { BackingStore?.Set("windowsInformationProtectionWipeActions", value); }
        }
        /// <summary>Windows managed app policies.</summary>
        public List<WindowsManagedAppProtection> WindowsManagedAppProtections {
            get { return BackingStore?.Get<List<WindowsManagedAppProtection>>("windowsManagedAppProtections"); }
            set { BackingStore?.Set("windowsManagedAppProtections", value); }
        }
        /// <summary>Windows management app.</summary>
        public Microsoft.Graph.Beta.Models.WindowsManagementApp WindowsManagementApp {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.WindowsManagementApp>("windowsManagementApp"); }
            set { BackingStore?.Set("windowsManagementApp", value); }
        }
        /// <summary>
        /// Instantiates a new deviceAppManagement and sets the default values.
        /// </summary>
        public DeviceAppManagement() : base() {
            OdataType = "#microsoft.graph.deviceAppManagement";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DeviceAppManagement CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceAppManagement();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"androidManagedAppProtections", n => { AndroidManagedAppProtections = n.GetCollectionOfObjectValues<AndroidManagedAppProtection>(AndroidManagedAppProtection.CreateFromDiscriminatorValue).ToList(); } },
                {"defaultManagedAppProtections", n => { DefaultManagedAppProtections = n.GetCollectionOfObjectValues<DefaultManagedAppProtection>(DefaultManagedAppProtection.CreateFromDiscriminatorValue).ToList(); } },
                {"deviceAppManagementTasks", n => { DeviceAppManagementTasks = n.GetCollectionOfObjectValues<DeviceAppManagementTask>(DeviceAppManagementTask.CreateFromDiscriminatorValue).ToList(); } },
                {"enterpriseCodeSigningCertificates", n => { EnterpriseCodeSigningCertificates = n.GetCollectionOfObjectValues<EnterpriseCodeSigningCertificate>(EnterpriseCodeSigningCertificate.CreateFromDiscriminatorValue).ToList(); } },
                {"iosLobAppProvisioningConfigurations", n => { IosLobAppProvisioningConfigurations = n.GetCollectionOfObjectValues<IosLobAppProvisioningConfiguration>(IosLobAppProvisioningConfiguration.CreateFromDiscriminatorValue).ToList(); } },
                {"iosManagedAppProtections", n => { IosManagedAppProtections = n.GetCollectionOfObjectValues<IosManagedAppProtection>(IosManagedAppProtection.CreateFromDiscriminatorValue).ToList(); } },
                {"isEnabledForMicrosoftStoreForBusiness", n => { IsEnabledForMicrosoftStoreForBusiness = n.GetBoolValue(); } },
                {"managedAppPolicies", n => { ManagedAppPolicies = n.GetCollectionOfObjectValues<ManagedAppPolicy>(ManagedAppPolicy.CreateFromDiscriminatorValue).ToList(); } },
                {"managedAppRegistrations", n => { ManagedAppRegistrations = n.GetCollectionOfObjectValues<ManagedAppRegistration>(ManagedAppRegistration.CreateFromDiscriminatorValue).ToList(); } },
                {"managedAppStatuses", n => { ManagedAppStatuses = n.GetCollectionOfObjectValues<ManagedAppStatus>(ManagedAppStatus.CreateFromDiscriminatorValue).ToList(); } },
                {"managedEBookCategories", n => { ManagedEBookCategories = n.GetCollectionOfObjectValues<ManagedEBookCategory>(ManagedEBookCategory.CreateFromDiscriminatorValue).ToList(); } },
                {"managedEBooks", n => { ManagedEBooks = n.GetCollectionOfObjectValues<ManagedEBook>(ManagedEBook.CreateFromDiscriminatorValue).ToList(); } },
                {"mdmWindowsInformationProtectionPolicies", n => { MdmWindowsInformationProtectionPolicies = n.GetCollectionOfObjectValues<MdmWindowsInformationProtectionPolicy>(MdmWindowsInformationProtectionPolicy.CreateFromDiscriminatorValue).ToList(); } },
                {"microsoftStoreForBusinessLanguage", n => { MicrosoftStoreForBusinessLanguage = n.GetStringValue(); } },
                {"microsoftStoreForBusinessLastCompletedApplicationSyncTime", n => { MicrosoftStoreForBusinessLastCompletedApplicationSyncTime = n.GetDateTimeOffsetValue(); } },
                {"microsoftStoreForBusinessLastSuccessfulSyncDateTime", n => { MicrosoftStoreForBusinessLastSuccessfulSyncDateTime = n.GetDateTimeOffsetValue(); } },
                {"microsoftStoreForBusinessPortalSelection", n => { MicrosoftStoreForBusinessPortalSelection = n.GetEnumValue<MicrosoftStoreForBusinessPortalSelectionOptions>(); } },
                {"mobileAppCategories", n => { MobileAppCategories = n.GetCollectionOfObjectValues<MobileAppCategory>(MobileAppCategory.CreateFromDiscriminatorValue).ToList(); } },
                {"mobileAppConfigurations", n => { MobileAppConfigurations = n.GetCollectionOfObjectValues<ManagedDeviceMobileAppConfiguration>(ManagedDeviceMobileAppConfiguration.CreateFromDiscriminatorValue).ToList(); } },
                {"mobileApps", n => { MobileApps = n.GetCollectionOfObjectValues<MobileApp>(MobileApp.CreateFromDiscriminatorValue).ToList(); } },
                {"policySets", n => { PolicySets = n.GetCollectionOfObjectValues<PolicySet>(PolicySet.CreateFromDiscriminatorValue).ToList(); } },
                {"sideLoadingKeys", n => { SideLoadingKeys = n.GetCollectionOfObjectValues<SideLoadingKey>(SideLoadingKey.CreateFromDiscriminatorValue).ToList(); } },
                {"symantecCodeSigningCertificate", n => { SymantecCodeSigningCertificate = n.GetObjectValue<Microsoft.Graph.Beta.Models.SymantecCodeSigningCertificate>(Microsoft.Graph.Beta.Models.SymantecCodeSigningCertificate.CreateFromDiscriminatorValue); } },
                {"targetedManagedAppConfigurations", n => { TargetedManagedAppConfigurations = n.GetCollectionOfObjectValues<TargetedManagedAppConfiguration>(TargetedManagedAppConfiguration.CreateFromDiscriminatorValue).ToList(); } },
                {"vppTokens", n => { VppTokens = n.GetCollectionOfObjectValues<VppToken>(VppToken.CreateFromDiscriminatorValue).ToList(); } },
                {"wdacSupplementalPolicies", n => { WdacSupplementalPolicies = n.GetCollectionOfObjectValues<WindowsDefenderApplicationControlSupplementalPolicy>(WindowsDefenderApplicationControlSupplementalPolicy.CreateFromDiscriminatorValue).ToList(); } },
                {"windowsInformationProtectionDeviceRegistrations", n => { WindowsInformationProtectionDeviceRegistrations = n.GetCollectionOfObjectValues<WindowsInformationProtectionDeviceRegistration>(WindowsInformationProtectionDeviceRegistration.CreateFromDiscriminatorValue).ToList(); } },
                {"windowsInformationProtectionPolicies", n => { WindowsInformationProtectionPolicies = n.GetCollectionOfObjectValues<WindowsInformationProtectionPolicy>(WindowsInformationProtectionPolicy.CreateFromDiscriminatorValue).ToList(); } },
                {"windowsInformationProtectionWipeActions", n => { WindowsInformationProtectionWipeActions = n.GetCollectionOfObjectValues<WindowsInformationProtectionWipeAction>(WindowsInformationProtectionWipeAction.CreateFromDiscriminatorValue).ToList(); } },
                {"windowsManagedAppProtections", n => { WindowsManagedAppProtections = n.GetCollectionOfObjectValues<WindowsManagedAppProtection>(WindowsManagedAppProtection.CreateFromDiscriminatorValue).ToList(); } },
                {"windowsManagementApp", n => { WindowsManagementApp = n.GetObjectValue<Microsoft.Graph.Beta.Models.WindowsManagementApp>(Microsoft.Graph.Beta.Models.WindowsManagementApp.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
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
            writer.WriteCollectionOfObjectValues<SideLoadingKey>("sideLoadingKeys", SideLoadingKeys);
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
