using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class MacOSScepCertificateProfile : MacOSCertificateProfileBase, IParsable {
        /// <summary>AllowAllAppsAccess setting</summary>
        public bool? AllowAllAppsAccess {
            get { return BackingStore?.Get<bool?>("allowAllAppsAccess"); }
            set { BackingStore?.Set("allowAllAppsAccess", value); }
        }
        /// <summary>Target store certificate. Possible values are: user, machine.</summary>
        public Microsoft.Graph.Beta.Models.CertificateStore? CertificateStore {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.CertificateStore?>("certificateStore"); }
            set { BackingStore?.Set("certificateStore", value); }
        }
        /// <summary>Custom Subject Alternative Name Settings. This collection can contain a maximum of 500 elements.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<CustomSubjectAlternativeName>? CustomSubjectAlternativeNames {
            get { return BackingStore?.Get<List<CustomSubjectAlternativeName>?>("customSubjectAlternativeNames"); }
            set { BackingStore?.Set("customSubjectAlternativeNames", value); }
        }
#nullable restore
#else
        public List<CustomSubjectAlternativeName> CustomSubjectAlternativeNames {
            get { return BackingStore?.Get<List<CustomSubjectAlternativeName>>("customSubjectAlternativeNames"); }
            set { BackingStore?.Set("customSubjectAlternativeNames", value); }
        }
#endif
        /// <summary>Extended Key Usage (EKU) settings. This collection can contain a maximum of 500 elements.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ExtendedKeyUsage>? ExtendedKeyUsages {
            get { return BackingStore?.Get<List<ExtendedKeyUsage>?>("extendedKeyUsages"); }
            set { BackingStore?.Set("extendedKeyUsages", value); }
        }
#nullable restore
#else
        public List<ExtendedKeyUsage> ExtendedKeyUsages {
            get { return BackingStore?.Get<List<ExtendedKeyUsage>>("extendedKeyUsages"); }
            set { BackingStore?.Set("extendedKeyUsages", value); }
        }
#endif
        /// <summary>SCEP Hash Algorithm. Possible values are: sha1, sha2.</summary>
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
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ManagedDeviceCertificateState>? ManagedDeviceCertificateStates {
            get { return BackingStore?.Get<List<ManagedDeviceCertificateState>?>("managedDeviceCertificateStates"); }
            set { BackingStore?.Set("managedDeviceCertificateStates", value); }
        }
#nullable restore
#else
        public List<ManagedDeviceCertificateState> ManagedDeviceCertificateStates {
            get { return BackingStore?.Get<List<ManagedDeviceCertificateState>>("managedDeviceCertificateStates"); }
            set { BackingStore?.Set("managedDeviceCertificateStates", value); }
        }
#endif
        /// <summary>Trusted Root Certificate.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public MacOSTrustedRootCertificate? RootCertificate {
            get { return BackingStore?.Get<MacOSTrustedRootCertificate?>("rootCertificate"); }
            set { BackingStore?.Set("rootCertificate", value); }
        }
#nullable restore
#else
        public MacOSTrustedRootCertificate RootCertificate {
            get { return BackingStore?.Get<MacOSTrustedRootCertificate>("rootCertificate"); }
            set { BackingStore?.Set("rootCertificate", value); }
        }
#endif
        /// <summary>SCEP Server Url(s).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? ScepServerUrls {
            get { return BackingStore?.Get<List<string>?>("scepServerUrls"); }
            set { BackingStore?.Set("scepServerUrls", value); }
        }
#nullable restore
#else
        public List<string> ScepServerUrls {
            get { return BackingStore?.Get<List<string>>("scepServerUrls"); }
            set { BackingStore?.Set("scepServerUrls", value); }
        }
#endif
        /// <summary>Custom String that defines the AAD Attribute.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SubjectAlternativeNameFormatString {
            get { return BackingStore?.Get<string?>("subjectAlternativeNameFormatString"); }
            set { BackingStore?.Set("subjectAlternativeNameFormatString", value); }
        }
