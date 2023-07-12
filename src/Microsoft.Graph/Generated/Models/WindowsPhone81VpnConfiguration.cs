using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// By providing the configurations in this profile you can instruct the Windows Phone 8.1 to connect to desired VPN endpoint. By specifying the authentication method and security types expected by VPN endpoint you can make the VPN connection seamless for end user.
    /// </summary>
    public class WindowsPhone81VpnConfiguration : Windows81VpnConfiguration, IParsable {
        /// <summary>VPN Authentication Method.</summary>
        public VpnAuthenticationMethod? AuthenticationMethod {
            get { return BackingStore?.Get<VpnAuthenticationMethod?>("authenticationMethod"); }
            set { BackingStore?.Set("authenticationMethod", value); }
        }
        /// <summary>Bypass VPN on company Wi-Fi.</summary>
        public bool? BypassVpnOnCompanyWifi {
            get { return BackingStore?.Get<bool?>("bypassVpnOnCompanyWifi"); }
            set { BackingStore?.Set("bypassVpnOnCompanyWifi", value); }
        }
        /// <summary>Bypass VPN on home Wi-Fi.</summary>
        public bool? BypassVpnOnHomeWifi {
            get { return BackingStore?.Get<bool?>("bypassVpnOnHomeWifi"); }
            set { BackingStore?.Set("bypassVpnOnHomeWifi", value); }
        }
        /// <summary>DNS suffix search list.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? DnsSuffixSearchList {
            get { return BackingStore?.Get<List<string>?>("dnsSuffixSearchList"); }
            set { BackingStore?.Set("dnsSuffixSearchList", value); }
        }
#nullable restore
#else
        public List<string> DnsSuffixSearchList {
            get { return BackingStore?.Get<List<string>>("dnsSuffixSearchList"); }
            set { BackingStore?.Set("dnsSuffixSearchList", value); }
        }
#endif
        /// <summary>Identity certificate for client authentication when authentication method is certificate.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public WindowsPhone81CertificateProfileBase? IdentityCertificate {
            get { return BackingStore?.Get<WindowsPhone81CertificateProfileBase?>("identityCertificate"); }
            set { BackingStore?.Set("identityCertificate", value); }
        }
#nullable restore
#else
        public WindowsPhone81CertificateProfileBase IdentityCertificate {
            get { return BackingStore?.Get<WindowsPhone81CertificateProfileBase>("identityCertificate"); }
            set { BackingStore?.Set("identityCertificate", value); }
        }
#endif
        /// <summary>Remember user credentials.</summary>
        public bool? RememberUserCredentials {
            get { return BackingStore?.Get<bool?>("rememberUserCredentials"); }
            set { BackingStore?.Set("rememberUserCredentials", value); }
        }
        /// <summary>
        /// Instantiates a new windowsPhone81VpnConfiguration and sets the default values.
        /// </summary>
        public WindowsPhone81VpnConfiguration() : base() {
            OdataType = "#microsoft.graph.windowsPhone81VpnConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new WindowsPhone81VpnConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WindowsPhone81VpnConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"authenticationMethod", n => { AuthenticationMethod = n.GetEnumValue<VpnAuthenticationMethod>(); } },
                {"bypassVpnOnCompanyWifi", n => { BypassVpnOnCompanyWifi = n.GetBoolValue(); } },
                {"bypassVpnOnHomeWifi", n => { BypassVpnOnHomeWifi = n.GetBoolValue(); } },
                {"dnsSuffixSearchList", n => { DnsSuffixSearchList = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"identityCertificate", n => { IdentityCertificate = n.GetObjectValue<WindowsPhone81CertificateProfileBase>(WindowsPhone81CertificateProfileBase.CreateFromDiscriminatorValue); } },
                {"rememberUserCredentials", n => { RememberUserCredentials = n.GetBoolValue(); } },
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
            writer.WriteBoolValue("bypassVpnOnCompanyWifi", BypassVpnOnCompanyWifi);
            writer.WriteBoolValue("bypassVpnOnHomeWifi", BypassVpnOnHomeWifi);
            writer.WriteCollectionOfPrimitiveValues<string>("dnsSuffixSearchList", DnsSuffixSearchList);
            writer.WriteObjectValue<WindowsPhone81CertificateProfileBase>("identityCertificate", IdentityCertificate);
            writer.WriteBoolValue("rememberUserCredentials", RememberUserCredentials);
        }
    }
}
