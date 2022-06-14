using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class Windows10XSCEPCertificateProfile : Windows10XCertificateProfile, IParsable {
        /// <summary>Target store certificate. Possible values are: user, machine.</summary>
        public Microsoft.Graph.Beta.Models.CertificateStore? CertificateStore {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.CertificateStore?>(nameof(CertificateStore)); }
            set { BackingStore?.Set(nameof(CertificateStore), value); }
        }
        /// <summary>Scale for the Certificate Validity Period. Possible values are: days, months, years.</summary>
        public Microsoft.Graph.Beta.Models.CertificateValidityPeriodScale? CertificateValidityPeriodScale {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.CertificateValidityPeriodScale?>(nameof(CertificateValidityPeriodScale)); }
            set { BackingStore?.Set(nameof(CertificateValidityPeriodScale), value); }
        }
        /// <summary>Value for the Certificate Validity Period</summary>
        public int? CertificateValidityPeriodValue {
            get { return BackingStore?.Get<int?>(nameof(CertificateValidityPeriodValue)); }
            set { BackingStore?.Set(nameof(CertificateValidityPeriodValue), value); }
        }
        /// <summary>Extended Key Usage (EKU) settings.</summary>
        public List<ExtendedKeyUsage> ExtendedKeyUsages {
            get { return BackingStore?.Get<List<ExtendedKeyUsage>>(nameof(ExtendedKeyUsages)); }
            set { BackingStore?.Set(nameof(ExtendedKeyUsages), value); }
        }
        /// <summary>SCEP Hash Algorithm.</summary>
        public List<string> HashAlgorithm {
            get { return BackingStore?.Get<List<string>>(nameof(HashAlgorithm)); }
            set { BackingStore?.Set(nameof(HashAlgorithm), value); }
        }
        /// <summary>SCEP Key Size. Possible values are: size1024, size2048, size4096.</summary>
        public Microsoft.Graph.Beta.Models.KeySize? KeySize {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.KeySize?>(nameof(KeySize)); }
            set { BackingStore?.Set(nameof(KeySize), value); }
        }
        /// <summary>Key Storage Provider (KSP). Possible values are: useTpmKspOtherwiseUseSoftwareKsp, useTpmKspOtherwiseFail, usePassportForWorkKspOtherwiseFail, useSoftwareKsp.</summary>
        public KeyStorageProviderOption? KeyStorageProvider {
            get { return BackingStore?.Get<KeyStorageProviderOption?>(nameof(KeyStorageProvider)); }
            set { BackingStore?.Set(nameof(KeyStorageProvider), value); }
        }
        /// <summary>SCEP Key Usage. Possible values are: keyEncipherment, digitalSignature.</summary>
        public KeyUsages? KeyUsage {
            get { return BackingStore?.Get<KeyUsages?>(nameof(KeyUsage)); }
            set { BackingStore?.Set(nameof(KeyUsage), value); }
        }
        /// <summary>Certificate renewal threshold percentage</summary>
        public int? RenewalThresholdPercentage {
            get { return BackingStore?.Get<int?>(nameof(RenewalThresholdPercentage)); }
            set { BackingStore?.Set(nameof(RenewalThresholdPercentage), value); }
        }
        /// <summary>Trusted Root Certificate ID</summary>
        public string RootCertificateId {
            get { return BackingStore?.Get<string>(nameof(RootCertificateId)); }
            set { BackingStore?.Set(nameof(RootCertificateId), value); }
        }
        /// <summary>SCEP Server Url(s).</summary>
        public List<string> ScepServerUrls {
            get { return BackingStore?.Get<List<string>>(nameof(ScepServerUrls)); }
            set { BackingStore?.Set(nameof(ScepServerUrls), value); }
        }
        /// <summary>Custom AAD Attributes.</summary>
        public List<Windows10XCustomSubjectAlternativeName> SubjectAlternativeNameFormats {
            get { return BackingStore?.Get<List<Windows10XCustomSubjectAlternativeName>>(nameof(SubjectAlternativeNameFormats)); }
            set { BackingStore?.Set(nameof(SubjectAlternativeNameFormats), value); }
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
        public static new Windows10XSCEPCertificateProfile CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Windows10XSCEPCertificateProfile();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"certificateStore", n => { CertificateStore = n.GetEnumValue<CertificateStore>(); } },
                {"certificateValidityPeriodScale", n => { CertificateValidityPeriodScale = n.GetEnumValue<CertificateValidityPeriodScale>(); } },
                {"certificateValidityPeriodValue", n => { CertificateValidityPeriodValue = n.GetIntValue(); } },
                {"extendedKeyUsages", n => { ExtendedKeyUsages = n.GetCollectionOfObjectValues<ExtendedKeyUsage>(ExtendedKeyUsage.CreateFromDiscriminatorValue).ToList(); } },
                {"hashAlgorithm", n => { HashAlgorithm = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"keySize", n => { KeySize = n.GetEnumValue<KeySize>(); } },
                {"keyStorageProvider", n => { KeyStorageProvider = n.GetEnumValue<KeyStorageProviderOption>(); } },
                {"keyUsage", n => { KeyUsage = n.GetEnumValue<KeyUsages>(); } },
                {"renewalThresholdPercentage", n => { RenewalThresholdPercentage = n.GetIntValue(); } },
                {"rootCertificateId", n => { RootCertificateId = n.GetStringValue(); } },
                {"scepServerUrls", n => { ScepServerUrls = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"subjectAlternativeNameFormats", n => { SubjectAlternativeNameFormats = n.GetCollectionOfObjectValues<Windows10XCustomSubjectAlternativeName>(Windows10XCustomSubjectAlternativeName.CreateFromDiscriminatorValue).ToList(); } },
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
            writer.WriteEnumValue<CertificateValidityPeriodScale>("certificateValidityPeriodScale", CertificateValidityPeriodScale);
            writer.WriteIntValue("certificateValidityPeriodValue", CertificateValidityPeriodValue);
            writer.WriteCollectionOfObjectValues<ExtendedKeyUsage>("extendedKeyUsages", ExtendedKeyUsages);
            writer.WriteCollectionOfPrimitiveValues<string>("hashAlgorithm", HashAlgorithm);
            writer.WriteEnumValue<KeySize>("keySize", KeySize);
            writer.WriteEnumValue<KeyStorageProviderOption>("keyStorageProvider", KeyStorageProvider);
            writer.WriteEnumValue<KeyUsages>("keyUsage", KeyUsage);
            writer.WriteIntValue("renewalThresholdPercentage", RenewalThresholdPercentage);
            writer.WriteStringValue("rootCertificateId", RootCertificateId);
            writer.WriteCollectionOfPrimitiveValues<string>("scepServerUrls", ScepServerUrls);
            writer.WriteCollectionOfObjectValues<Windows10XCustomSubjectAlternativeName>("subjectAlternativeNameFormats", SubjectAlternativeNameFormats);
            writer.WriteStringValue("subjectNameFormatString", SubjectNameFormatString);
        }
    }
}
