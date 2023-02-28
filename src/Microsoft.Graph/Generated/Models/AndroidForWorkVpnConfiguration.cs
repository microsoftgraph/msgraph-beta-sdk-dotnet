using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class AndroidForWorkVpnConfiguration : DeviceConfiguration, IParsable {
        /// <summary>VPN Authentication Method.</summary>
        public VpnAuthenticationMethod? AuthenticationMethod {
            get { return BackingStore?.Get<VpnAuthenticationMethod?>("authenticationMethod"); }
            set { BackingStore?.Set("authenticationMethod", value); }
        }
        /// <summary>Connection name displayed to the user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ConnectionName {
            get { return BackingStore?.Get<string?>("connectionName"); }
            set { BackingStore?.Set("connectionName", value); }
        }
#nullable restore
#else
        public string ConnectionName {
            get { return BackingStore?.Get<string>("connectionName"); }
            set { BackingStore?.Set("connectionName", value); }
        }
#endif
        /// <summary>Android For Work VPN connection type.</summary>
        public AndroidForWorkVpnConnectionType? ConnectionType {
            get { return BackingStore?.Get<AndroidForWorkVpnConnectionType?>("connectionType"); }
            set { BackingStore?.Set("connectionType", value); }
        }
        /// <summary>Custom data when connection type is set to Citrix. This collection can contain a maximum of 25 elements.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<KeyValue>? CustomData {
            get { return BackingStore?.Get<List<KeyValue>?>("customData"); }
            set { BackingStore?.Set("customData", value); }
        }
#nullable restore
#else
        public List<KeyValue> CustomData {
            get { return BackingStore?.Get<List<KeyValue>>("customData"); }
            set { BackingStore?.Set("customData", value); }
        }
#endif
        /// <summary>Custom data when connection type is set to Citrix. This collection can contain a maximum of 25 elements.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<KeyValuePair>? CustomKeyValueData {
            get { return BackingStore?.Get<List<KeyValuePair>?>("customKeyValueData"); }
            set { BackingStore?.Set("customKeyValueData", value); }
        }
#nullable restore
#else
        public List<KeyValuePair> CustomKeyValueData {
            get { return BackingStore?.Get<List<KeyValuePair>>("customKeyValueData"); }
            set { BackingStore?.Set("customKeyValueData", value); }
        }
#endif
        /// <summary>Fingerprint is a string that will be used to verify the VPN server can be trusted, which is only applicable when connection type is Check Point Capsule VPN.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Fingerprint {
            get { return BackingStore?.Get<string?>("fingerprint"); }
            set { BackingStore?.Set("fingerprint", value); }
        }
#nullable restore
#else
        public string Fingerprint {
            get { return BackingStore?.Get<string>("fingerprint"); }
            set { BackingStore?.Set("fingerprint", value); }
        }
#endif
        /// <summary>Identity certificate for client authentication when authentication method is certificate.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public AndroidForWorkCertificateProfileBase? IdentityCertificate {
            get { return BackingStore?.Get<AndroidForWorkCertificateProfileBase?>("identityCertificate"); }
            set { BackingStore?.Set("identityCertificate", value); }
        }
#nullable restore
#else
        public AndroidForWorkCertificateProfileBase IdentityCertificate {
            get { return BackingStore?.Get<AndroidForWorkCertificateProfileBase>("identityCertificate"); }
            set { BackingStore?.Set("identityCertificate", value); }
        }
#endif
        /// <summary>Realm when connection type is set to Pulse Secure.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Realm {
            get { return BackingStore?.Get<string?>("realm"); }
            set { BackingStore?.Set("realm", value); }
        }
#nullable restore
#else
        public string Realm {
            get { return BackingStore?.Get<string>("realm"); }
            set { BackingStore?.Set("realm", value); }
        }
#endif
        /// <summary>Role when connection type is set to Pulse Secure.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Role {
            get { return BackingStore?.Get<string?>("role"); }
            set { BackingStore?.Set("role", value); }
        }
#nullable restore
#else
        public string Role {
            get { return BackingStore?.Get<string>("role"); }
            set { BackingStore?.Set("role", value); }
        }
#endif
        /// <summary>List of VPN Servers on the network. Make sure end users can access these network locations. This collection can contain a maximum of 500 elements.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<VpnServer>? Servers {
            get { return BackingStore?.Get<List<VpnServer>?>("servers"); }
            set { BackingStore?.Set("servers", value); }
        }
#nullable restore
#else
        public List<VpnServer> Servers {
            get { return BackingStore?.Get<List<VpnServer>>("servers"); }
            set { BackingStore?.Set("servers", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new AndroidForWorkVpnConfiguration and sets the default values.
        /// </summary>
        public AndroidForWorkVpnConfiguration() : base() {
            OdataType = "#microsoft.graph.androidForWorkVpnConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new AndroidForWorkVpnConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AndroidForWorkVpnConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"authenticationMethod", n => { AuthenticationMethod = n.GetEnumValue<VpnAuthenticationMethod>(); } },
                {"connectionName", n => { ConnectionName = n.GetStringValue(); } },
                {"connectionType", n => { ConnectionType = n.GetEnumValue<AndroidForWorkVpnConnectionType>(); } },
                {"customData", n => { CustomData = n.GetCollectionOfObjectValues<KeyValue>(KeyValue.CreateFromDiscriminatorValue)?.ToList(); } },
                {"customKeyValueData", n => { CustomKeyValueData = n.GetCollectionOfObjectValues<KeyValuePair>(KeyValuePair.CreateFromDiscriminatorValue)?.ToList(); } },
                {"fingerprint", n => { Fingerprint = n.GetStringValue(); } },
                {"identityCertificate", n => { IdentityCertificate = n.GetObjectValue<AndroidForWorkCertificateProfileBase>(AndroidForWorkCertificateProfileBase.CreateFromDiscriminatorValue); } },
                {"realm", n => { Realm = n.GetStringValue(); } },
                {"role", n => { Role = n.GetStringValue(); } },
                {"servers", n => { Servers = n.GetCollectionOfObjectValues<VpnServer>(VpnServer.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<VpnAuthenticationMethod>("authenticationMethod", AuthenticationMethod);
            writer.WriteStringValue("connectionName", ConnectionName);
            writer.WriteEnumValue<AndroidForWorkVpnConnectionType>("connectionType", ConnectionType);
            writer.WriteCollectionOfObjectValues<KeyValue>("customData", CustomData);
            writer.WriteCollectionOfObjectValues<KeyValuePair>("customKeyValueData", CustomKeyValueData);
            writer.WriteStringValue("fingerprint", Fingerprint);
            writer.WriteObjectValue<AndroidForWorkCertificateProfileBase>("identityCertificate", IdentityCertificate);
            writer.WriteStringValue("realm", Realm);
            writer.WriteStringValue("role", Role);
            writer.WriteCollectionOfObjectValues<VpnServer>("servers", Servers);
        }
    }
}
