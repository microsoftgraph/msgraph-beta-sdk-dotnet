using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class IosVpnConfiguration : AppleVpnConfiguration, IParsable {
        /// <summary>Zscaler only. Zscaler cloud which the user is assigned to.</summary>
        public string CloudName {
            get { return BackingStore?.Get<string>("cloudName"); }
            set { BackingStore?.Set("cloudName", value); }
        }
        /// <summary>Tenant level settings for the Derived Credentials to be used for authentication.</summary>
        public DeviceManagementDerivedCredentialSettings DerivedCredentialSettings {
            get { return BackingStore?.Get<DeviceManagementDerivedCredentialSettings>("derivedCredentialSettings"); }
            set { BackingStore?.Set("derivedCredentialSettings", value); }
        }
        /// <summary>Zscaler only. List of network addresses which are not sent through the Zscaler cloud.</summary>
        public List<string> ExcludeList {
            get { return BackingStore?.Get<List<string>>("excludeList"); }
            set { BackingStore?.Set("excludeList", value); }
        }
        /// <summary>Identity certificate for client authentication when authentication method is certificate.</summary>
        public IosCertificateProfileBase IdentityCertificate {
            get { return BackingStore?.Get<IosCertificateProfileBase>("identityCertificate"); }
            set { BackingStore?.Set("identityCertificate", value); }
        }
        /// <summary>Microsoft Tunnel site ID.</summary>
        public string MicrosoftTunnelSiteId {
            get { return BackingStore?.Get<string>("microsoftTunnelSiteId"); }
            set { BackingStore?.Set("microsoftTunnelSiteId", value); }
        }
        /// <summary>Zscaler only. Blocks network traffic until the user signs into Zscaler app. &apos;True&apos; means traffic is blocked.</summary>
        public bool? StrictEnforcement {
            get { return BackingStore?.Get<bool?>("strictEnforcement"); }
            set { BackingStore?.Set("strictEnforcement", value); }
        }
        /// <summary>Targeted mobile apps. This collection can contain a maximum of 500 elements.</summary>
        public List<AppListItem> TargetedMobileApps {
            get { return BackingStore?.Get<List<AppListItem>>("targetedMobileApps"); }
            set { BackingStore?.Set("targetedMobileApps", value); }
        }
        /// <summary>Zscaler only. Enter a static domain to pre-populate the login field with in the Zscaler app. If this is left empty, the user&apos;s Azure Active Directory domain will be used instead.</summary>
        public string UserDomain {
            get { return BackingStore?.Get<string>("userDomain"); }
            set { BackingStore?.Set("userDomain", value); }
        }
        /// <summary>
        /// Instantiates a new IosVpnConfiguration and sets the default values.
        /// </summary>
        public IosVpnConfiguration() : base() {
            OdataType = "#microsoft.graph.iosVpnConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new IosVpnConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.iosikEv2VpnConfiguration" => new IosikEv2VpnConfiguration(),
                _ => new IosVpnConfiguration(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"cloudName", n => { CloudName = n.GetStringValue(); } },
                {"derivedCredentialSettings", n => { DerivedCredentialSettings = n.GetObjectValue<DeviceManagementDerivedCredentialSettings>(DeviceManagementDerivedCredentialSettings.CreateFromDiscriminatorValue); } },
                {"excludeList", n => { ExcludeList = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"identityCertificate", n => { IdentityCertificate = n.GetObjectValue<IosCertificateProfileBase>(IosCertificateProfileBase.CreateFromDiscriminatorValue); } },
                {"microsoftTunnelSiteId", n => { MicrosoftTunnelSiteId = n.GetStringValue(); } },
                {"strictEnforcement", n => { StrictEnforcement = n.GetBoolValue(); } },
                {"targetedMobileApps", n => { TargetedMobileApps = n.GetCollectionOfObjectValues<AppListItem>(AppListItem.CreateFromDiscriminatorValue)?.ToList(); } },
                {"userDomain", n => { UserDomain = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("cloudName", CloudName);
            writer.WriteObjectValue<DeviceManagementDerivedCredentialSettings>("derivedCredentialSettings", DerivedCredentialSettings);
            writer.WriteCollectionOfPrimitiveValues<string>("excludeList", ExcludeList);
            writer.WriteObjectValue<IosCertificateProfileBase>("identityCertificate", IdentityCertificate);
            writer.WriteStringValue("microsoftTunnelSiteId", MicrosoftTunnelSiteId);
            writer.WriteBoolValue("strictEnforcement", StrictEnforcement);
            writer.WriteCollectionOfObjectValues<AppListItem>("targetedMobileApps", TargetedMobileApps);
            writer.WriteStringValue("userDomain", UserDomain);
        }
    }
}
