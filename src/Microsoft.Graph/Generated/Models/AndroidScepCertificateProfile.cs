using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class AndroidScepCertificateProfile : AndroidCertificateProfileBase, IParsable {
        /// <summary>Hash Algorithm Options.</summary>
        public HashAlgorithms? HashAlgorithm {
            get { return BackingStore?.Get<HashAlgorithms?>("hashAlgorithm"); }
            set { BackingStore?.Set("hashAlgorithm", value); }
        }
        /// <summary>Key Size Options.</summary>
        public Microsoft.Graph.Beta.Models.KeySize? KeySize {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.KeySize?>("keySize"); }
            set { BackingStore?.Set("keySize", value); }
        }
        /// <summary>Key Usage Options.</summary>
        public KeyUsages? KeyUsage {
            get { return BackingStore?.Get<KeyUsages?>("keyUsage"); }
            set { BackingStore?.Set("keyUsage", value); }
        }
        /// <summary>Certificate state for devices. This collection can contain a maximum of 2147483647 elements.</summary>
        public List<ManagedDeviceCertificateState> ManagedDeviceCertificateStates {
            get { return BackingStore?.Get<List<ManagedDeviceCertificateState>>("managedDeviceCertificateStates"); }
            set { BackingStore?.Set("managedDeviceCertificateStates", value); }
        }
        /// <summary>SCEP Server Url(s)</summary>
        public List<string> ScepServerUrls {
            get { return BackingStore?.Get<List<string>>("scepServerUrls"); }
            set { BackingStore?.Set("scepServerUrls", value); }
        }
        /// <summary>Custom String that defines the AAD Attribute.</summary>
        public string SubjectAlternativeNameFormatString {
            get { return BackingStore?.Get<string>("subjectAlternativeNameFormatString"); }
            set { BackingStore?.Set("subjectAlternativeNameFormatString", value); }
        }
        /// <summary>Custom format to use with SubjectNameFormat = Custom. Example: CN={{EmailAddress}},E={{EmailAddress}},OU=Enterprise Users,O=Contoso Corporation,L=Redmond,ST=WA,C=US</summary>
        public string SubjectNameFormatString {
            get { return BackingStore?.Get<string>("subjectNameFormatString"); }
            set { BackingStore?.Set("subjectNameFormatString", value); }
        }
        /// <summary>
        /// Instantiates a new AndroidScepCertificateProfile and sets the default values.
        /// </summary>
        public AndroidScepCertificateProfile() : base() {
            OdataType = "#microsoft.graph.androidScepCertificateProfile";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new AndroidScepCertificateProfile CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AndroidScepCertificateProfile();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
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
