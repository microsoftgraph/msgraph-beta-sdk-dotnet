using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Policy used to configure detailed management settings targeted to specific security groups and for a specified set of apps on a Windows device</summary>
    public class WindowsManagedAppProtection : ManagedAppPolicy, IParsable {
        /// <summary>Indicates the sources from which data is allowed to be transferred. Some possible values are allApps or none. Possible values are: allApps, none.</summary>
        public WindowsManagedAppDataTransferLevel? AllowedInboundDataTransferSources {
            get { return BackingStore?.Get<WindowsManagedAppDataTransferLevel?>(nameof(AllowedInboundDataTransferSources)); }
            set { BackingStore?.Set(nameof(AllowedInboundDataTransferSources), value); }
        }
        /// <summary>Indicates the level to which the clipboard may be shared across org &amp; non-org resources. Some possible values are anyDestinationAnySource or none. Possible values are: anyDestinationAnySource, none.</summary>
        public WindowsManagedAppClipboardSharingLevel? AllowedOutboundClipboardSharingLevel {
            get { return BackingStore?.Get<WindowsManagedAppClipboardSharingLevel?>(nameof(AllowedOutboundClipboardSharingLevel)); }
            set { BackingStore?.Set(nameof(AllowedOutboundClipboardSharingLevel), value); }
        }
        /// <summary>Indicates the destinations to which data is allowed to be transferred. Some possible values are allApps or none. Possible values are: allApps, none.</summary>
        public WindowsManagedAppDataTransferLevel? AllowedOutboundDataTransferDestinations {
            get { return BackingStore?.Get<WindowsManagedAppDataTransferLevel?>(nameof(AllowedOutboundDataTransferDestinations)); }
            set { BackingStore?.Set(nameof(AllowedOutboundDataTransferDestinations), value); }
        }
        /// <summary>If set, it will specify what action to take in the case where the user is unable to checkin because their authentication token is invalid. This happens when the user is deleted or disabled in AAD. Some possible values are block or wipe. If this property is not set, no action will be taken. Possible values are: block, wipe, warn.</summary>
        public ManagedAppRemediationAction? AppActionIfUnableToAuthenticateUser {
            get { return BackingStore?.Get<ManagedAppRemediationAction?>(nameof(AppActionIfUnableToAuthenticateUser)); }
            set { BackingStore?.Set(nameof(AppActionIfUnableToAuthenticateUser), value); }
        }
        /// <summary>List of apps to which the policy is deployed.</summary>
        public List<ManagedMobileApp> Apps {
            get { return BackingStore?.Get<List<ManagedMobileApp>>(nameof(Apps)); }
            set { BackingStore?.Set(nameof(Apps), value); }
        }
        /// <summary>Navigation property to list of inclusion and exclusion groups to which the policy is deployed.</summary>
        public List<TargetedManagedAppPolicyAssignment> Assignments {
            get { return BackingStore?.Get<List<TargetedManagedAppPolicyAssignment>>(nameof(Assignments)); }
            set { BackingStore?.Set(nameof(Assignments), value); }
        }
        /// <summary>Indicates the total number of applications for which the current policy is deployed.</summary>
        public int? DeployedAppCount {
            get { return BackingStore?.Get<int?>(nameof(DeployedAppCount)); }
            set { BackingStore?.Set(nameof(DeployedAppCount), value); }
        }
        /// <summary>When TRUE, indicates that the policy is deployed to some inclusion groups. When FALSE, indicates that the policy is not deployed to any inclusion groups. Default value is FALSE.</summary>
        public bool? IsAssigned {
            get { return BackingStore?.Get<bool?>(nameof(IsAssigned)); }
            set { BackingStore?.Set(nameof(IsAssigned), value); }
        }
        /// <summary>Maximum allowed device threat level, as reported by the Mobile Threat Defense app. Possible values are: notConfigured, secured, low, medium, high.</summary>
        public ManagedAppDeviceThreatLevel? MaximumAllowedDeviceThreatLevel {
            get { return BackingStore?.Get<ManagedAppDeviceThreatLevel?>(nameof(MaximumAllowedDeviceThreatLevel)); }
            set { BackingStore?.Set(nameof(MaximumAllowedDeviceThreatLevel), value); }
        }
        /// <summary>Versions bigger than the specified version will block the managed app from accessing company data. For example: &apos;8.1.0&apos; or &apos;13.1.1&apos;.</summary>
        public string MaximumRequiredOsVersion {
            get { return BackingStore?.Get<string>(nameof(MaximumRequiredOsVersion)); }
            set { BackingStore?.Set(nameof(MaximumRequiredOsVersion), value); }
        }
        /// <summary>Versions bigger than the specified version will result in warning message on the managed app from accessing company data. For example: &apos;8.1.0&apos; or &apos;13.1.1&apos;.</summary>
        public string MaximumWarningOsVersion {
            get { return BackingStore?.Get<string>(nameof(MaximumWarningOsVersion)); }
            set { BackingStore?.Set(nameof(MaximumWarningOsVersion), value); }
        }
        /// <summary>Versions bigger than the specified version will wipe the managed app and the associated company data. For example: &apos;8.1.0&apos; or &apos;13.1.1&apos;.</summary>
        public string MaximumWipeOsVersion {
            get { return BackingStore?.Get<string>(nameof(MaximumWipeOsVersion)); }
            set { BackingStore?.Set(nameof(MaximumWipeOsVersion), value); }
        }
        /// <summary>Versions less than the specified version will block the managed app from accessing company data. For example: &apos;8.1.0&apos; or &apos;13.1.1&apos;.</summary>
        public string MinimumRequiredAppVersion {
            get { return BackingStore?.Get<string>(nameof(MinimumRequiredAppVersion)); }
            set { BackingStore?.Set(nameof(MinimumRequiredAppVersion), value); }
        }
        /// <summary>Versions less than the specified version will block the managed app from accessing company data. For example: &apos;8.1.0&apos; or &apos;13.1.1&apos;.</summary>
        public string MinimumRequiredOsVersion {
            get { return BackingStore?.Get<string>(nameof(MinimumRequiredOsVersion)); }
            set { BackingStore?.Set(nameof(MinimumRequiredOsVersion), value); }
        }
        /// <summary>Versions less than the specified version will block the managed app from accessing company data. For example: &apos;8.1.0&apos; or &apos;13.1.1&apos;.</summary>
        public string MinimumRequiredSdkVersion {
            get { return BackingStore?.Get<string>(nameof(MinimumRequiredSdkVersion)); }
            set { BackingStore?.Set(nameof(MinimumRequiredSdkVersion), value); }
        }
        /// <summary>Versions less than the specified version will result in warning message on the managed app from accessing company data. For example: &apos;8.1.0&apos; or &apos;13.1.1&apos;.</summary>
        public string MinimumWarningAppVersion {
            get { return BackingStore?.Get<string>(nameof(MinimumWarningAppVersion)); }
            set { BackingStore?.Set(nameof(MinimumWarningAppVersion), value); }
        }
        /// <summary>Versions less than the specified version will result in warning message on the managed app from accessing company data. For example: &apos;8.1.0&apos; or &apos;13.1.1&apos;.</summary>
        public string MinimumWarningOsVersion {
            get { return BackingStore?.Get<string>(nameof(MinimumWarningOsVersion)); }
            set { BackingStore?.Set(nameof(MinimumWarningOsVersion), value); }
        }
        /// <summary>Versions less than the specified version will wipe the managed app and the associated company data. For example: &apos;8.1.0&apos; or &apos;13.1.1&apos;.</summary>
        public string MinimumWipeAppVersion {
            get { return BackingStore?.Get<string>(nameof(MinimumWipeAppVersion)); }
            set { BackingStore?.Set(nameof(MinimumWipeAppVersion), value); }
        }
        /// <summary>Versions less than the specified version will wipe the managed app and the associated company data. For example: &apos;8.1.0&apos; or &apos;13.1.1&apos;.</summary>
        public string MinimumWipeOsVersion {
            get { return BackingStore?.Get<string>(nameof(MinimumWipeOsVersion)); }
            set { BackingStore?.Set(nameof(MinimumWipeOsVersion), value); }
        }
        /// <summary>Versions less than the specified version will wipe the managed app and the associated company data. For example: &apos;8.1.0&apos; or &apos;13.1.1&apos;.</summary>
        public string MinimumWipeSdkVersion {
            get { return BackingStore?.Get<string>(nameof(MinimumWipeSdkVersion)); }
            set { BackingStore?.Set(nameof(MinimumWipeSdkVersion), value); }
        }
        /// <summary>Determines what action to take if the mobile threat defense threat threshold isn&apos;t met. Some possible values are block or wipe. Warn isn&apos;t a supported value for this property. Possible values are: block, wipe, warn.</summary>
        public ManagedAppRemediationAction? MobileThreatDefenseRemediationAction {
            get { return BackingStore?.Get<ManagedAppRemediationAction?>(nameof(MobileThreatDefenseRemediationAction)); }
            set { BackingStore?.Set(nameof(MobileThreatDefenseRemediationAction), value); }
        }
        /// <summary>The period after which access is checked when the device is not connected to the internet. For example, PT5M indicates that the interval is 5 minutes in duration. A timespan value of PT0S indicates that access will be blocked immediately when the device is not connected to the internet.</summary>
        public TimeSpan? PeriodOfflineBeforeAccessCheck {
            get { return BackingStore?.Get<TimeSpan?>(nameof(PeriodOfflineBeforeAccessCheck)); }
            set { BackingStore?.Set(nameof(PeriodOfflineBeforeAccessCheck), value); }
        }
        /// <summary>The amount of time an app is allowed to remain disconnected from the internet before all managed data it is wiped. For example, P5D indicates that the interval is 5 days in duration. A timespan value of PT0S indicates that managed data will never be wiped when the device is not connected to the internet.</summary>
        public TimeSpan? PeriodOfflineBeforeWipeIsEnforced {
            get { return BackingStore?.Get<TimeSpan?>(nameof(PeriodOfflineBeforeWipeIsEnforced)); }
            set { BackingStore?.Set(nameof(PeriodOfflineBeforeWipeIsEnforced), value); }
        }
        /// <summary>When TRUE, indicates that printing is blocked from managed apps. When FALSE, indicates that printing is allowed from managed apps. Default value is FALSE.</summary>
        public bool? PrintBlocked {
            get { return BackingStore?.Get<bool?>(nameof(PrintBlocked)); }
            set { BackingStore?.Set(nameof(PrintBlocked), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new WindowsManagedAppProtection CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WindowsManagedAppProtection();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"allowedInboundDataTransferSources", n => { AllowedInboundDataTransferSources = n.GetEnumValue<WindowsManagedAppDataTransferLevel>(); } },
                {"allowedOutboundClipboardSharingLevel", n => { AllowedOutboundClipboardSharingLevel = n.GetEnumValue<WindowsManagedAppClipboardSharingLevel>(); } },
                {"allowedOutboundDataTransferDestinations", n => { AllowedOutboundDataTransferDestinations = n.GetEnumValue<WindowsManagedAppDataTransferLevel>(); } },
                {"appActionIfUnableToAuthenticateUser", n => { AppActionIfUnableToAuthenticateUser = n.GetEnumValue<ManagedAppRemediationAction>(); } },
                {"apps", n => { Apps = n.GetCollectionOfObjectValues<ManagedMobileApp>(ManagedMobileApp.CreateFromDiscriminatorValue).ToList(); } },
                {"assignments", n => { Assignments = n.GetCollectionOfObjectValues<TargetedManagedAppPolicyAssignment>(TargetedManagedAppPolicyAssignment.CreateFromDiscriminatorValue).ToList(); } },
                {"deployedAppCount", n => { DeployedAppCount = n.GetIntValue(); } },
                {"isAssigned", n => { IsAssigned = n.GetBoolValue(); } },
                {"maximumAllowedDeviceThreatLevel", n => { MaximumAllowedDeviceThreatLevel = n.GetEnumValue<ManagedAppDeviceThreatLevel>(); } },
                {"maximumRequiredOsVersion", n => { MaximumRequiredOsVersion = n.GetStringValue(); } },
                {"maximumWarningOsVersion", n => { MaximumWarningOsVersion = n.GetStringValue(); } },
                {"maximumWipeOsVersion", n => { MaximumWipeOsVersion = n.GetStringValue(); } },
                {"minimumRequiredAppVersion", n => { MinimumRequiredAppVersion = n.GetStringValue(); } },
                {"minimumRequiredOsVersion", n => { MinimumRequiredOsVersion = n.GetStringValue(); } },
                {"minimumRequiredSdkVersion", n => { MinimumRequiredSdkVersion = n.GetStringValue(); } },
                {"minimumWarningAppVersion", n => { MinimumWarningAppVersion = n.GetStringValue(); } },
                {"minimumWarningOsVersion", n => { MinimumWarningOsVersion = n.GetStringValue(); } },
                {"minimumWipeAppVersion", n => { MinimumWipeAppVersion = n.GetStringValue(); } },
                {"minimumWipeOsVersion", n => { MinimumWipeOsVersion = n.GetStringValue(); } },
                {"minimumWipeSdkVersion", n => { MinimumWipeSdkVersion = n.GetStringValue(); } },
                {"mobileThreatDefenseRemediationAction", n => { MobileThreatDefenseRemediationAction = n.GetEnumValue<ManagedAppRemediationAction>(); } },
                {"periodOfflineBeforeAccessCheck", n => { PeriodOfflineBeforeAccessCheck = n.GetTimeSpanValue(); } },
                {"periodOfflineBeforeWipeIsEnforced", n => { PeriodOfflineBeforeWipeIsEnforced = n.GetTimeSpanValue(); } },
                {"printBlocked", n => { PrintBlocked = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<WindowsManagedAppDataTransferLevel>("allowedInboundDataTransferSources", AllowedInboundDataTransferSources);
            writer.WriteEnumValue<WindowsManagedAppClipboardSharingLevel>("allowedOutboundClipboardSharingLevel", AllowedOutboundClipboardSharingLevel);
            writer.WriteEnumValue<WindowsManagedAppDataTransferLevel>("allowedOutboundDataTransferDestinations", AllowedOutboundDataTransferDestinations);
            writer.WriteEnumValue<ManagedAppRemediationAction>("appActionIfUnableToAuthenticateUser", AppActionIfUnableToAuthenticateUser);
            writer.WriteCollectionOfObjectValues<ManagedMobileApp>("apps", Apps);
            writer.WriteCollectionOfObjectValues<TargetedManagedAppPolicyAssignment>("assignments", Assignments);
            writer.WriteIntValue("deployedAppCount", DeployedAppCount);
            writer.WriteBoolValue("isAssigned", IsAssigned);
            writer.WriteEnumValue<ManagedAppDeviceThreatLevel>("maximumAllowedDeviceThreatLevel", MaximumAllowedDeviceThreatLevel);
            writer.WriteStringValue("maximumRequiredOsVersion", MaximumRequiredOsVersion);
            writer.WriteStringValue("maximumWarningOsVersion", MaximumWarningOsVersion);
            writer.WriteStringValue("maximumWipeOsVersion", MaximumWipeOsVersion);
            writer.WriteStringValue("minimumRequiredAppVersion", MinimumRequiredAppVersion);
            writer.WriteStringValue("minimumRequiredOsVersion", MinimumRequiredOsVersion);
            writer.WriteStringValue("minimumRequiredSdkVersion", MinimumRequiredSdkVersion);
            writer.WriteStringValue("minimumWarningAppVersion", MinimumWarningAppVersion);
            writer.WriteStringValue("minimumWarningOsVersion", MinimumWarningOsVersion);
            writer.WriteStringValue("minimumWipeAppVersion", MinimumWipeAppVersion);
            writer.WriteStringValue("minimumWipeOsVersion", MinimumWipeOsVersion);
            writer.WriteStringValue("minimumWipeSdkVersion", MinimumWipeSdkVersion);
            writer.WriteEnumValue<ManagedAppRemediationAction>("mobileThreatDefenseRemediationAction", MobileThreatDefenseRemediationAction);
            writer.WriteTimeSpanValue("periodOfflineBeforeAccessCheck", PeriodOfflineBeforeAccessCheck);
            writer.WriteTimeSpanValue("periodOfflineBeforeWipeIsEnforced", PeriodOfflineBeforeWipeIsEnforced);
            writer.WriteBoolValue("printBlocked", PrintBlocked);
        }
    }
}
