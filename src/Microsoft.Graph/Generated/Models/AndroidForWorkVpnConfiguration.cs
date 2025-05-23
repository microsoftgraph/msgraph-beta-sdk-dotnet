// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>
    /// By providing the configurations in this profile you can instruct the Android device to connect to desired VPN endpoint. By specifying the authentication method and security types expected by VPN endpoint you can make the VPN connection seamless for end user.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class AndroidForWorkVpnConfiguration : global::Microsoft.Graph.Beta.Models.DeviceConfiguration, IParsable
    {
        /// <summary>VPN Authentication Method.</summary>
        public global::Microsoft.Graph.Beta.Models.VpnAuthenticationMethod? AuthenticationMethod
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.VpnAuthenticationMethod?>("authenticationMethod"); }
            set { BackingStore?.Set("authenticationMethod", value); }
        }
        /// <summary>Connection name displayed to the user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ConnectionName
        {
            get { return BackingStore?.Get<string?>("connectionName"); }
            set { BackingStore?.Set("connectionName", value); }
        }
#nullable restore
#else
        public string ConnectionName
        {
            get { return BackingStore?.Get<string>("connectionName"); }
            set { BackingStore?.Set("connectionName", value); }
        }
#endif
        /// <summary>Android For Work VPN connection type.</summary>
        public global::Microsoft.Graph.Beta.Models.AndroidForWorkVpnConnectionType? ConnectionType
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.AndroidForWorkVpnConnectionType?>("connectionType"); }
            set { BackingStore?.Set("connectionType", value); }
        }
        /// <summary>Custom data when connection type is set to Citrix. This collection can contain a maximum of 25 elements.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.KeyValue>? CustomData
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.KeyValue>?>("customData"); }
            set { BackingStore?.Set("customData", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.KeyValue> CustomData
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.KeyValue>>("customData"); }
            set { BackingStore?.Set("customData", value); }
        }
#endif
        /// <summary>Custom data when connection type is set to Citrix. This collection can contain a maximum of 25 elements.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.KeyValuePair>? CustomKeyValueData
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.KeyValuePair>?>("customKeyValueData"); }
            set { BackingStore?.Set("customKeyValueData", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.KeyValuePair> CustomKeyValueData
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.KeyValuePair>>("customKeyValueData"); }
            set { BackingStore?.Set("customKeyValueData", value); }
        }
#endif
        /// <summary>Fingerprint is a string that will be used to verify the VPN server can be trusted, which is only applicable when connection type is Check Point Capsule VPN.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Fingerprint
        {
            get { return BackingStore?.Get<string?>("fingerprint"); }
            set { BackingStore?.Set("fingerprint", value); }
        }
#nullable restore
#else
        public string Fingerprint
        {
            get { return BackingStore?.Get<string>("fingerprint"); }
            set { BackingStore?.Set("fingerprint", value); }
        }
#endif
        /// <summary>Identity certificate for client authentication when authentication method is certificate.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.AndroidForWorkCertificateProfileBase? IdentityCertificate
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.AndroidForWorkCertificateProfileBase?>("identityCertificate"); }
            set { BackingStore?.Set("identityCertificate", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.AndroidForWorkCertificateProfileBase IdentityCertificate
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.AndroidForWorkCertificateProfileBase>("identityCertificate"); }
            set { BackingStore?.Set("identityCertificate", value); }
        }
#endif
        /// <summary>Realm when connection type is set to Pulse Secure.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Realm
        {
            get { return BackingStore?.Get<string?>("realm"); }
            set { BackingStore?.Set("realm", value); }
        }
#nullable restore
#else
        public string Realm
        {
            get { return BackingStore?.Get<string>("realm"); }
            set { BackingStore?.Set("realm", value); }
        }
#endif
        /// <summary>Role when connection type is set to Pulse Secure.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Role
        {
            get { return BackingStore?.Get<string?>("role"); }
            set { BackingStore?.Set("role", value); }
        }
#nullable restore
#else
        public string Role
        {
            get { return BackingStore?.Get<string>("role"); }
            set { BackingStore?.Set("role", value); }
        }
#endif
        /// <summary>List of VPN Servers on the network. Make sure end users can access these network locations. This collection can contain a maximum of 500 elements.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.VpnServer>? Servers
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.VpnServer>?>("servers"); }
            set { BackingStore?.Set("servers", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.VpnServer> Servers
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.VpnServer>>("servers"); }
            set { BackingStore?.Set("servers", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.AndroidForWorkVpnConfiguration"/> and sets the default values.
        /// </summary>
        public AndroidForWorkVpnConfiguration() : base()
        {
            OdataType = "#microsoft.graph.androidForWorkVpnConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.AndroidForWorkVpnConfiguration"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.AndroidForWorkVpnConfiguration CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.AndroidForWorkVpnConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "authenticationMethod", n => { AuthenticationMethod = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.VpnAuthenticationMethod>(); } },
                { "connectionName", n => { ConnectionName = n.GetStringValue(); } },
                { "connectionType", n => { ConnectionType = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.AndroidForWorkVpnConnectionType>(); } },
                { "customData", n => { CustomData = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.KeyValue>(global::Microsoft.Graph.Beta.Models.KeyValue.CreateFromDiscriminatorValue)?.AsList(); } },
                { "customKeyValueData", n => { CustomKeyValueData = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.KeyValuePair>(global::Microsoft.Graph.Beta.Models.KeyValuePair.CreateFromDiscriminatorValue)?.AsList(); } },
                { "fingerprint", n => { Fingerprint = n.GetStringValue(); } },
                { "identityCertificate", n => { IdentityCertificate = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.AndroidForWorkCertificateProfileBase>(global::Microsoft.Graph.Beta.Models.AndroidForWorkCertificateProfileBase.CreateFromDiscriminatorValue); } },
                { "realm", n => { Realm = n.GetStringValue(); } },
                { "role", n => { Role = n.GetStringValue(); } },
                { "servers", n => { Servers = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.VpnServer>(global::Microsoft.Graph.Beta.Models.VpnServer.CreateFromDiscriminatorValue)?.AsList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.VpnAuthenticationMethod>("authenticationMethod", AuthenticationMethod);
            writer.WriteStringValue("connectionName", ConnectionName);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.AndroidForWorkVpnConnectionType>("connectionType", ConnectionType);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.KeyValue>("customData", CustomData);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.KeyValuePair>("customKeyValueData", CustomKeyValueData);
            writer.WriteStringValue("fingerprint", Fingerprint);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.AndroidForWorkCertificateProfileBase>("identityCertificate", IdentityCertificate);
            writer.WriteStringValue("realm", Realm);
            writer.WriteStringValue("role", Role);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.VpnServer>("servers", Servers);
        }
    }
}
#pragma warning restore CS0618
