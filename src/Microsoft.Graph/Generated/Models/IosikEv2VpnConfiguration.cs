using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class IosikEv2VpnConfiguration : IosVpnConfiguration, IParsable {
        /// <summary>Allows the use of child security association parameters by setting all parameters to the device&apos;s default unless explicitly specified.</summary>
        public bool? AllowDefaultChildSecurityAssociationParameters {
            get { return BackingStore?.Get<bool?>("allowDefaultChildSecurityAssociationParameters"); }
            set { BackingStore?.Set("allowDefaultChildSecurityAssociationParameters", value); }
        }
        /// <summary>Allows the use of security association parameters by setting all parameters to the device&apos;s default unless explicitly specified.</summary>
        public bool? AllowDefaultSecurityAssociationParameters {
            get { return BackingStore?.Get<bool?>("allowDefaultSecurityAssociationParameters"); }
            set { BackingStore?.Set("allowDefaultSecurityAssociationParameters", value); }
        }
        /// <summary>AlwaysOn Configuration</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public AppleVpnAlwaysOnConfiguration? AlwaysOnConfiguration {
            get { return BackingStore?.Get<AppleVpnAlwaysOnConfiguration?>("alwaysOnConfiguration"); }
            set { BackingStore?.Set("alwaysOnConfiguration", value); }
        }
#else
        public AppleVpnAlwaysOnConfiguration AlwaysOnConfiguration {
            get { return BackingStore?.Get<AppleVpnAlwaysOnConfiguration>("alwaysOnConfiguration"); }
            set { BackingStore?.Set("alwaysOnConfiguration", value); }
        }
#endif
        /// <summary>Child Security Association Parameters</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public IosVpnSecurityAssociationParameters? ChildSecurityAssociationParameters {
            get { return BackingStore?.Get<IosVpnSecurityAssociationParameters?>("childSecurityAssociationParameters"); }
            set { BackingStore?.Set("childSecurityAssociationParameters", value); }
        }
#else
        public IosVpnSecurityAssociationParameters ChildSecurityAssociationParameters {
            get { return BackingStore?.Get<IosVpnSecurityAssociationParameters>("childSecurityAssociationParameters"); }
            set { BackingStore?.Set("childSecurityAssociationParameters", value); }
        }
#endif
        /// <summary>The type of VPN client authentication type</summary>
        public VpnClientAuthenticationType? ClientAuthenticationType {
            get { return BackingStore?.Get<VpnClientAuthenticationType?>("clientAuthenticationType"); }
            set { BackingStore?.Set("clientAuthenticationType", value); }
        }
        /// <summary>Determine how often to check if a peer connection is still active. . Possible values are: medium, none, low, high.</summary>
        public VpnDeadPeerDetectionRate? DeadPeerDetectionRate {
            get { return BackingStore?.Get<VpnDeadPeerDetectionRate?>("deadPeerDetectionRate"); }
            set { BackingStore?.Set("deadPeerDetectionRate", value); }
        }
        /// <summary>Disable MOBIKE</summary>
        public bool? DisableMobilityAndMultihoming {
            get { return BackingStore?.Get<bool?>("disableMobilityAndMultihoming"); }
            set { BackingStore?.Set("disableMobilityAndMultihoming", value); }
        }
        /// <summary>Disable Redirect</summary>
        public bool? DisableRedirect {
            get { return BackingStore?.Get<bool?>("disableRedirect"); }
            set { BackingStore?.Set("disableRedirect", value); }
        }
        /// <summary>Determines if Always on VPN is enabled</summary>
        public bool? EnableAlwaysOnConfiguration {
            get { return BackingStore?.Get<bool?>("enableAlwaysOnConfiguration"); }
            set { BackingStore?.Set("enableAlwaysOnConfiguration", value); }
        }
        /// <summary>Enables a best-effort revocation check; server response timeouts will not cause it to fail</summary>
        public bool? EnableCertificateRevocationCheck {
            get { return BackingStore?.Get<bool?>("enableCertificateRevocationCheck"); }
            set { BackingStore?.Set("enableCertificateRevocationCheck", value); }
        }
        /// <summary>Enables EAP only authentication</summary>
        public bool? EnableEAP {
            get { return BackingStore?.Get<bool?>("enableEAP"); }
            set { BackingStore?.Set("enableEAP", value); }
        }
        /// <summary>Enable Perfect Forward Secrecy (PFS).</summary>
        public bool? EnablePerfectForwardSecrecy {
            get { return BackingStore?.Get<bool?>("enablePerfectForwardSecrecy"); }
            set { BackingStore?.Set("enablePerfectForwardSecrecy", value); }
        }
        /// <summary>Enable Use Internal Subnet Attributes.</summary>
        public bool? EnableUseInternalSubnetAttributes {
            get { return BackingStore?.Get<bool?>("enableUseInternalSubnetAttributes"); }
            set { BackingStore?.Set("enableUseInternalSubnetAttributes", value); }
        }
        /// <summary>The type of VPN local identifier</summary>
        public VpnLocalIdentifier? LocalIdentifier {
            get { return BackingStore?.Get<VpnLocalIdentifier?>("localIdentifier"); }
            set { BackingStore?.Set("localIdentifier", value); }
        }
        /// <summary>Maximum transmission unit. Valid values 1280 to 1400</summary>
        public int? MtuSizeInBytes {
            get { return BackingStore?.Get<int?>("mtuSizeInBytes"); }
            set { BackingStore?.Set("mtuSizeInBytes", value); }
        }
        /// <summary>Address of the IKEv2 server. Must be a FQDN, UserFQDN, network address, or ASN1DN</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? RemoteIdentifier {
            get { return BackingStore?.Get<string?>("remoteIdentifier"); }
            set { BackingStore?.Set("remoteIdentifier", value); }
        }
