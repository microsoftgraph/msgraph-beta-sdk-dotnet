using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class UserPFXCertificate : Entity, IParsable {
        /// <summary>Date/time when this PFX certificate was imported.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>Encrypted PFX blob.</summary>
        public byte[] EncryptedPfxBlob { get; set; }
        /// <summary>Encrypted PFX password.</summary>
        public string EncryptedPfxPassword { get; set; }
        /// <summary>Certificate&apos;s validity expiration date/time.</summary>
        public DateTimeOffset? ExpirationDateTime { get; set; }
        /// <summary>Certificate&apos;s intended purpose from the point-of-view of deployment. Possible values are: unassigned, smimeEncryption, smimeSigning, vpn, wifi.</summary>
        public UserPfxIntendedPurpose? IntendedPurpose { get; set; }
        /// <summary>Name of the key (within the provider) used to encrypt the blob.</summary>
        public string KeyName { get; set; }
        /// <summary>Date/time when this PFX certificate was last modified.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>Padding scheme used by the provider during encryption/decryption. Possible values are: none, pkcs1, oaepSha1, oaepSha256, oaepSha384, oaepSha512.</summary>
        public UserPfxPaddingScheme? PaddingScheme { get; set; }
        /// <summary>Crypto provider used to encrypt this blob.</summary>
        public string ProviderName { get; set; }
        /// <summary>Certificate&apos;s validity start date/time.</summary>
        public DateTimeOffset? StartDateTime { get; set; }
        /// <summary>SHA-1 thumbprint of the PFX certificate.</summary>
        public string Thumbprint { get; set; }
        /// <summary>User Principal Name of the PFX certificate.</summary>
        public string UserPrincipalName { get; set; }
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
