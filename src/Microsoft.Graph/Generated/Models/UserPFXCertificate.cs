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
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>Encrypted PFX blob.</summary>
        public byte[] EncryptedPfxBlob {
            get { return BackingStore?.Get<byte[]>("encryptedPfxBlob"); }
            set { BackingStore?.Set("encryptedPfxBlob", value); }
        }
        /// <summary>Encrypted PFX password.</summary>
        public string EncryptedPfxPassword {
            get { return BackingStore?.Get<string>("encryptedPfxPassword"); }
            set { BackingStore?.Set("encryptedPfxPassword", value); }
        }
        /// <summary>Certificate&apos;s validity expiration date/time.</summary>
        public DateTimeOffset? ExpirationDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("expirationDateTime"); }
            set { BackingStore?.Set("expirationDateTime", value); }
        }
        /// <summary>Supported values for the intended purpose of a user PFX certificate.</summary>
        public UserPfxIntendedPurpose? IntendedPurpose {
            get { return BackingStore?.Get<UserPfxIntendedPurpose?>("intendedPurpose"); }
            set { BackingStore?.Set("intendedPurpose", value); }
        }
        /// <summary>Name of the key (within the provider) used to encrypt the blob.</summary>
        public string KeyName {
            get { return BackingStore?.Get<string>("keyName"); }
            set { BackingStore?.Set("keyName", value); }
        }
        /// <summary>Date/time when this PFX certificate was last modified.</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>Supported values for the padding scheme used by encryption provider.</summary>
        public UserPfxPaddingScheme? PaddingScheme {
            get { return BackingStore?.Get<UserPfxPaddingScheme?>("paddingScheme"); }
            set { BackingStore?.Set("paddingScheme", value); }
        }
        /// <summary>Crypto provider used to encrypt this blob.</summary>
        public string ProviderName {
            get { return BackingStore?.Get<string>("providerName"); }
            set { BackingStore?.Set("providerName", value); }
        }
        /// <summary>Certificate&apos;s validity start date/time.</summary>
        public DateTimeOffset? StartDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("startDateTime"); }
            set { BackingStore?.Set("startDateTime", value); }
        }
        /// <summary>SHA-1 thumbprint of the PFX certificate.</summary>
        public string Thumbprint {
            get { return BackingStore?.Get<string>("thumbprint"); }
            set { BackingStore?.Set("thumbprint", value); }
        }
        /// <summary>User Principal Name of the PFX certificate.</summary>
        public string UserPrincipalName {
            get { return BackingStore?.Get<string>("userPrincipalName"); }
            set { BackingStore?.Set("userPrincipalName", value); }
        }
        /// <summary>
        /// Instantiates a new userPFXCertificate and sets the default values.
        /// </summary>
        public UserPFXCertificate() : base() {
            OdataType = "#microsoft.graph.userPFXCertificate";
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
