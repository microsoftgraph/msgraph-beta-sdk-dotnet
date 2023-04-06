using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class AndroidDeviceOwnerScepCertificateProfile : AndroidDeviceOwnerCertificateProfileBase, IParsable {
        /// <summary>Certificate access type. Possible values are: userApproval, specificApps, unknownFutureValue.</summary>
        public AndroidDeviceOwnerCertificateAccessType? CertificateAccessType {
            get { return BackingStore?.Get<AndroidDeviceOwnerCertificateAccessType?>("certificateAccessType"); }
            set { BackingStore?.Set("certificateAccessType", value); }
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
        /// <summary>SCEP Server Url(s)</summary>
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
        /// <summary>Certificate access information. This collection can contain a maximum of 50 elements.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AndroidDeviceOwnerSilentCertificateAccess>? SilentCertificateAccessDetails {
            get { return BackingStore?.Get<List<AndroidDeviceOwnerSilentCertificateAccess>?>("silentCertificateAccessDetails"); }
            set { BackingStore?.Set("silentCertificateAccessDetails", value); }
        }
#nullable restore
#else
        public List<AndroidDeviceOwnerSilentCertificateAccess> SilentCertificateAccessDetails {
            get { return BackingStore?.Get<List<AndroidDeviceOwnerSilentCertificateAccess>>("silentCertificateAccessDetails"); }
            set { BackingStore?.Set("silentCertificateAccessDetails", value); }
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
        /// Instantiates a new AndroidDeviceOwnerScepCertificateProfile and sets the default values.
        /// </summary>
        public AndroidDeviceOwnerScepCertificateProfile() : base() {
            OdataType = "#microsoft.graph.androidDeviceOwnerScepCertificateProfile";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new AndroidDeviceOwnerScepCertificateProfile CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AndroidDeviceOwnerScepCertificateProfile();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"certificateAccessType", n => { CertificateAccessType = n.GetEnumValue<AndroidDeviceOwnerCertificateAccessType>(); } },
                {"certificateStore", n => { CertificateStore = n.GetEnumValue<CertificateStore>(); } },
                {"customSubjectAlternativeNames", n => { CustomSubjectAlternativeNames = n.GetCollectionOfObjectValues<CustomSubjectAlternativeName>(CustomSubjectAlternativeName.CreateFromDiscriminatorValue)?.ToList(); } },
                {"hashAlgorithm", n => { HashAlgorithm = n.GetEnumValue<HashAlgorithms>(); } },
                {"keySize", n => { KeySize = n.GetEnumValue<KeySize>(); } },
                {"keyUsage", n => { KeyUsage = n.GetEnumValue<KeyUsages>(); } },
                {"managedDeviceCertificateStates", n => { ManagedDeviceCertificateStates = n.GetCollectionOfObjectValues<ManagedDeviceCertificateState>(ManagedDeviceCertificateState.CreateFromDiscriminatorValue)?.ToList(); } },
                {"scepServerUrls", n => { ScepServerUrls = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"silentCertificateAccessDetails", n => { SilentCertificateAccessDetails = n.GetCollectionOfObjectValues<AndroidDeviceOwnerSilentCertificateAccess>(AndroidDeviceOwnerSilentCertificateAccess.CreateFromDiscriminatorValue)?.ToList(); } },
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
            writer.WriteEnumValue<AndroidDeviceOwnerCertificateAccessType>("certificateAccessType", CertificateAccessType);
            writer.WriteEnumValue<CertificateStore>("certificateStore", CertificateStore);
            writer.WriteCollectionOfObjectValues<CustomSubjectAlternativeName>("customSubjectAlternativeNames", CustomSubjectAlternativeNames);
            writer.WriteEnumValue<HashAlgorithms>("hashAlgorithm", HashAlgorithm);
            writer.WriteEnumValue<KeySize>("keySize", KeySize);
            writer.WriteEnumValue<KeyUsages>("keyUsage", KeyUsage);
            writer.WriteCollectionOfObjectValues<ManagedDeviceCertificateState>("managedDeviceCertificateStates", ManagedDeviceCertificateStates);
            writer.WriteCollectionOfPrimitiveValues<string>("scepServerUrls", ScepServerUrls);
            writer.WriteCollectionOfObjectValues<AndroidDeviceOwnerSilentCertificateAccess>("silentCertificateAccessDetails", SilentCertificateAccessDetails);
            writer.WriteStringValue("subjectAlternativeNameFormatString", SubjectAlternativeNameFormatString);
            writer.WriteStringValue("subjectNameFormatString", SubjectNameFormatString);
        }
    }
}
