using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class UserPFXCertificate : Entity, IParsable {
        /// <summary>Date/time when this PFX certificate was imported.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>Encrypted PFX blob.</summary>
        public byte[] EncryptedPfxBlob { get; set; }
        /// <summary>Encrypted PFX password.</summary>
        public string EncryptedPfxPassword { get; set; }
        /// <summary>Certificate's validity expiration date/time.</summary>
        public DateTimeOffset? ExpirationDateTime { get; set; }
        /// <summary>Certificate's intended purpose from the point-of-view of deployment. Possible values are: unassigned, smimeEncryption, smimeSigning, vpn, wifi.</summary>
        public UserPfxIntendedPurpose? IntendedPurpose { get; set; }
        /// <summary>Name of the key (within the provider) used to encrypt the blob.</summary>
        public string KeyName { get; set; }
        /// <summary>Date/time when this PFX certificate was last modified.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>Padding scheme used by the provider during encryption/decryption. Possible values are: none, pkcs1, oaepSha1, oaepSha256, oaepSha384, oaepSha512.</summary>
        public UserPfxPaddingScheme? PaddingScheme { get; set; }
        /// <summary>Crypto provider used to encrypt this blob.</summary>
        public string ProviderName { get; set; }
        /// <summary>Certificate's validity start date/time.</summary>
        public DateTimeOffset? StartDateTime { get; set; }
        /// <summary>SHA-1 thumbprint of the PFX certificate.</summary>
        public string Thumbprint { get; set; }
        /// <summary>User Principal Name of the PFX certificate.</summary>
        public string UserPrincipalName { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"createdDateTime", (o,n) => { (o as UserPFXCertificate).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"encryptedPfxBlob", (o,n) => { (o as UserPFXCertificate).EncryptedPfxBlob = n.GetByteArrayValue(); } },
                {"encryptedPfxPassword", (o,n) => { (o as UserPFXCertificate).EncryptedPfxPassword = n.GetStringValue(); } },
                {"expirationDateTime", (o,n) => { (o as UserPFXCertificate).ExpirationDateTime = n.GetDateTimeOffsetValue(); } },
                {"intendedPurpose", (o,n) => { (o as UserPFXCertificate).IntendedPurpose = n.GetEnumValue<UserPfxIntendedPurpose>(); } },
                {"keyName", (o,n) => { (o as UserPFXCertificate).KeyName = n.GetStringValue(); } },
                {"lastModifiedDateTime", (o,n) => { (o as UserPFXCertificate).LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"paddingScheme", (o,n) => { (o as UserPFXCertificate).PaddingScheme = n.GetEnumValue<UserPfxPaddingScheme>(); } },
                {"providerName", (o,n) => { (o as UserPFXCertificate).ProviderName = n.GetStringValue(); } },
                {"startDateTime", (o,n) => { (o as UserPFXCertificate).StartDateTime = n.GetDateTimeOffsetValue(); } },
                {"thumbprint", (o,n) => { (o as UserPFXCertificate).Thumbprint = n.GetStringValue(); } },
                {"userPrincipalName", (o,n) => { (o as UserPFXCertificate).UserPrincipalName = n.GetStringValue(); } },
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
