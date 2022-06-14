using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class AndroidWorkProfileScepCertificateProfile : AndroidWorkProfileCertificateProfileBase, IParsable {
        /// <summary>Target store certificate. Possible values are: user, machine.</summary>
        public Microsoft.Graph.Beta.Models.CertificateStore? CertificateStore {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.CertificateStore?>(nameof(CertificateStore)); }
            set { BackingStore?.Set(nameof(CertificateStore), value); }
        }
        /// <summary>Custom Subject Alternative Name Settings. This collection can contain a maximum of 500 elements.</summary>
        public List<CustomSubjectAlternativeName> CustomSubjectAlternativeNames {
            get { return BackingStore?.Get<List<CustomSubjectAlternativeName>>(nameof(CustomSubjectAlternativeNames)); }
            set { BackingStore?.Set(nameof(CustomSubjectAlternativeNames), value); }
        }
        /// <summary>SCEP Hash Algorithm. Possible values are: sha1, sha2.</summary>
        public HashAlgorithms? HashAlgorithm {
            get { return BackingStore?.Get<HashAlgorithms?>(nameof(HashAlgorithm)); }
            set { BackingStore?.Set(nameof(HashAlgorithm), value); }
        }
        /// <summary>SCEP Key Size. Possible values are: size1024, size2048, size4096.</summary>
        public Microsoft.Graph.Beta.Models.KeySize? KeySize {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.KeySize?>(nameof(KeySize)); }
            set { BackingStore?.Set(nameof(KeySize), value); }
        }
        /// <summary>SCEP Key Usage. Possible values are: keyEncipherment, digitalSignature.</summary>
        public KeyUsages? KeyUsage {
            get { return BackingStore?.Get<KeyUsages?>(nameof(KeyUsage)); }
            set { BackingStore?.Set(nameof(KeyUsage), value); }
        }
        /// <summary>Certificate state for devices. This collection can contain a maximum of 2147483647 elements.</summary>
        public List<ManagedDeviceCertificateState> ManagedDeviceCertificateStates {
            get { return BackingStore?.Get<List<ManagedDeviceCertificateState>>(nameof(ManagedDeviceCertificateStates)); }
            set { BackingStore?.Set(nameof(ManagedDeviceCertificateStates), value); }
        }
        /// <summary>SCEP Server Url(s)</summary>
        public List<string> ScepServerUrls {
            get { return BackingStore?.Get<List<string>>(nameof(ScepServerUrls)); }
            set { BackingStore?.Set(nameof(ScepServerUrls), value); }
        }
        /// <summary>Custom String that defines the AAD Attribute.</summary>
        public string SubjectAlternativeNameFormatString {
            get { return BackingStore?.Get<string>(nameof(SubjectAlternativeNameFormatString)); }
            set { BackingStore?.Set(nameof(SubjectAlternativeNameFormatString), value); }
        }
        /// <summary>Custom format to use with SubjectNameFormat = Custom. Example: CN={{EmailAddress}},E={{EmailAddress}},OU=Enterprise Users,O=Contoso Corporation,L=Redmond,ST=WA,C=US</summary>
        public string SubjectNameFormatString {
            get { return BackingStore?.Get<string>(nameof(SubjectNameFormatString)); }
            set { BackingStore?.Set(nameof(SubjectNameFormatString), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new AndroidWorkProfileScepCertificateProfile CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AndroidWorkProfileScepCertificateProfile();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"certificateStore", n => { CertificateStore = n.GetEnumValue<CertificateStore>(); } },
                {"customSubjectAlternativeNames", n => { CustomSubjectAlternativeNames = n.GetCollectionOfObjectValues<CustomSubjectAlternativeName>(CustomSubjectAlternativeName.CreateFromDiscriminatorValue).ToList(); } },
                {"hashAlgorithm", n => { HashAlgorithm = n.GetEnumValue<HashAlgorithms>(); } },
                {"keySize", n => { KeySize = n.GetEnumValue<KeySize>(); } },
                {"keyUsage", n => { KeyUsage = n.GetEnumValue<KeyUsages>(); } },
                {"managedDeviceCertificateStates", n => { ManagedDeviceCertificateStates = n.GetCollectionOfObjectValues<ManagedDeviceCertificateState>(ManagedDeviceCertificateState.CreateFromDiscriminatorValue).ToList(); } },
                {"scepServerUrls", n => { ScepServerUrls = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"subjectAlternativeNameFormatString", n => { SubjectAlternativeNameFormatString = n.GetStringValue(); } },
                {"subjectNameFormatString", n => { SubjectNameFormatString = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<CertificateStore>("certificateStore", CertificateStore);
            writer.WriteCollectionOfObjectValues<CustomSubjectAlternativeName>("customSubjectAlternativeNames", CustomSubjectAlternativeNames);
            writer.WriteEnumValue<HashAlgorithms>("hashAlgorithm", HashAlgorithm);
            writer.WriteEnumValue<KeySize>("keySize", KeySize);
            writer.WriteEnumValue<KeyUsages>("keyUsage", KeyUsage);
            writer.WriteCollectionOfObjectValues<ManagedDeviceCertificateState>("managedDeviceCertificateStates", ManagedDeviceCertificateStates);
            writer.WriteCollectionOfPrimitiveValues<string>("scepServerUrls", ScepServerUrls);
            writer.WriteStringValue("subjectAlternativeNameFormatString", SubjectAlternativeNameFormatString);
            writer.WriteStringValue("subjectNameFormatString", SubjectNameFormatString);
        }
    }
}
