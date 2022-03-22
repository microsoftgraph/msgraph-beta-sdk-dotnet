using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class IosManagedAppProtection : TargetedManagedAppProtection, IParsable {
        /// <summary>Semicolon seperated list of device models allowed, as a string, for the managed app to work.</summary>
        public string AllowedIosDeviceModels { get; set; }
        /// <summary>Defines a managed app behavior, either block or wipe, if the specified device model is not allowed. Possible values are: block, wipe, warn.</summary>
        public ManagedAppRemediationAction? AppActionIfIosDeviceModelNotAllowed { get; set; }
        /// <summary>Type of encryption which should be used for data in a managed app. Possible values are: useDeviceSettings, afterDeviceRestart, whenDeviceLockedExceptOpenFiles, whenDeviceLocked.</summary>
        public ManagedAppDataEncryptionType? AppDataEncryptionType { get; set; }
        /// <summary>List of apps to which the policy is deployed.</summary>
        public List<ManagedMobileApp> Apps { get; set; }
        /// <summary>A custom browser protocol to open weblink on iOS. When this property is configured, ManagedBrowserToOpenLinksRequired should be true.</summary>
        public string CustomBrowserProtocol { get; set; }
        /// <summary>Protocol of a custom dialer app to click-to-open a phone number on iOS, for example, skype:.</summary>
        public string CustomDialerAppProtocol { get; set; }
        /// <summary>Count of apps to which the current policy is deployed.</summary>
        public int? DeployedAppCount { get; set; }
        /// <summary>Navigation property to deployment summary of the configuration.</summary>
        public ManagedAppPolicyDeploymentSummary DeploymentSummary { get; set; }
        /// <summary>Disable protection of data transferred to other apps through IOS OpenIn option. This setting is only allowed to be True when AllowedOutboundDataTransferDestinations is set to ManagedApps.</summary>
        public bool? DisableProtectionOfManagedOutboundOpenInData { get; set; }
        /// <summary>Apps in this list will be exempt from the policy and will be able to receive data from managed apps.</summary>
        public List<KeyValuePair> ExemptedAppProtocols { get; set; }
        /// <summary>A list of custom urls that are allowed to invocate an unmanaged app</summary>
        public List<string> ExemptedUniversalLinks { get; set; }
        /// <summary>Indicates whether use of the FaceID is allowed in place of a pin if PinRequired is set to True.</summary>
        public bool? FaceIdBlocked { get; set; }
        /// <summary>Defines if open-in operation is supported from the managed app to the filesharing locations selected. This setting only applies when AllowedOutboundDataTransferDestinations is set to ManagedApps and DisableProtectionOfManagedOutboundOpenInData is set to False.</summary>
        public bool? FilterOpenInToOnlyManagedApps { get; set; }
        /// <summary>A list of custom urls that are allowed to invocate a managed app</summary>
        public List<string> ManagedUniversalLinks { get; set; }
        /// <summary>Versions less than the specified version will block the managed app from accessing company data.</summary>
        public string MinimumRequiredSdkVersion { get; set; }
        /// <summary>Versions less than the specified version will block the managed app from accessing company data.</summary>
        public string MinimumWipeSdkVersion { get; set; }
        /// <summary>Protect incoming data from unknown source. This setting is only allowed to be True when AllowedInboundDataTransferSources is set to AllApps.</summary>
        public bool? ProtectInboundDataFromUnknownSources { get; set; }
        /// <summary>Defines if third party keyboards are allowed while accessing a managed app</summary>
        public bool? ThirdPartyKeyboardsBlocked { get; set; }
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
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"allowedIosDeviceModels", (o,n) => { (o as IosManagedAppProtection).AllowedIosDeviceModels = n.GetStringValue(); } },
                {"appActionIfIosDeviceModelNotAllowed", (o,n) => { (o as IosManagedAppProtection).AppActionIfIosDeviceModelNotAllowed = n.GetEnumValue<ManagedAppRemediationAction>(); } },
                {"appDataEncryptionType", (o,n) => { (o as IosManagedAppProtection).AppDataEncryptionType = n.GetEnumValue<ManagedAppDataEncryptionType>(); } },
                {"apps", (o,n) => { (o as IosManagedAppProtection).Apps = n.GetCollectionOfObjectValues<ManagedMobileApp>(ManagedMobileApp.CreateFromDiscriminatorValue).ToList(); } },
                {"customBrowserProtocol", (o,n) => { (o as IosManagedAppProtection).CustomBrowserProtocol = n.GetStringValue(); } },
                {"customDialerAppProtocol", (o,n) => { (o as IosManagedAppProtection).CustomDialerAppProtocol = n.GetStringValue(); } },
                {"deployedAppCount", (o,n) => { (o as IosManagedAppProtection).DeployedAppCount = n.GetIntValue(); } },
                {"deploymentSummary", (o,n) => { (o as IosManagedAppProtection).DeploymentSummary = n.GetObjectValue<ManagedAppPolicyDeploymentSummary>(ManagedAppPolicyDeploymentSummary.CreateFromDiscriminatorValue); } },
                {"disableProtectionOfManagedOutboundOpenInData", (o,n) => { (o as IosManagedAppProtection).DisableProtectionOfManagedOutboundOpenInData = n.GetBoolValue(); } },
                {"exemptedAppProtocols", (o,n) => { (o as IosManagedAppProtection).ExemptedAppProtocols = n.GetCollectionOfObjectValues<KeyValuePair>(KeyValuePair.CreateFromDiscriminatorValue).ToList(); } },
                {"exemptedUniversalLinks", (o,n) => { (o as IosManagedAppProtection).ExemptedUniversalLinks = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"faceIdBlocked", (o,n) => { (o as IosManagedAppProtection).FaceIdBlocked = n.GetBoolValue(); } },
                {"filterOpenInToOnlyManagedApps", (o,n) => { (o as IosManagedAppProtection).FilterOpenInToOnlyManagedApps = n.GetBoolValue(); } },
                {"managedUniversalLinks", (o,n) => { (o as IosManagedAppProtection).ManagedUniversalLinks = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"minimumRequiredSdkVersion", (o,n) => { (o as IosManagedAppProtection).MinimumRequiredSdkVersion = n.GetStringValue(); } },
                {"minimumWipeSdkVersion", (o,n) => { (o as IosManagedAppProtection).MinimumWipeSdkVersion = n.GetStringValue(); } },
                {"protectInboundDataFromUnknownSources", (o,n) => { (o as IosManagedAppProtection).ProtectInboundDataFromUnknownSources = n.GetBoolValue(); } },
                {"thirdPartyKeyboardsBlocked", (o,n) => { (o as IosManagedAppProtection).ThirdPartyKeyboardsBlocked = n.GetBoolValue(); } },
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
