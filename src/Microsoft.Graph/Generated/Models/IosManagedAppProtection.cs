using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Policy used to configure detailed management settings targeted to specific security groups and for a specified set of apps on an iOS device</summary>
    public class IosManagedAppProtection : TargetedManagedAppProtection, IParsable {
        /// <summary>Semicolon seperated list of device models allowed, as a string, for the managed app to work.</summary>
        public string AllowedIosDeviceModels {
            get { return BackingStore?.Get<string>(nameof(AllowedIosDeviceModels)); }
            set { BackingStore?.Set(nameof(AllowedIosDeviceModels), value); }
        }
        /// <summary>Defines a managed app behavior, either block or wipe, if the specified device model is not allowed. Possible values are: block, wipe, warn.</summary>
        public ManagedAppRemediationAction? AppActionIfIosDeviceModelNotAllowed {
            get { return BackingStore?.Get<ManagedAppRemediationAction?>(nameof(AppActionIfIosDeviceModelNotAllowed)); }
            set { BackingStore?.Set(nameof(AppActionIfIosDeviceModelNotAllowed), value); }
        }
        /// <summary>Type of encryption which should be used for data in a managed app. Possible values are: useDeviceSettings, afterDeviceRestart, whenDeviceLockedExceptOpenFiles, whenDeviceLocked.</summary>
        public ManagedAppDataEncryptionType? AppDataEncryptionType {
            get { return BackingStore?.Get<ManagedAppDataEncryptionType?>(nameof(AppDataEncryptionType)); }
            set { BackingStore?.Set(nameof(AppDataEncryptionType), value); }
        }
        /// <summary>List of apps to which the policy is deployed.</summary>
        public List<ManagedMobileApp> Apps {
            get { return BackingStore?.Get<List<ManagedMobileApp>>(nameof(Apps)); }
            set { BackingStore?.Set(nameof(Apps), value); }
        }
        /// <summary>A custom browser protocol to open weblink on iOS.</summary>
        public string CustomBrowserProtocol {
            get { return BackingStore?.Get<string>(nameof(CustomBrowserProtocol)); }
            set { BackingStore?.Set(nameof(CustomBrowserProtocol), value); }
        }
        /// <summary>Protocol of a custom dialer app to click-to-open a phone number on iOS, for example, skype:.</summary>
        public string CustomDialerAppProtocol {
            get { return BackingStore?.Get<string>(nameof(CustomDialerAppProtocol)); }
            set { BackingStore?.Set(nameof(CustomDialerAppProtocol), value); }
        }
        /// <summary>Count of apps to which the current policy is deployed.</summary>
        public int? DeployedAppCount {
            get { return BackingStore?.Get<int?>(nameof(DeployedAppCount)); }
            set { BackingStore?.Set(nameof(DeployedAppCount), value); }
        }
        /// <summary>Navigation property to deployment summary of the configuration.</summary>
        public ManagedAppPolicyDeploymentSummary DeploymentSummary {
            get { return BackingStore?.Get<ManagedAppPolicyDeploymentSummary>(nameof(DeploymentSummary)); }
            set { BackingStore?.Set(nameof(DeploymentSummary), value); }
        }
        /// <summary>Disable protection of data transferred to other apps through IOS OpenIn option. This setting is only allowed to be True when AllowedOutboundDataTransferDestinations is set to ManagedApps.</summary>
        public bool? DisableProtectionOfManagedOutboundOpenInData {
            get { return BackingStore?.Get<bool?>(nameof(DisableProtectionOfManagedOutboundOpenInData)); }
            set { BackingStore?.Set(nameof(DisableProtectionOfManagedOutboundOpenInData), value); }
        }
        /// <summary>Apps in this list will be exempt from the policy and will be able to receive data from managed apps.</summary>
        public List<KeyValuePair> ExemptedAppProtocols {
            get { return BackingStore?.Get<List<KeyValuePair>>(nameof(ExemptedAppProtocols)); }
            set { BackingStore?.Set(nameof(ExemptedAppProtocols), value); }
        }
        /// <summary>A list of custom urls that are allowed to invocate an unmanaged app</summary>
        public List<string> ExemptedUniversalLinks {
            get { return BackingStore?.Get<List<string>>(nameof(ExemptedUniversalLinks)); }
            set { BackingStore?.Set(nameof(ExemptedUniversalLinks), value); }
        }
        /// <summary>Indicates whether use of the FaceID is allowed in place of a pin if PinRequired is set to True.</summary>
        public bool? FaceIdBlocked {
            get { return BackingStore?.Get<bool?>(nameof(FaceIdBlocked)); }
            set { BackingStore?.Set(nameof(FaceIdBlocked), value); }
        }
        /// <summary>Defines if open-in operation is supported from the managed app to the filesharing locations selected. This setting only applies when AllowedOutboundDataTransferDestinations is set to ManagedApps and DisableProtectionOfManagedOutboundOpenInData is set to False.</summary>
        public bool? FilterOpenInToOnlyManagedApps {
            get { return BackingStore?.Get<bool?>(nameof(FilterOpenInToOnlyManagedApps)); }
            set { BackingStore?.Set(nameof(FilterOpenInToOnlyManagedApps), value); }
        }
        /// <summary>A list of custom urls that are allowed to invocate a managed app</summary>
        public List<string> ManagedUniversalLinks {
            get { return BackingStore?.Get<List<string>>(nameof(ManagedUniversalLinks)); }
            set { BackingStore?.Set(nameof(ManagedUniversalLinks), value); }
        }
        /// <summary>Versions less than the specified version will block the managed app from accessing company data.</summary>
        public string MinimumRequiredSdkVersion {
            get { return BackingStore?.Get<string>(nameof(MinimumRequiredSdkVersion)); }
            set { BackingStore?.Set(nameof(MinimumRequiredSdkVersion), value); }
        }
        /// <summary>Versions less than the specified version will block the managed app from accessing company data.</summary>
        public string MinimumWipeSdkVersion {
            get { return BackingStore?.Get<string>(nameof(MinimumWipeSdkVersion)); }
            set { BackingStore?.Set(nameof(MinimumWipeSdkVersion), value); }
        }
        /// <summary>Protect incoming data from unknown source. This setting is only allowed to be True when AllowedInboundDataTransferSources is set to AllApps.</summary>
        public bool? ProtectInboundDataFromUnknownSources {
            get { return BackingStore?.Get<bool?>(nameof(ProtectInboundDataFromUnknownSources)); }
            set { BackingStore?.Set(nameof(ProtectInboundDataFromUnknownSources), value); }
        }
        /// <summary>Defines if third party keyboards are allowed while accessing a managed app</summary>
        public bool? ThirdPartyKeyboardsBlocked {
            get { return BackingStore?.Get<bool?>(nameof(ThirdPartyKeyboardsBlocked)); }
            set { BackingStore?.Set(nameof(ThirdPartyKeyboardsBlocked), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new IosManagedAppProtection CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new IosManagedAppProtection();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"allowedIosDeviceModels", n => { AllowedIosDeviceModels = n.GetStringValue(); } },
                {"appActionIfIosDeviceModelNotAllowed", n => { AppActionIfIosDeviceModelNotAllowed = n.GetEnumValue<ManagedAppRemediationAction>(); } },
                {"appDataEncryptionType", n => { AppDataEncryptionType = n.GetEnumValue<ManagedAppDataEncryptionType>(); } },
                {"apps", n => { Apps = n.GetCollectionOfObjectValues<ManagedMobileApp>(ManagedMobileApp.CreateFromDiscriminatorValue).ToList(); } },
                {"customBrowserProtocol", n => { CustomBrowserProtocol = n.GetStringValue(); } },
                {"customDialerAppProtocol", n => { CustomDialerAppProtocol = n.GetStringValue(); } },
                {"deployedAppCount", n => { DeployedAppCount = n.GetIntValue(); } },
                {"deploymentSummary", n => { DeploymentSummary = n.GetObjectValue<ManagedAppPolicyDeploymentSummary>(ManagedAppPolicyDeploymentSummary.CreateFromDiscriminatorValue); } },
                {"disableProtectionOfManagedOutboundOpenInData", n => { DisableProtectionOfManagedOutboundOpenInData = n.GetBoolValue(); } },
                {"exemptedAppProtocols", n => { ExemptedAppProtocols = n.GetCollectionOfObjectValues<KeyValuePair>(KeyValuePair.CreateFromDiscriminatorValue).ToList(); } },
                {"exemptedUniversalLinks", n => { ExemptedUniversalLinks = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"faceIdBlocked", n => { FaceIdBlocked = n.GetBoolValue(); } },
                {"filterOpenInToOnlyManagedApps", n => { FilterOpenInToOnlyManagedApps = n.GetBoolValue(); } },
                {"managedUniversalLinks", n => { ManagedUniversalLinks = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"minimumRequiredSdkVersion", n => { MinimumRequiredSdkVersion = n.GetStringValue(); } },
                {"minimumWipeSdkVersion", n => { MinimumWipeSdkVersion = n.GetStringValue(); } },
                {"protectInboundDataFromUnknownSources", n => { ProtectInboundDataFromUnknownSources = n.GetBoolValue(); } },
                {"thirdPartyKeyboardsBlocked", n => { ThirdPartyKeyboardsBlocked = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("allowedIosDeviceModels", AllowedIosDeviceModels);
            writer.WriteEnumValue<ManagedAppRemediationAction>("appActionIfIosDeviceModelNotAllowed", AppActionIfIosDeviceModelNotAllowed);
            writer.WriteEnumValue<ManagedAppDataEncryptionType>("appDataEncryptionType", AppDataEncryptionType);
            writer.WriteCollectionOfObjectValues<ManagedMobileApp>("apps", Apps);
            writer.WriteStringValue("customBrowserProtocol", CustomBrowserProtocol);
            writer.WriteStringValue("customDialerAppProtocol", CustomDialerAppProtocol);
            writer.WriteIntValue("deployedAppCount", DeployedAppCount);
            writer.WriteObjectValue<ManagedAppPolicyDeploymentSummary>("deploymentSummary", DeploymentSummary);
            writer.WriteBoolValue("disableProtectionOfManagedOutboundOpenInData", DisableProtectionOfManagedOutboundOpenInData);
            writer.WriteCollectionOfObjectValues<KeyValuePair>("exemptedAppProtocols", ExemptedAppProtocols);
            writer.WriteCollectionOfPrimitiveValues<string>("exemptedUniversalLinks", ExemptedUniversalLinks);
            writer.WriteBoolValue("faceIdBlocked", FaceIdBlocked);
            writer.WriteBoolValue("filterOpenInToOnlyManagedApps", FilterOpenInToOnlyManagedApps);
            writer.WriteCollectionOfPrimitiveValues<string>("managedUniversalLinks", ManagedUniversalLinks);
            writer.WriteStringValue("minimumRequiredSdkVersion", MinimumRequiredSdkVersion);
            writer.WriteStringValue("minimumWipeSdkVersion", MinimumWipeSdkVersion);
            writer.WriteBoolValue("protectInboundDataFromUnknownSources", ProtectInboundDataFromUnknownSources);
            writer.WriteBoolValue("thirdPartyKeyboardsBlocked", ThirdPartyKeyboardsBlocked);
        }
    }
}
