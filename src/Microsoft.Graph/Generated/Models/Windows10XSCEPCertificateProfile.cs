using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class Windows10XSCEPCertificateProfile : Windows10XCertificateProfile, IParsable {
        /// <summary>CertificateStore types</summary>
        public Microsoft.Graph.Beta.Models.CertificateStore? CertificateStore {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.CertificateStore?>("certificateStore"); }
            set { BackingStore?.Set("certificateStore", value); }
        }
        /// <summary>Certificate Validity Period Options.</summary>
        public Microsoft.Graph.Beta.Models.CertificateValidityPeriodScale? CertificateValidityPeriodScale {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.CertificateValidityPeriodScale?>("certificateValidityPeriodScale"); }
            set { BackingStore?.Set("certificateValidityPeriodScale", value); }
        }
        /// <summary>Value for the Certificate Validity Period</summary>
        public int? CertificateValidityPeriodValue {
            get { return BackingStore?.Get<int?>("certificateValidityPeriodValue"); }
            set { BackingStore?.Set("certificateValidityPeriodValue", value); }
        }
        /// <summary>Extended Key Usage (EKU) settings.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<ExtendedKeyUsage>? ExtendedKeyUsages {
            get { return BackingStore?.Get<List<ExtendedKeyUsage>?>("extendedKeyUsages"); }
            set { BackingStore?.Set("extendedKeyUsages", value); }
        }
#else
        public List<ExtendedKeyUsage> ExtendedKeyUsages {
            get { return BackingStore?.Get<List<ExtendedKeyUsage>>("extendedKeyUsages"); }
            set { BackingStore?.Set("extendedKeyUsages", value); }
        }
#endif
        /// <summary>SCEP Hash Algorithm.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<HashAlgorithms?>? HashAlgorithm {
            get { return BackingStore?.Get<List<HashAlgorithms?>?>("hashAlgorithm"); }
            set { BackingStore?.Set("hashAlgorithm", value); }
        }
#else
        public List<HashAlgorithms?> HashAlgorithm {
            get { return BackingStore?.Get<List<HashAlgorithms?>>("hashAlgorithm"); }
            set { BackingStore?.Set("hashAlgorithm", value); }
        }
#endif
        /// <summary>Key Size Options.</summary>
        public Microsoft.Graph.Beta.Models.KeySize? KeySize {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.KeySize?>("keySize"); }
            set { BackingStore?.Set("keySize", value); }
        }
        /// <summary>Key Storage Provider (KSP) Import Options.</summary>
        public KeyStorageProviderOption? KeyStorageProvider {
            get { return BackingStore?.Get<KeyStorageProviderOption?>("keyStorageProvider"); }
            set { BackingStore?.Set("keyStorageProvider", value); }
        }
        /// <summary>Key Usage Options.</summary>
        public KeyUsages? KeyUsage {
            get { return BackingStore?.Get<KeyUsages?>("keyUsage"); }
            set { BackingStore?.Set("keyUsage", value); }
        }
        /// <summary>Certificate renewal threshold percentage</summary>
        public int? RenewalThresholdPercentage {
            get { return BackingStore?.Get<int?>("renewalThresholdPercentage"); }
            set { BackingStore?.Set("renewalThresholdPercentage", value); }
        }
        /// <summary>Trusted Root Certificate ID</summary>
        public Guid? RootCertificateId {
            get { return BackingStore?.Get<Guid?>("rootCertificateId"); }
            set { BackingStore?.Set("rootCertificateId", value); }
        }
        /// <summary>SCEP Server Url(s).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<string>? ScepServerUrls {
            get { return BackingStore?.Get<List<string>?>("scepServerUrls"); }
            set { BackingStore?.Set("scepServerUrls", value); }
        }
#else
        public List<string> ScepServerUrls {
            get { return BackingStore?.Get<List<string>>("scepServerUrls"); }
            set { BackingStore?.Set("scepServerUrls", value); }
        }
