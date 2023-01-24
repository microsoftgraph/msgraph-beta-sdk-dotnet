using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class AndroidWorkProfileEasEmailProfileBase : DeviceConfiguration, IParsable {
        /// <summary>Exchange Active Sync authentication method.</summary>
        public EasAuthenticationMethod? AuthenticationMethod {
            get { return BackingStore?.Get<EasAuthenticationMethod?>("authenticationMethod"); }
            set { BackingStore?.Set("authenticationMethod", value); }
        }
        /// <summary>Possible values for email sync duration.</summary>
        public EmailSyncDuration? DurationOfEmailToSync {
            get { return BackingStore?.Get<EmailSyncDuration?>("durationOfEmailToSync"); }
            set { BackingStore?.Set("durationOfEmailToSync", value); }
        }
        /// <summary>Possible values for username source or email source.</summary>
        public UserEmailSource? EmailAddressSource {
            get { return BackingStore?.Get<UserEmailSource?>("emailAddressSource"); }
            set { BackingStore?.Set("emailAddressSource", value); }
        }
        /// <summary>Exchange location (URL) that the mail app connects to.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? HostName {
            get { return BackingStore?.Get<string?>("hostName"); }
            set { BackingStore?.Set("hostName", value); }
        }
#nullable restore
#else
        public string HostName {
            get { return BackingStore?.Get<string>("hostName"); }
            set { BackingStore?.Set("hostName", value); }
        }
#endif
        /// <summary>Identity certificate.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public AndroidWorkProfileCertificateProfileBase? IdentityCertificate {
            get { return BackingStore?.Get<AndroidWorkProfileCertificateProfileBase?>("identityCertificate"); }
            set { BackingStore?.Set("identityCertificate", value); }
        }
#nullable restore
#else
        public AndroidWorkProfileCertificateProfileBase IdentityCertificate {
            get { return BackingStore?.Get<AndroidWorkProfileCertificateProfileBase>("identityCertificate"); }
            set { BackingStore?.Set("identityCertificate", value); }
        }
#endif
        /// <summary>Indicates whether or not to use SSL.</summary>
        public bool? RequireSsl {
            get { return BackingStore?.Get<bool?>("requireSsl"); }
            set { BackingStore?.Set("requireSsl", value); }
        }
        /// <summary>Android username source.</summary>
        public AndroidUsernameSource? UsernameSource {
            get { return BackingStore?.Get<AndroidUsernameSource?>("usernameSource"); }
            set { BackingStore?.Set("usernameSource", value); }
        }
        /// <summary>
        /// Instantiates a new AndroidWorkProfileEasEmailProfileBase and sets the default values.
        /// </summary>
        public AndroidWorkProfileEasEmailProfileBase() : base() {
            OdataType = "#microsoft.graph.androidWorkProfileEasEmailProfileBase";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new AndroidWorkProfileEasEmailProfileBase CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.androidWorkProfileGmailEasConfiguration" => new AndroidWorkProfileGmailEasConfiguration(),
                "#microsoft.graph.androidWorkProfileNineWorkEasConfiguration" => new AndroidWorkProfileNineWorkEasConfiguration(),
                _ => new AndroidWorkProfileEasEmailProfileBase(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"authenticationMethod", n => { AuthenticationMethod = n.GetEnumValue<EasAuthenticationMethod>(); } },
                {"durationOfEmailToSync", n => { DurationOfEmailToSync = n.GetEnumValue<EmailSyncDuration>(); } },
                {"emailAddressSource", n => { EmailAddressSource = n.GetEnumValue<UserEmailSource>(); } },
                {"hostName", n => { HostName = n.GetStringValue(); } },
                {"identityCertificate", n => { IdentityCertificate = n.GetObjectValue<AndroidWorkProfileCertificateProfileBase>(AndroidWorkProfileCertificateProfileBase.CreateFromDiscriminatorValue); } },
                {"requireSsl", n => { RequireSsl = n.GetBoolValue(); } },
                {"usernameSource", n => { UsernameSource = n.GetEnumValue<AndroidUsernameSource>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<EasAuthenticationMethod>("authenticationMethod", AuthenticationMethod);
            writer.WriteEnumValue<EmailSyncDuration>("durationOfEmailToSync", DurationOfEmailToSync);
            writer.WriteEnumValue<UserEmailSource>("emailAddressSource", EmailAddressSource);
            writer.WriteStringValue("hostName", HostName);
            writer.WriteObjectValue<AndroidWorkProfileCertificateProfileBase>("identityCertificate", IdentityCertificate);
            writer.WriteBoolValue("requireSsl", RequireSsl);
            writer.WriteEnumValue<AndroidUsernameSource>("usernameSource", UsernameSource);
        }
    }
}
