using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class IosikEv2VpnConfiguration : IosVpnConfiguration, IParsable {
        /// <summary>Allows the use of child security association parameters by setting all parameters to the device&apos;s default unless explicitly specified.</summary>
        public bool? AllowDefaultChildSecurityAssociationParameters {
            get { return BackingStore?.Get<bool?>(nameof(AllowDefaultChildSecurityAssociationParameters)); }
            set { BackingStore?.Set(nameof(AllowDefaultChildSecurityAssociationParameters), value); }
        }
        /// <summary>Allows the use of security association parameters by setting all parameters to the device&apos;s default unless explicitly specified.</summary>
        public bool? AllowDefaultSecurityAssociationParameters {
            get { return BackingStore?.Get<bool?>(nameof(AllowDefaultSecurityAssociationParameters)); }
            set { BackingStore?.Set(nameof(AllowDefaultSecurityAssociationParameters), value); }
        }
        /// <summary>AlwaysOn Configuration</summary>
        public AppleVpnAlwaysOnConfiguration AlwaysOnConfiguration {
            get { return BackingStore?.Get<AppleVpnAlwaysOnConfiguration>(nameof(AlwaysOnConfiguration)); }
            set { BackingStore?.Set(nameof(AlwaysOnConfiguration), value); }
        }
        /// <summary>Child Security Association Parameters</summary>
        public IosVpnSecurityAssociationParameters ChildSecurityAssociationParameters {
            get { return BackingStore?.Get<IosVpnSecurityAssociationParameters>(nameof(ChildSecurityAssociationParameters)); }
            set { BackingStore?.Set(nameof(ChildSecurityAssociationParameters), value); }
        }
        /// <summary>Type of Client Authentication the VPN client will use. Possible values are: userAuthentication, deviceAuthentication.</summary>
        public VpnClientAuthenticationType? ClientAuthenticationType {
            get { return BackingStore?.Get<VpnClientAuthenticationType?>(nameof(ClientAuthenticationType)); }
            set { BackingStore?.Set(nameof(ClientAuthenticationType), value); }
        }
        /// <summary>Determine how often to check if a peer connection is still active. . Possible values are: medium, none, low, high.</summary>
        public VpnDeadPeerDetectionRate? DeadPeerDetectionRate {
            get { return BackingStore?.Get<VpnDeadPeerDetectionRate?>(nameof(DeadPeerDetectionRate)); }
            set { BackingStore?.Set(nameof(DeadPeerDetectionRate), value); }
        }
        /// <summary>Disable MOBIKE</summary>
        public bool? DisableMobilityAndMultihoming {
            get { return BackingStore?.Get<bool?>(nameof(DisableMobilityAndMultihoming)); }
            set { BackingStore?.Set(nameof(DisableMobilityAndMultihoming), value); }
        }
        /// <summary>Disable Redirect</summary>
        public bool? DisableRedirect {
            get { return BackingStore?.Get<bool?>(nameof(DisableRedirect)); }
            set { BackingStore?.Set(nameof(DisableRedirect), value); }
        }
        /// <summary>Determines if Always on VPN is enabled</summary>
        public bool? EnableAlwaysOnConfiguration {
            get { return BackingStore?.Get<bool?>(nameof(EnableAlwaysOnConfiguration)); }
            set { BackingStore?.Set(nameof(EnableAlwaysOnConfiguration), value); }
        }
        /// <summary>Enables a best-effort revocation check; server response timeouts will not cause it to fail</summary>
        public bool? EnableCertificateRevocationCheck {
            get { return BackingStore?.Get<bool?>(nameof(EnableCertificateRevocationCheck)); }
            set { BackingStore?.Set(nameof(EnableCertificateRevocationCheck), value); }
        }
        /// <summary>Enables EAP only authentication</summary>
        public bool? EnableEAP {
            get { return BackingStore?.Get<bool?>(nameof(EnableEAP)); }
            set { BackingStore?.Set(nameof(EnableEAP), value); }
        }
        /// <summary>Enable Perfect Forward Secrecy (PFS).</summary>
        public bool? EnablePerfectForwardSecrecy {
            get { return BackingStore?.Get<bool?>(nameof(EnablePerfectForwardSecrecy)); }
            set { BackingStore?.Set(nameof(EnablePerfectForwardSecrecy), value); }
        }
        /// <summary>Enable Use Internal Subnet Attributes.</summary>
        public bool? EnableUseInternalSubnetAttributes {
            get { return BackingStore?.Get<bool?>(nameof(EnableUseInternalSubnetAttributes)); }
            set { BackingStore?.Set(nameof(EnableUseInternalSubnetAttributes), value); }
        }
        /// <summary>Method of identifying the client that is trying to connect via VPN. . Possible values are: deviceFQDN, empty, clientCertificateSubjectName.</summary>
        public VpnLocalIdentifier? LocalIdentifier {
            get { return BackingStore?.Get<VpnLocalIdentifier?>(nameof(LocalIdentifier)); }
            set { BackingStore?.Set(nameof(LocalIdentifier), value); }
        }
        /// <summary>Maximum transmission unit. Valid values 1280 to 1400</summary>
        public int? MtuSizeInBytes {
            get { return BackingStore?.Get<int?>(nameof(MtuSizeInBytes)); }
            set { BackingStore?.Set(nameof(MtuSizeInBytes), value); }
        }
        /// <summary>Address of the IKEv2 server. Must be a FQDN, UserFQDN, network address, or ASN1DN</summary>
        public string RemoteIdentifier {
            get { return BackingStore?.Get<string>(nameof(RemoteIdentifier)); }
            set { BackingStore?.Set(nameof(RemoteIdentifier), value); }
        }
        /// <summary>Security Association Parameters</summary>
        public IosVpnSecurityAssociationParameters SecurityAssociationParameters {
            get { return BackingStore?.Get<IosVpnSecurityAssociationParameters>(nameof(SecurityAssociationParameters)); }
            set { BackingStore?.Set(nameof(SecurityAssociationParameters), value); }
        }
        /// <summary>Common name of the IKEv2 Server Certificate used in Server Authentication</summary>
        public string ServerCertificateCommonName {
            get { return BackingStore?.Get<string>(nameof(ServerCertificateCommonName)); }
            set { BackingStore?.Set(nameof(ServerCertificateCommonName), value); }
        }
        /// <summary>Issuer Common name of the IKEv2 Server Certificate issuer used in Authentication</summary>
        public string ServerCertificateIssuerCommonName {
            get { return BackingStore?.Get<string>(nameof(ServerCertificateIssuerCommonName)); }
            set { BackingStore?.Set(nameof(ServerCertificateIssuerCommonName), value); }
        }
        /// <summary>The type of certificate the VPN server will present to the VPN client for authentication. Possible values are: rsa, ecdsa256, ecdsa384, ecdsa521.</summary>
        public VpnServerCertificateType? ServerCertificateType {
            get { return BackingStore?.Get<VpnServerCertificateType?>(nameof(ServerCertificateType)); }
            set { BackingStore?.Set(nameof(ServerCertificateType), value); }
        }
        /// <summary>Used when Shared Secret Authentication is selected</summary>
        public string SharedSecret {
            get { return BackingStore?.Get<string>(nameof(SharedSecret)); }
            set { BackingStore?.Set(nameof(SharedSecret), value); }
        }
        /// <summary>The maximum TLS version to be used with EAP-TLS authentication</summary>
        public string TlsMaximumVersion {
            get { return BackingStore?.Get<string>(nameof(TlsMaximumVersion)); }
            set { BackingStore?.Set(nameof(TlsMaximumVersion), value); }
        }
        /// <summary>The minimum TLS version to be used with EAP-TLS authentication</summary>
        public string TlsMinimumVersion {
            get { return BackingStore?.Get<string>(nameof(TlsMinimumVersion)); }
            set { BackingStore?.Set(nameof(TlsMinimumVersion), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new IosikEv2VpnConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new IosikEv2VpnConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"allowDefaultChildSecurityAssociationParameters", n => { AllowDefaultChildSecurityAssociationParameters = n.GetBoolValue(); } },
                {"allowDefaultSecurityAssociationParameters", n => { AllowDefaultSecurityAssociationParameters = n.GetBoolValue(); } },
                {"alwaysOnConfiguration", n => { AlwaysOnConfiguration = n.GetObjectValue<AppleVpnAlwaysOnConfiguration>(AppleVpnAlwaysOnConfiguration.CreateFromDiscriminatorValue); } },
                {"childSecurityAssociationParameters", n => { ChildSecurityAssociationParameters = n.GetObjectValue<IosVpnSecurityAssociationParameters>(IosVpnSecurityAssociationParameters.CreateFromDiscriminatorValue); } },
                {"clientAuthenticationType", n => { ClientAuthenticationType = n.GetEnumValue<VpnClientAuthenticationType>(); } },
                {"deadPeerDetectionRate", n => { DeadPeerDetectionRate = n.GetEnumValue<VpnDeadPeerDetectionRate>(); } },
                {"disableMobilityAndMultihoming", n => { DisableMobilityAndMultihoming = n.GetBoolValue(); } },
                {"disableRedirect", n => { DisableRedirect = n.GetBoolValue(); } },
                {"enableAlwaysOnConfiguration", n => { EnableAlwaysOnConfiguration = n.GetBoolValue(); } },
                {"enableCertificateRevocationCheck", n => { EnableCertificateRevocationCheck = n.GetBoolValue(); } },
                {"enableEAP", n => { EnableEAP = n.GetBoolValue(); } },
                {"enablePerfectForwardSecrecy", n => { EnablePerfectForwardSecrecy = n.GetBoolValue(); } },
                {"enableUseInternalSubnetAttributes", n => { EnableUseInternalSubnetAttributes = n.GetBoolValue(); } },
                {"localIdentifier", n => { LocalIdentifier = n.GetEnumValue<VpnLocalIdentifier>(); } },
                {"mtuSizeInBytes", n => { MtuSizeInBytes = n.GetIntValue(); } },
                {"remoteIdentifier", n => { RemoteIdentifier = n.GetStringValue(); } },
                {"securityAssociationParameters", n => { SecurityAssociationParameters = n.GetObjectValue<IosVpnSecurityAssociationParameters>(IosVpnSecurityAssociationParameters.CreateFromDiscriminatorValue); } },
                {"serverCertificateCommonName", n => { ServerCertificateCommonName = n.GetStringValue(); } },
                {"serverCertificateIssuerCommonName", n => { ServerCertificateIssuerCommonName = n.GetStringValue(); } },
                {"serverCertificateType", n => { ServerCertificateType = n.GetEnumValue<VpnServerCertificateType>(); } },
                {"sharedSecret", n => { SharedSecret = n.GetStringValue(); } },
                {"tlsMaximumVersion", n => { TlsMaximumVersion = n.GetStringValue(); } },
                {"tlsMinimumVersion", n => { TlsMinimumVersion = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("allowDefaultChildSecurityAssociationParameters", AllowDefaultChildSecurityAssociationParameters);
            writer.WriteBoolValue("allowDefaultSecurityAssociationParameters", AllowDefaultSecurityAssociationParameters);
            writer.WriteObjectValue<AppleVpnAlwaysOnConfiguration>("alwaysOnConfiguration", AlwaysOnConfiguration);
            writer.WriteObjectValue<IosVpnSecurityAssociationParameters>("childSecurityAssociationParameters", ChildSecurityAssociationParameters);
            writer.WriteEnumValue<VpnClientAuthenticationType>("clientAuthenticationType", ClientAuthenticationType);
            writer.WriteEnumValue<VpnDeadPeerDetectionRate>("deadPeerDetectionRate", DeadPeerDetectionRate);
            writer.WriteBoolValue("disableMobilityAndMultihoming", DisableMobilityAndMultihoming);
            writer.WriteBoolValue("disableRedirect", DisableRedirect);
            writer.WriteBoolValue("enableAlwaysOnConfiguration", EnableAlwaysOnConfiguration);
            writer.WriteBoolValue("enableCertificateRevocationCheck", EnableCertificateRevocationCheck);
            writer.WriteBoolValue("enableEAP", EnableEAP);
            writer.WriteBoolValue("enablePerfectForwardSecrecy", EnablePerfectForwardSecrecy);
            writer.WriteBoolValue("enableUseInternalSubnetAttributes", EnableUseInternalSubnetAttributes);
            writer.WriteEnumValue<VpnLocalIdentifier>("localIdentifier", LocalIdentifier);
            writer.WriteIntValue("mtuSizeInBytes", MtuSizeInBytes);
            writer.WriteStringValue("remoteIdentifier", RemoteIdentifier);
            writer.WriteObjectValue<IosVpnSecurityAssociationParameters>("securityAssociationParameters", SecurityAssociationParameters);
            writer.WriteStringValue("serverCertificateCommonName", ServerCertificateCommonName);
            writer.WriteStringValue("serverCertificateIssuerCommonName", ServerCertificateIssuerCommonName);
            writer.WriteEnumValue<VpnServerCertificateType>("serverCertificateType", ServerCertificateType);
            writer.WriteStringValue("sharedSecret", SharedSecret);
            writer.WriteStringValue("tlsMaximumVersion", TlsMaximumVersion);
            writer.WriteStringValue("tlsMinimumVersion", TlsMinimumVersion);
        }
    }
}