#else
        public string RemoteIdentifier {
            get { return BackingStore?.Get<string>("remoteIdentifier"); }
            set { BackingStore?.Set("remoteIdentifier", value); }
        }
#endif
        /// <summary>Security Association Parameters</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public IosVpnSecurityAssociationParameters? SecurityAssociationParameters {
            get { return BackingStore?.Get<IosVpnSecurityAssociationParameters?>("securityAssociationParameters"); }
            set { BackingStore?.Set("securityAssociationParameters", value); }
        }
#else
        public IosVpnSecurityAssociationParameters SecurityAssociationParameters {
            get { return BackingStore?.Get<IosVpnSecurityAssociationParameters>("securityAssociationParameters"); }
            set { BackingStore?.Set("securityAssociationParameters", value); }
        }
#endif
        /// <summary>Common name of the IKEv2 Server Certificate used in Server Authentication</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? ServerCertificateCommonName {
            get { return BackingStore?.Get<string?>("serverCertificateCommonName"); }
            set { BackingStore?.Set("serverCertificateCommonName", value); }
        }
#else
        public string ServerCertificateCommonName {
            get { return BackingStore?.Get<string>("serverCertificateCommonName"); }
            set { BackingStore?.Set("serverCertificateCommonName", value); }
        }
#endif
        /// <summary>Issuer Common name of the IKEv2 Server Certificate issuer used in Authentication</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? ServerCertificateIssuerCommonName {
            get { return BackingStore?.Get<string?>("serverCertificateIssuerCommonName"); }
            set { BackingStore?.Set("serverCertificateIssuerCommonName", value); }
        }
#else
        public string ServerCertificateIssuerCommonName {
            get { return BackingStore?.Get<string>("serverCertificateIssuerCommonName"); }
            set { BackingStore?.Set("serverCertificateIssuerCommonName", value); }
        }
#endif
        /// <summary>The type of certificate the VPN server will present to the VPN client for authentication. Possible values are: rsa, ecdsa256, ecdsa384, ecdsa521.</summary>
        public VpnServerCertificateType? ServerCertificateType {
            get { return BackingStore?.Get<VpnServerCertificateType?>("serverCertificateType"); }
            set { BackingStore?.Set("serverCertificateType", value); }
        }
        /// <summary>Used when Shared Secret Authentication is selected</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? SharedSecret {
            get { return BackingStore?.Get<string?>("sharedSecret"); }
            set { BackingStore?.Set("sharedSecret", value); }
        }
#else
        public string SharedSecret {
            get { return BackingStore?.Get<string>("sharedSecret"); }
            set { BackingStore?.Set("sharedSecret", value); }
        }
#endif
        /// <summary>The maximum TLS version to be used with EAP-TLS authentication</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? TlsMaximumVersion {
            get { return BackingStore?.Get<string?>("tlsMaximumVersion"); }
            set { BackingStore?.Set("tlsMaximumVersion", value); }
        }
#else
        public string TlsMaximumVersion {
            get { return BackingStore?.Get<string>("tlsMaximumVersion"); }
            set { BackingStore?.Set("tlsMaximumVersion", value); }
        }
#endif
        /// <summary>The minimum TLS version to be used with EAP-TLS authentication</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? TlsMinimumVersion {
            get { return BackingStore?.Get<string?>("tlsMinimumVersion"); }
            set { BackingStore?.Set("tlsMinimumVersion", value); }
        }
#else
        public string TlsMinimumVersion {
            get { return BackingStore?.Get<string>("tlsMinimumVersion"); }
            set { BackingStore?.Set("tlsMinimumVersion", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new IosikEv2VpnConfiguration and sets the default values.
        /// </summary>
        public IosikEv2VpnConfiguration() : base() {
            OdataType = "#microsoft.graph.iosikEv2VpnConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
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
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
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
