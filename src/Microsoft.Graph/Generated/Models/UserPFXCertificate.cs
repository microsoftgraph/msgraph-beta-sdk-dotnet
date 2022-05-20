using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Entity that encapsulates all information required for a user&apos;s PFX certificates.</summary>
    public class UserPFXCertificate : Entity, IParsable {
        /// <summary>Date/time when this PFX certificate was imported.</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(CreatedDateTime)); }
            set { BackingStore?.Set(nameof(CreatedDateTime), value); }
        }
        /// <summary>Encrypted PFX blob.</summary>
        public byte[] EncryptedPfxBlob {
            get { return BackingStore?.Get<byte[]>(nameof(EncryptedPfxBlob)); }
            set { BackingStore?.Set(nameof(EncryptedPfxBlob), value); }
        }
        /// <summary>Encrypted PFX password.</summary>
        public string EncryptedPfxPassword {
            get { return BackingStore?.Get<string>(nameof(EncryptedPfxPassword)); }
            set { BackingStore?.Set(nameof(EncryptedPfxPassword), value); }
        }
        /// <summary>Certificate&apos;s validity expiration date/time.</summary>
        public DateTimeOffset? ExpirationDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(ExpirationDateTime)); }
            set { BackingStore?.Set(nameof(ExpirationDateTime), value); }
        }
        /// <summary>Certificate&apos;s intended purpose from the point-of-view of deployment. Possible values are: unassigned, smimeEncryption, smimeSigning, vpn, wifi.</summary>
        public UserPfxIntendedPurpose? IntendedPurpose {
            get { return BackingStore?.Get<UserPfxIntendedPurpose?>(nameof(IntendedPurpose)); }
            set { BackingStore?.Set(nameof(IntendedPurpose), value); }
        }
        /// <summary>Name of the key (within the provider) used to encrypt the blob.</summary>
        public string KeyName {
            get { return BackingStore?.Get<string>(nameof(KeyName)); }
            set { BackingStore?.Set(nameof(KeyName), value); }
        }
        /// <summary>Date/time when this PFX certificate was last modified.</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(LastModifiedDateTime)); }
            set { BackingStore?.Set(nameof(LastModifiedDateTime), value); }
        }
        /// <summary>Padding scheme used by the provider during encryption/decryption. Possible values are: none, pkcs1, oaepSha1, oaepSha256, oaepSha384, oaepSha512.</summary>
        public UserPfxPaddingScheme? PaddingScheme {
            get { return BackingStore?.Get<UserPfxPaddingScheme?>(nameof(PaddingScheme)); }
            set { BackingStore?.Set(nameof(PaddingScheme), value); }
        }
        /// <summary>Crypto provider used to encrypt this blob.</summary>
        public string ProviderName {
            get { return BackingStore?.Get<string>(nameof(ProviderName)); }
            set { BackingStore?.Set(nameof(ProviderName), value); }
        }
        /// <summary>Certificate&apos;s validity start date/time.</summary>
        public DateTimeOffset? StartDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(StartDateTime)); }
            set { BackingStore?.Set(nameof(StartDateTime), value); }
        }
        /// <summary>SHA-1 thumbprint of the PFX certificate.</summary>
        public string Thumbprint {
            get { return BackingStore?.Get<string>(nameof(Thumbprint)); }
            set { BackingStore?.Set(nameof(Thumbprint), value); }
        }
        /// <summary>User Principal Name of the PFX certificate.</summary>
        public string UserPrincipalName {
            get { return BackingStore?.Get<string>(nameof(UserPrincipalName)); }
            set { BackingStore?.Set(nameof(UserPrincipalName), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new UserPFXCertificate CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserPFXCertificate();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"encryptedPfxBlob", n => { EncryptedPfxBlob = n.GetByteArrayValue(); } },
                {"encryptedPfxPassword", n => { EncryptedPfxPassword = n.GetStringValue(); } },
                {"expirationDateTime", n => { ExpirationDateTime = n.GetDateTimeOffsetValue(); } },
                {"intendedPurpose", n => { IntendedPurpose = n.GetEnumValue<UserPfxIntendedPurpose>(); } },
                {"keyName", n => { KeyName = n.GetStringValue(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"paddingScheme", n => { PaddingScheme = n.GetEnumValue<UserPfxPaddingScheme>(); } },
                {"providerName", n => { ProviderName = n.GetStringValue(); } },
                {"startDateTime", n => { StartDateTime = n.GetDateTimeOffsetValue(); } },
                {"thumbprint", n => { Thumbprint = n.GetStringValue(); } },
                {"userPrincipalName", n => { UserPrincipalName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteByteArrayValue("encryptedPfxBlob", EncryptedPfxBlob);
            writer.WriteStringValue("encryptedPfxPassword", EncryptedPfxPassword);
            writer.WriteDateTimeOffsetValue("expirationDateTime", ExpirationDateTime);
            writer.WriteEnumValue<UserPfxIntendedPurpose>("intendedPurpose", IntendedPurpose);
            writer.WriteStringValue("keyName", KeyName);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteEnumValue<UserPfxPaddingScheme>("paddingScheme", PaddingScheme);
            writer.WriteStringValue("providerName", ProviderName);
            writer.WriteDateTimeOffsetValue("startDateTime", StartDateTime);
            writer.WriteStringValue("thumbprint", Thumbprint);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
        }
    }
}