#endif
        /// <summary>Custom AAD Attributes.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<Windows10XCustomSubjectAlternativeName>? SubjectAlternativeNameFormats {
            get { return BackingStore?.Get<List<Windows10XCustomSubjectAlternativeName>?>("subjectAlternativeNameFormats"); }
            set { BackingStore?.Set("subjectAlternativeNameFormats", value); }
        }
#else
        public List<Windows10XCustomSubjectAlternativeName> SubjectAlternativeNameFormats {
            get { return BackingStore?.Get<List<Windows10XCustomSubjectAlternativeName>>("subjectAlternativeNameFormats"); }
            set { BackingStore?.Set("subjectAlternativeNameFormats", value); }
        }
#endif
        /// <summary>Custom format to use with SubjectNameFormat = Custom. Example: CN={{EmailAddress}},E={{EmailAddress}},OU=Enterprise Users,O=Contoso Corporation,L=Redmond,ST=WA,C=US</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? SubjectNameFormatString {
            get { return BackingStore?.Get<string?>("subjectNameFormatString"); }
            set { BackingStore?.Set("subjectNameFormatString", value); }
        }
#else
        public string SubjectNameFormatString {
            get { return BackingStore?.Get<string>("subjectNameFormatString"); }
            set { BackingStore?.Set("subjectNameFormatString", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new Windows10XSCEPCertificateProfile and sets the default values.
        /// </summary>
        public Windows10XSCEPCertificateProfile() : base() {
            OdataType = "#microsoft.graph.windows10XSCEPCertificateProfile";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
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
                {"extendedKeyUsages", n => { ExtendedKeyUsages = n.GetCollectionOfObjectValues<ExtendedKeyUsage>(ExtendedKeyUsage.CreateFromDiscriminatorValue)?.ToList(); } },
                {"hashAlgorithm", n => { HashAlgorithm = n.GetCollectionOfEnumValues<HashAlgorithms>()?.ToList(); } },
                {"keySize", n => { KeySize = n.GetEnumValue<KeySize>(); } },
                {"keyStorageProvider", n => { KeyStorageProvider = n.GetEnumValue<KeyStorageProviderOption>(); } },
                {"keyUsage", n => { KeyUsage = n.GetEnumValue<KeyUsages>(); } },
                {"renewalThresholdPercentage", n => { RenewalThresholdPercentage = n.GetIntValue(); } },
                {"rootCertificateId", n => { RootCertificateId = n.GetGuidValue(); } },
                {"scepServerUrls", n => { ScepServerUrls = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"subjectAlternativeNameFormats", n => { SubjectAlternativeNameFormats = n.GetCollectionOfObjectValues<Windows10XCustomSubjectAlternativeName>(Windows10XCustomSubjectAlternativeName.CreateFromDiscriminatorValue)?.ToList(); } },
                {"subjectNameFormatString", n => { SubjectNameFormatString = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<CertificateStore>("certificateStore", CertificateStore);
            writer.WriteEnumValue<CertificateValidityPeriodScale>("certificateValidityPeriodScale", CertificateValidityPeriodScale);
            writer.WriteIntValue("certificateValidityPeriodValue", CertificateValidityPeriodValue);
            writer.WriteCollectionOfObjectValues<ExtendedKeyUsage>("extendedKeyUsages", ExtendedKeyUsages);
            writer.WriteCollectionOfEnumValues<HashAlgorithms>("hashAlgorithm", HashAlgorithm);
            writer.WriteEnumValue<KeySize>("keySize", KeySize);
            writer.WriteEnumValue<KeyStorageProviderOption>("keyStorageProvider", KeyStorageProvider);
            writer.WriteEnumValue<KeyUsages>("keyUsage", KeyUsage);
            writer.WriteIntValue("renewalThresholdPercentage", RenewalThresholdPercentage);
            writer.WriteGuidValue("rootCertificateId", RootCertificateId);
            writer.WriteCollectionOfPrimitiveValues<string>("scepServerUrls", ScepServerUrls);
            writer.WriteCollectionOfObjectValues<Windows10XCustomSubjectAlternativeName>("subjectAlternativeNameFormats", SubjectAlternativeNameFormats);
            writer.WriteStringValue("subjectNameFormatString", SubjectNameFormatString);
        }
    }
}
