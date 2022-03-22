using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Singleton entity that acts as a container for all device app management functionality.</summary>
    public class DeviceAppManagement : Entity, IParsable {
        /// <summary>Android managed app policies.</summary>
        public List<AndroidManagedAppProtection> AndroidManagedAppProtections { get; set; }
        /// <summary>Default managed app policies.</summary>
        public List<DefaultManagedAppProtection> DefaultManagedAppProtections { get; set; }
        /// <summary>Device app management tasks.</summary>
        public List<DeviceAppManagementTask> DeviceAppManagementTasks { get; set; }
        /// <summary>The Windows Enterprise Code Signing Certificate.</summary>
        public List<EnterpriseCodeSigningCertificate> EnterpriseCodeSigningCertificates { get; set; }
        /// <summary>The IOS Lob App Provisioning Configurations.</summary>
        public List<IosLobAppProvisioningConfiguration> IosLobAppProvisioningConfigurations { get; set; }
        /// <summary>iOS managed app policies.</summary>
        public List<IosManagedAppProtection> IosManagedAppProtections { get; set; }
        /// <summary>Whether the account is enabled for syncing applications from the Microsoft Store for Business.</summary>
        public bool? IsEnabledForMicrosoftStoreForBusiness { get; set; }
        /// <summary>Managed app policies.</summary>
        public List<ManagedAppPolicy> ManagedAppPolicies { get; set; }
        /// <summary>The managed app registrations.</summary>
        public List<ManagedAppRegistration> ManagedAppRegistrations { get; set; }
        /// <summary>The managed app statuses.</summary>
        public List<ManagedAppStatus> ManagedAppStatuses { get; set; }
        /// <summary>The mobile eBook categories.</summary>
        public List<ManagedEBookCategory> ManagedEBookCategories { get; set; }
        /// <summary>The Managed eBook.</summary>
        public List<ManagedEBook> ManagedEBooks { get; set; }
        /// <summary>Windows information protection for apps running on devices which are MDM enrolled.</summary>
        public List<MdmWindowsInformationProtectionPolicy> MdmWindowsInformationProtectionPolicies { get; set; }
        /// <summary>The locale information used to sync applications from the Microsoft Store for Business. Cultures that are specific to a country/region. The names of these cultures follow RFC 4646 (Windows Vista and later). The format is -<country/regioncode2>, where  is a lowercase two-letter code derived from ISO 639-1 and <country/regioncode2> is an uppercase two-letter code derived from ISO 3166. For example, en-US for English (United States) is a specific culture.</summary>
        public string MicrosoftStoreForBusinessLanguage { get; set; }
        /// <summary>The last time an application sync from the Microsoft Store for Business was completed.</summary>
        public DateTimeOffset? MicrosoftStoreForBusinessLastCompletedApplicationSyncTime { get; set; }
        /// <summary>The last time the apps from the Microsoft Store for Business were synced successfully for the account.</summary>
        public DateTimeOffset? MicrosoftStoreForBusinessLastSuccessfulSyncDateTime { get; set; }
        /// <summary>The end user portal information is used to sync applications from the Microsoft Store for Business to Intune Company Portal. There are three options to pick from ['Company portal only', 'Company portal and private store', 'Private store only']. Possible values are: none, companyPortal, privateStore.</summary>
        public MicrosoftStoreForBusinessPortalSelectionOptions? MicrosoftStoreForBusinessPortalSelection { get; set; }
        /// <summary>The mobile app categories.</summary>
        public List<MobileAppCategory> MobileAppCategories { get; set; }
        /// <summary>The Managed Device Mobile Application Configurations.</summary>
        public List<ManagedDeviceMobileAppConfiguration> MobileAppConfigurations { get; set; }
        /// <summary>The mobile apps.</summary>
        public List<MobileApp> MobileApps { get; set; }
        /// <summary>The PolicySet of Policies and Applications</summary>
        public List<PolicySet> PolicySets { get; set; }
        /// <summary>Side Loading Keys that are required for the Windows 8 and 8.1 Apps installation.</summary>
        public List<SideLoadingKey> SideLoadingKeys { get; set; }
        /// <summary>The WinPhone Symantec Code Signing Certificate.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.SymantecCodeSigningCertificate SymantecCodeSigningCertificate { get; set; }
        /// <summary>Targeted managed app configurations.</summary>
        public List<TargetedManagedAppConfiguration> TargetedManagedAppConfigurations { get; set; }
        /// <summary>List of Vpp tokens for this organization.</summary>
        public List<VppToken> VppTokens { get; set; }
        /// <summary>The collection of Windows Defender Application Control Supplemental Policies.</summary>
        public List<WindowsDefenderApplicationControlSupplementalPolicy> WdacSupplementalPolicies { get; set; }
        /// <summary>Windows information protection device registrations that are not MDM enrolled.</summary>
        public List<WindowsInformationProtectionDeviceRegistration> WindowsInformationProtectionDeviceRegistrations { get; set; }
        /// <summary>Windows information protection for apps running on devices which are not MDM enrolled.</summary>
        public List<WindowsInformationProtectionPolicy> WindowsInformationProtectionPolicies { get; set; }
        /// <summary>Windows information protection wipe actions.</summary>
        public List<WindowsInformationProtectionWipeAction> WindowsInformationProtectionWipeActions { get; set; }
        /// <summary>Windows management app.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.WindowsManagementApp WindowsManagementApp { get; set; }
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
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"androidManagedAppProtections", (o,n) => { (o as DeviceAppManagement).AndroidManagedAppProtections = n.GetCollectionOfObjectValues<AndroidManagedAppProtection>(AndroidManagedAppProtection.CreateFromDiscriminatorValue).ToList(); } },
                {"defaultManagedAppProtections", (o,n) => { (o as DeviceAppManagement).DefaultManagedAppProtections = n.GetCollectionOfObjectValues<DefaultManagedAppProtection>(DefaultManagedAppProtection.CreateFromDiscriminatorValue).ToList(); } },
                {"deviceAppManagementTasks", (o,n) => { (o as DeviceAppManagement).DeviceAppManagementTasks = n.GetCollectionOfObjectValues<DeviceAppManagementTask>(DeviceAppManagementTask.CreateFromDiscriminatorValue).ToList(); } },
                {"enterpriseCodeSigningCertificates", (o,n) => { (o as DeviceAppManagement).EnterpriseCodeSigningCertificates = n.GetCollectionOfObjectValues<EnterpriseCodeSigningCertificate>(EnterpriseCodeSigningCertificate.CreateFromDiscriminatorValue).ToList(); } },
                {"iosLobAppProvisioningConfigurations", (o,n) => { (o as DeviceAppManagement).IosLobAppProvisioningConfigurations = n.GetCollectionOfObjectValues<IosLobAppProvisioningConfiguration>(IosLobAppProvisioningConfiguration.CreateFromDiscriminatorValue).ToList(); } },
                {"iosManagedAppProtections", (o,n) => { (o as DeviceAppManagement).IosManagedAppProtections = n.GetCollectionOfObjectValues<IosManagedAppProtection>(IosManagedAppProtection.CreateFromDiscriminatorValue).ToList(); } },
                {"isEnabledForMicrosoftStoreForBusiness", (o,n) => { (o as DeviceAppManagement).IsEnabledForMicrosoftStoreForBusiness = n.GetBoolValue(); } },
                {"managedAppPolicies", (o,n) => { (o as DeviceAppManagement).ManagedAppPolicies = n.GetCollectionOfObjectValues<ManagedAppPolicy>(ManagedAppPolicy.CreateFromDiscriminatorValue).ToList(); } },
                {"managedAppRegistrations", (o,n) => { (o as DeviceAppManagement).ManagedAppRegistrations = n.GetCollectionOfObjectValues<ManagedAppRegistration>(ManagedAppRegistration.CreateFromDiscriminatorValue).ToList(); } },
                {"managedAppStatuses", (o,n) => { (o as DeviceAppManagement).ManagedAppStatuses = n.GetCollectionOfObjectValues<ManagedAppStatus>(ManagedAppStatus.CreateFromDiscriminatorValue).ToList(); } },
                {"managedEBookCategories", (o,n) => { (o as DeviceAppManagement).ManagedEBookCategories = n.GetCollectionOfObjectValues<ManagedEBookCategory>(ManagedEBookCategory.CreateFromDiscriminatorValue).ToList(); } },
                {"managedEBooks", (o,n) => { (o as DeviceAppManagement).ManagedEBooks = n.GetCollectionOfObjectValues<ManagedEBook>(ManagedEBook.CreateFromDiscriminatorValue).ToList(); } },
                {"mdmWindowsInformationProtectionPolicies", (o,n) => { (o as DeviceAppManagement).MdmWindowsInformationProtectionPolicies = n.GetCollectionOfObjectValues<MdmWindowsInformationProtectionPolicy>(MdmWindowsInformationProtectionPolicy.CreateFromDiscriminatorValue).ToList(); } },
                {"microsoftStoreForBusinessLanguage", (o,n) => { (o as DeviceAppManagement).MicrosoftStoreForBusinessLanguage = n.GetStringValue(); } },
                {"microsoftStoreForBusinessLastCompletedApplicationSyncTime", (o,n) => { (o as DeviceAppManagement).MicrosoftStoreForBusinessLastCompletedApplicationSyncTime = n.GetDateTimeOffsetValue(); } },
                {"microsoftStoreForBusinessLastSuccessfulSyncDateTime", (o,n) => { (o as DeviceAppManagement).MicrosoftStoreForBusinessLastSuccessfulSyncDateTime = n.GetDateTimeOffsetValue(); } },
                {"microsoftStoreForBusinessPortalSelection", (o,n) => { (o as DeviceAppManagement).MicrosoftStoreForBusinessPortalSelection = n.GetEnumValue<MicrosoftStoreForBusinessPortalSelectionOptions>(); } },
                {"mobileAppCategories", (o,n) => { (o as DeviceAppManagement).MobileAppCategories = n.GetCollectionOfObjectValues<MobileAppCategory>(MobileAppCategory.CreateFromDiscriminatorValue).ToList(); } },
                {"mobileAppConfigurations", (o,n) => { (o as DeviceAppManagement).MobileAppConfigurations = n.GetCollectionOfObjectValues<ManagedDeviceMobileAppConfiguration>(ManagedDeviceMobileAppConfiguration.CreateFromDiscriminatorValue).ToList(); } },
                {"mobileApps", (o,n) => { (o as DeviceAppManagement).MobileApps = n.GetCollectionOfObjectValues<MobileApp>(MobileApp.CreateFromDiscriminatorValue).ToList(); } },
                {"policySets", (o,n) => { (o as DeviceAppManagement).PolicySets = n.GetCollectionOfObjectValues<PolicySet>(PolicySet.CreateFromDiscriminatorValue).ToList(); } },
                {"sideLoadingKeys", (o,n) => { (o as DeviceAppManagement).SideLoadingKeys = n.GetCollectionOfObjectValues<SideLoadingKey>(SideLoadingKey.CreateFromDiscriminatorValue).ToList(); } },
                {"symantecCodeSigningCertificate", (o,n) => { (o as DeviceAppManagement).SymantecCodeSigningCertificate = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.SymantecCodeSigningCertificate>(MicrosoftGraphSdk.Models.Microsoft.Graph.SymantecCodeSigningCertificate.CreateFromDiscriminatorValue); } },
                {"targetedManagedAppConfigurations", (o,n) => { (o as DeviceAppManagement).TargetedManagedAppConfigurations = n.GetCollectionOfObjectValues<TargetedManagedAppConfiguration>(TargetedManagedAppConfiguration.CreateFromDiscriminatorValue).ToList(); } },
                {"vppTokens", (o,n) => { (o as DeviceAppManagement).VppTokens = n.GetCollectionOfObjectValues<VppToken>(VppToken.CreateFromDiscriminatorValue).ToList(); } },
                {"wdacSupplementalPolicies", (o,n) => { (o as DeviceAppManagement).WdacSupplementalPolicies = n.GetCollectionOfObjectValues<WindowsDefenderApplicationControlSupplementalPolicy>(WindowsDefenderApplicationControlSupplementalPolicy.CreateFromDiscriminatorValue).ToList(); } },
                {"windowsInformationProtectionDeviceRegistrations", (o,n) => { (o as DeviceAppManagement).WindowsInformationProtectionDeviceRegistrations = n.GetCollectionOfObjectValues<WindowsInformationProtectionDeviceRegistration>(WindowsInformationProtectionDeviceRegistration.CreateFromDiscriminatorValue).ToList(); } },
                {"windowsInformationProtectionPolicies", (o,n) => { (o as DeviceAppManagement).WindowsInformationProtectionPolicies = n.GetCollectionOfObjectValues<WindowsInformationProtectionPolicy>(WindowsInformationProtectionPolicy.CreateFromDiscriminatorValue).ToList(); } },
                {"windowsInformationProtectionWipeActions", (o,n) => { (o as DeviceAppManagement).WindowsInformationProtectionWipeActions = n.GetCollectionOfObjectValues<WindowsInformationProtectionWipeAction>(WindowsInformationProtectionWipeAction.CreateFromDiscriminatorValue).ToList(); } },
                {"windowsManagementApp", (o,n) => { (o as DeviceAppManagement).WindowsManagementApp = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.WindowsManagementApp>(MicrosoftGraphSdk.Models.Microsoft.Graph.WindowsManagementApp.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.SymantecCodeSigningCertificate>("symantecCodeSigningCertificate", SymantecCodeSigningCertificate);
            writer.WriteCollectionOfObjectValues<TargetedManagedAppConfiguration>("targetedManagedAppConfigurations", TargetedManagedAppConfigurations);
            writer.WriteCollectionOfObjectValues<VppToken>("vppTokens", VppTokens);
            writer.WriteCollectionOfObjectValues<WindowsDefenderApplicationControlSupplementalPolicy>("wdacSupplementalPolicies", WdacSupplementalPolicies);
            writer.WriteCollectionOfObjectValues<WindowsInformationProtectionDeviceRegistration>("windowsInformationProtectionDeviceRegistrations", WindowsInformationProtectionDeviceRegistrations);
            writer.WriteCollectionOfObjectValues<WindowsInformationProtectionPolicy>("windowsInformationProtectionPolicies", WindowsInformationProtectionPolicies);
            writer.WriteCollectionOfObjectValues<WindowsInformationProtectionWipeAction>("windowsInformationProtectionWipeActions", WindowsInformationProtectionWipeActions);
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.WindowsManagementApp>("windowsManagementApp", WindowsManagementApp);
        }
    }
}
