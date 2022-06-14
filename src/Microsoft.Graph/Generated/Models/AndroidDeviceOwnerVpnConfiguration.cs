using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class AndroidDeviceOwnerVpnConfiguration : VpnConfiguration, IParsable {
        /// <summary>Whether or not to enable always-on VPN connection.</summary>
        public bool? AlwaysOn {
            get { return BackingStore?.Get<bool?>(nameof(AlwaysOn)); }
            set { BackingStore?.Set(nameof(AlwaysOn), value); }
        }
        /// <summary>If always-on VPN connection is enabled, whether or not to lock network traffic when that VPN is disconnected.</summary>
        public bool? AlwaysOnLockdown {
            get { return BackingStore?.Get<bool?>(nameof(AlwaysOnLockdown)); }
            set { BackingStore?.Set(nameof(AlwaysOnLockdown), value); }
        }
        /// <summary>Connection type. Possible values are: ciscoAnyConnect, pulseSecure, f5EdgeClient, dellSonicWallMobileConnect, checkPointCapsuleVpn, citrix, microsoftTunnel, netMotionMobility, microsoftProtect.</summary>
        public AndroidVpnConnectionType? ConnectionType {
            get { return BackingStore?.Get<AndroidVpnConnectionType?>(nameof(ConnectionType)); }
            set { BackingStore?.Set(nameof(ConnectionType), value); }
        }
        /// <summary>Custom data to define key/value pairs specific to a VPN provider. This collection can contain a maximum of 25 elements.</summary>
        public List<KeyValue> CustomData {
            get { return BackingStore?.Get<List<KeyValue>>(nameof(CustomData)); }
            set { BackingStore?.Set(nameof(CustomData), value); }
        }
        /// <summary>Custom data to define key/value pairs specific to a VPN provider. This collection can contain a maximum of 25 elements.</summary>
        public List<KeyValuePair> CustomKeyValueData {
            get { return BackingStore?.Get<List<KeyValuePair>>(nameof(CustomKeyValueData)); }
            set { BackingStore?.Set(nameof(CustomKeyValueData), value); }
        }
        /// <summary>Tenant level settings for the Derived Credentials to be used for authentication.</summary>
        public DeviceManagementDerivedCredentialSettings DerivedCredentialSettings {
            get { return BackingStore?.Get<DeviceManagementDerivedCredentialSettings>(nameof(DerivedCredentialSettings)); }
            set { BackingStore?.Set(nameof(DerivedCredentialSettings), value); }
        }
        /// <summary>Identity certificate for client authentication when authentication method is certificate.</summary>
        public AndroidDeviceOwnerCertificateProfileBase IdentityCertificate {
            get { return BackingStore?.Get<AndroidDeviceOwnerCertificateProfileBase>(nameof(IdentityCertificate)); }
            set { BackingStore?.Set(nameof(IdentityCertificate), value); }
        }
        /// <summary>Microsoft Tunnel site ID.</summary>
        public string MicrosoftTunnelSiteId {
            get { return BackingStore?.Get<string>(nameof(MicrosoftTunnelSiteId)); }
            set { BackingStore?.Set(nameof(MicrosoftTunnelSiteId), value); }
        }
        /// <summary>Proxy server.</summary>
        public VpnProxyServer ProxyServer {
            get { return BackingStore?.Get<VpnProxyServer>(nameof(ProxyServer)); }
            set { BackingStore?.Set(nameof(ProxyServer), value); }
        }
        /// <summary>Targeted mobile apps. This collection can contain a maximum of 500 elements.</summary>
        public List<AppListItem> TargetedMobileApps {
            get { return BackingStore?.Get<List<AppListItem>>(nameof(TargetedMobileApps)); }
            set { BackingStore?.Set(nameof(TargetedMobileApps), value); }
        }
        /// <summary>Targeted App package IDs.</summary>
        public List<string> TargetedPackageIds {
            get { return BackingStore?.Get<List<string>>(nameof(TargetedPackageIds)); }
            set { BackingStore?.Set(nameof(TargetedPackageIds), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new AndroidDeviceOwnerVpnConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AndroidDeviceOwnerVpnConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"alwaysOn", n => { AlwaysOn = n.GetBoolValue(); } },
                {"alwaysOnLockdown", n => { AlwaysOnLockdown = n.GetBoolValue(); } },
                {"connectionType", n => { ConnectionType = n.GetEnumValue<AndroidVpnConnectionType>(); } },
                {"customData", n => { CustomData = n.GetCollectionOfObjectValues<KeyValue>(KeyValue.CreateFromDiscriminatorValue).ToList(); } },
                {"customKeyValueData", n => { CustomKeyValueData = n.GetCollectionOfObjectValues<KeyValuePair>(KeyValuePair.CreateFromDiscriminatorValue).ToList(); } },
                {"derivedCredentialSettings", n => { DerivedCredentialSettings = n.GetObjectValue<DeviceManagementDerivedCredentialSettings>(DeviceManagementDerivedCredentialSettings.CreateFromDiscriminatorValue); } },
                {"identityCertificate", n => { IdentityCertificate = n.GetObjectValue<AndroidDeviceOwnerCertificateProfileBase>(AndroidDeviceOwnerCertificateProfileBase.CreateFromDiscriminatorValue); } },
                {"microsoftTunnelSiteId", n => { MicrosoftTunnelSiteId = n.GetStringValue(); } },
                {"proxyServer", n => { ProxyServer = n.GetObjectValue<VpnProxyServer>(VpnProxyServer.CreateFromDiscriminatorValue); } },
                {"targetedMobileApps", n => { TargetedMobileApps = n.GetCollectionOfObjectValues<AppListItem>(AppListItem.CreateFromDiscriminatorValue).ToList(); } },
                {"targetedPackageIds", n => { TargetedPackageIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("alwaysOn", AlwaysOn);
            writer.WriteBoolValue("alwaysOnLockdown", AlwaysOnLockdown);
            writer.WriteEnumValue<AndroidVpnConnectionType>("connectionType", ConnectionType);
            writer.WriteCollectionOfObjectValues<KeyValue>("customData", CustomData);
            writer.WriteCollectionOfObjectValues<KeyValuePair>("customKeyValueData", CustomKeyValueData);
            writer.WriteObjectValue<DeviceManagementDerivedCredentialSettings>("derivedCredentialSettings", DerivedCredentialSettings);
            writer.WriteObjectValue<AndroidDeviceOwnerCertificateProfileBase>("identityCertificate", IdentityCertificate);
            writer.WriteStringValue("microsoftTunnelSiteId", MicrosoftTunnelSiteId);
            writer.WriteObjectValue<VpnProxyServer>("proxyServer", ProxyServer);
            writer.WriteCollectionOfObjectValues<AppListItem>("targetedMobileApps", TargetedMobileApps);
            writer.WriteCollectionOfPrimitiveValues<string>("targetedPackageIds", TargetedPackageIds);
        }
    }
}
