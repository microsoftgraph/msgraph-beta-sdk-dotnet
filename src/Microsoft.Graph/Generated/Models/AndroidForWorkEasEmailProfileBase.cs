using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class AndroidForWorkEasEmailProfileBase : DeviceConfiguration, IParsable {
        /// <summary>Authentication method for Exchange ActiveSync. Possible values are: usernameAndPassword, certificate, derivedCredential.</summary>
        public EasAuthenticationMethod? AuthenticationMethod {
            get { return BackingStore?.Get<EasAuthenticationMethod?>(nameof(AuthenticationMethod)); }
            set { BackingStore?.Set(nameof(AuthenticationMethod), value); }
        }
        /// <summary>Duration of time email should be synced to. Possible values are: userDefined, oneDay, threeDays, oneWeek, twoWeeks, oneMonth, unlimited.</summary>
        public EmailSyncDuration? DurationOfEmailToSync {
            get { return BackingStore?.Get<EmailSyncDuration?>(nameof(DurationOfEmailToSync)); }
            set { BackingStore?.Set(nameof(DurationOfEmailToSync), value); }
        }
        /// <summary>Email attribute that is picked from AAD and injected into this profile before installing on the device. Possible values are: userPrincipalName, primarySmtpAddress.</summary>
        public UserEmailSource? EmailAddressSource {
            get { return BackingStore?.Get<UserEmailSource?>(nameof(EmailAddressSource)); }
            set { BackingStore?.Set(nameof(EmailAddressSource), value); }
        }
        /// <summary>Exchange location (URL) that the mail app connects to.</summary>
        public string HostName {
            get { return BackingStore?.Get<string>(nameof(HostName)); }
            set { BackingStore?.Set(nameof(HostName), value); }
        }
        /// <summary>Identity certificate.</summary>
        public AndroidForWorkCertificateProfileBase IdentityCertificate {
            get { return BackingStore?.Get<AndroidForWorkCertificateProfileBase>(nameof(IdentityCertificate)); }
            set { BackingStore?.Set(nameof(IdentityCertificate), value); }
        }
        /// <summary>Indicates whether or not to use SSL.</summary>
        public bool? RequireSsl {
            get { return BackingStore?.Get<bool?>(nameof(RequireSsl)); }
            set { BackingStore?.Set(nameof(RequireSsl), value); }
        }
        /// <summary>Username attribute that is picked from AAD and injected into this profile before installing on the device. Possible values are: username, userPrincipalName, samAccountName, primarySmtpAddress.</summary>
        public AndroidUsernameSource? UsernameSource {
            get { return BackingStore?.Get<AndroidUsernameSource?>(nameof(UsernameSource)); }
            set { BackingStore?.Set(nameof(UsernameSource), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new AndroidForWorkEasEmailProfileBase CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AndroidForWorkEasEmailProfileBase();
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
                {"identityCertificate", n => { IdentityCertificate = n.GetObjectValue<AndroidForWorkCertificateProfileBase>(AndroidForWorkCertificateProfileBase.CreateFromDiscriminatorValue); } },
                {"requireSsl", n => { RequireSsl = n.GetBoolValue(); } },
                {"usernameSource", n => { UsernameSource = n.GetEnumValue<AndroidUsernameSource>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<EasAuthenticationMethod>("authenticationMethod", AuthenticationMethod);
            writer.WriteEnumValue<EmailSyncDuration>("durationOfEmailToSync", DurationOfEmailToSync);
            writer.WriteEnumValue<UserEmailSource>("emailAddressSource", EmailAddressSource);
            writer.WriteStringValue("hostName", HostName);
            writer.WriteObjectValue<AndroidForWorkCertificateProfileBase>("identityCertificate", IdentityCertificate);
            writer.WriteBoolValue("requireSsl", RequireSsl);
            writer.WriteEnumValue<AndroidUsernameSource>("usernameSource", UsernameSource);
        }
    }
}
