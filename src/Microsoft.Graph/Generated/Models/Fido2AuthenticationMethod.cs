using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the compliance singleton.</summary>
    public class Fido2AuthenticationMethod : AuthenticationMethod, IParsable {
        /// <summary>Authenticator Attestation GUID, an identifier that indicates the type (e.g. make and model) of the authenticator.</summary>
        public string AaGuid {
            get { return BackingStore?.Get<string>(nameof(AaGuid)); }
            set { BackingStore?.Set(nameof(AaGuid), value); }
        }
        /// <summary>The attestation certificate(s) attached to this security key.</summary>
        public List<string> AttestationCertificates {
            get { return BackingStore?.Get<List<string>>(nameof(AttestationCertificates)); }
            set { BackingStore?.Set(nameof(AttestationCertificates), value); }
        }
        /// <summary>The attestation level of this FIDO2 security key. Possible values are: attested, notAttested, unknownFutureValue.</summary>
        public Microsoft.Graph.Beta.Models.AttestationLevel? AttestationLevel {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.AttestationLevel?>(nameof(AttestationLevel)); }
            set { BackingStore?.Set(nameof(AttestationLevel), value); }
        }
        /// <summary>The timestamp when this key was registered to the user.</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(CreatedDateTime)); }
            set { BackingStore?.Set(nameof(CreatedDateTime), value); }
        }
        /// <summary>The creationDateTime property</summary>
        public DateTimeOffset? CreationDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(CreationDateTime)); }
            set { BackingStore?.Set(nameof(CreationDateTime), value); }
        }
        /// <summary>The display name of the key as given by the user.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>(nameof(DisplayName)); }
            set { BackingStore?.Set(nameof(DisplayName), value); }
        }
        /// <summary>The manufacturer-assigned model of the FIDO2 security key.</summary>
        public string Model {
            get { return BackingStore?.Get<string>(nameof(Model)); }
            set { BackingStore?.Set(nameof(Model), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Fido2AuthenticationMethod CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Fido2AuthenticationMethod();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"aaGuid", n => { AaGuid = n.GetStringValue(); } },
                {"attestationCertificates", n => { AttestationCertificates = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"attestationLevel", n => { AttestationLevel = n.GetEnumValue<AttestationLevel>(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"creationDateTime", n => { CreationDateTime = n.GetDateTimeOffsetValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"model", n => { Model = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("aaGuid", AaGuid);
            writer.WriteCollectionOfPrimitiveValues<string>("attestationCertificates", AttestationCertificates);
            writer.WriteEnumValue<AttestationLevel>("attestationLevel", AttestationLevel);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteDateTimeOffsetValue("creationDateTime", CreationDateTime);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("model", Model);
        }
    }
}