#nullable restore
#else
        public string SubjectAlternativeNameFormatString {
            get { return BackingStore?.Get<string>("subjectAlternativeNameFormatString"); }
            set { BackingStore?.Set("subjectAlternativeNameFormatString", value); }
        }
#endif
        /// <summary>Custom format to use with SubjectNameFormat = Custom. Example: CN={{EmailAddress}},E={{EmailAddress}},OU=Enterprise Users,O=Contoso Corporation,L=Redmond,ST=WA,C=US</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SubjectNameFormatString {
            get { return BackingStore?.Get<string?>("subjectNameFormatString"); }
            set { BackingStore?.Set("subjectNameFormatString", value); }
        }
#nullable restore
#else
        public string SubjectNameFormatString {
            get { return BackingStore?.Get<string>("subjectNameFormatString"); }
            set { BackingStore?.Set("subjectNameFormatString", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new MacOSScepCertificateProfile and sets the default values.
        /// </summary>
        public MacOSScepCertificateProfile() : base() {
            OdataType = "#microsoft.graph.macOSScepCertificateProfile";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new MacOSScepCertificateProfile CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MacOSScepCertificateProfile();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"allowAllAppsAccess", n => { AllowAllAppsAccess = n.GetBoolValue(); } },
                {"certificateStore", n => { CertificateStore = n.GetEnumValue<CertificateStore>(); } },
                {"customSubjectAlternativeNames", n => { CustomSubjectAlternativeNames = n.GetCollectionOfObjectValues<CustomSubjectAlternativeName>(CustomSubjectAlternativeName.CreateFromDiscriminatorValue)?.ToList(); } },
                {"extendedKeyUsages", n => { ExtendedKeyUsages = n.GetCollectionOfObjectValues<ExtendedKeyUsage>(ExtendedKeyUsage.CreateFromDiscriminatorValue)?.ToList(); } },
                {"hashAlgorithm", n => { HashAlgorithm = n.GetEnumValue<HashAlgorithms>(); } },
                {"keySize", n => { KeySize = n.GetEnumValue<KeySize>(); } },
                {"keyUsage", n => { KeyUsage = n.GetEnumValue<KeyUsages>(); } },
                {"managedDeviceCertificateStates", n => { ManagedDeviceCertificateStates = n.GetCollectionOfObjectValues<ManagedDeviceCertificateState>(ManagedDeviceCertificateState.CreateFromDiscriminatorValue)?.ToList(); } },
                {"rootCertificate", n => { RootCertificate = n.GetObjectValue<MacOSTrustedRootCertificate>(MacOSTrustedRootCertificate.CreateFromDiscriminatorValue); } },
                {"scepServerUrls", n => { ScepServerUrls = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"subjectAlternativeNameFormatString", n => { SubjectAlternativeNameFormatString = n.GetStringValue(); } },
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
            writer.WriteBoolValue("allowAllAppsAccess", AllowAllAppsAccess);
            writer.WriteEnumValue<CertificateStore>("certificateStore", CertificateStore);
            writer.WriteCollectionOfObjectValues<CustomSubjectAlternativeName>("customSubjectAlternativeNames", CustomSubjectAlternativeNames);
            writer.WriteCollectionOfObjectValues<ExtendedKeyUsage>("extendedKeyUsages", ExtendedKeyUsages);
            writer.WriteEnumValue<HashAlgorithms>("hashAlgorithm", HashAlgorithm);
            writer.WriteEnumValue<KeySize>("keySize", KeySize);
            writer.WriteEnumValue<KeyUsages>("keyUsage", KeyUsage);
            writer.WriteCollectionOfObjectValues<ManagedDeviceCertificateState>("managedDeviceCertificateStates", ManagedDeviceCertificateStates);
            writer.WriteObjectValue<MacOSTrustedRootCertificate>("rootCertificate", RootCertificate);
            writer.WriteCollectionOfPrimitiveValues<string>("scepServerUrls", ScepServerUrls);
            writer.WriteStringValue("subjectAlternativeNameFormatString", SubjectAlternativeNameFormatString);
            writer.WriteStringValue("subjectNameFormatString", SubjectNameFormatString);
        }
    }
}
