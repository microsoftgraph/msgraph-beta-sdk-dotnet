using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// AOSP Device Owner PKCS certificate profile
    /// </summary>
    public class AospDeviceOwnerPkcsCertificateProfile : AospDeviceOwnerCertificateProfileBase, IParsable {
        /// <summary>CertificateStore types</summary>
        public Microsoft.Graph.Beta.Models.CertificateStore? CertificateStore {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.CertificateStore?>("certificateStore"); }
            set { BackingStore?.Set("certificateStore", value); }
        }
        /// <summary>PKCS Certificate Template Name</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CertificateTemplateName {
            get { return BackingStore?.Get<string?>("certificateTemplateName"); }
            set { BackingStore?.Set("certificateTemplateName", value); }
        }
#nullable restore
#else
        public string CertificateTemplateName {
            get { return BackingStore?.Get<string>("certificateTemplateName"); }
            set { BackingStore?.Set("certificateTemplateName", value); }
        }
#endif
        /// <summary>PKCS Certification Authority</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CertificationAuthority {
            get { return BackingStore?.Get<string?>("certificationAuthority"); }
            set { BackingStore?.Set("certificationAuthority", value); }
        }
#nullable restore
#else
        public string CertificationAuthority {
            get { return BackingStore?.Get<string>("certificationAuthority"); }
            set { BackingStore?.Set("certificationAuthority", value); }
        }
#endif
        /// <summary>PKCS Certification Authority Name</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CertificationAuthorityName {
            get { return BackingStore?.Get<string?>("certificationAuthorityName"); }
            set { BackingStore?.Set("certificationAuthorityName", value); }
        }
#nullable restore
#else
        public string CertificationAuthorityName {
            get { return BackingStore?.Get<string>("certificationAuthorityName"); }
            set { BackingStore?.Set("certificationAuthorityName", value); }
        }
#endif
        /// <summary>Device Management Certification Authority Types.</summary>
        public DeviceManagementCertificationAuthority? CertificationAuthorityType {
            get { return BackingStore?.Get<DeviceManagementCertificationAuthority?>("certificationAuthorityType"); }
            set { BackingStore?.Set("certificationAuthorityType", value); }
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
        /// Instantiates a new aospDeviceOwnerPkcsCertificateProfile and sets the default values.
        /// </summary>
        public AospDeviceOwnerPkcsCertificateProfile() : base() {
            OdataType = "#microsoft.graph.aospDeviceOwnerPkcsCertificateProfile";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new AospDeviceOwnerPkcsCertificateProfile CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AospDeviceOwnerPkcsCertificateProfile();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"certificateStore", n => { CertificateStore = n.GetEnumValue<CertificateStore>(); } },
                {"certificateTemplateName", n => { CertificateTemplateName = n.GetStringValue(); } },
                {"certificationAuthority", n => { CertificationAuthority = n.GetStringValue(); } },
                {"certificationAuthorityName", n => { CertificationAuthorityName = n.GetStringValue(); } },
                {"certificationAuthorityType", n => { CertificationAuthorityType = n.GetEnumValue<DeviceManagementCertificationAuthority>(); } },
                {"customSubjectAlternativeNames", n => { CustomSubjectAlternativeNames = n.GetCollectionOfObjectValues<CustomSubjectAlternativeName>(CustomSubjectAlternativeName.CreateFromDiscriminatorValue)?.ToList(); } },
                {"managedDeviceCertificateStates", n => { ManagedDeviceCertificateStates = n.GetCollectionOfObjectValues<ManagedDeviceCertificateState>(ManagedDeviceCertificateState.CreateFromDiscriminatorValue)?.ToList(); } },
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
            writer.WriteEnumValue<CertificateStore>("certificateStore", CertificateStore);
            writer.WriteStringValue("certificateTemplateName", CertificateTemplateName);
            writer.WriteStringValue("certificationAuthority", CertificationAuthority);
            writer.WriteStringValue("certificationAuthorityName", CertificationAuthorityName);
            writer.WriteEnumValue<DeviceManagementCertificationAuthority>("certificationAuthorityType", CertificationAuthorityType);
            writer.WriteCollectionOfObjectValues<CustomSubjectAlternativeName>("customSubjectAlternativeNames", CustomSubjectAlternativeNames);
            writer.WriteCollectionOfObjectValues<ManagedDeviceCertificateState>("managedDeviceCertificateStates", ManagedDeviceCertificateStates);
            writer.WriteStringValue("subjectAlternativeNameFormatString", SubjectAlternativeNameFormatString);
            writer.WriteStringValue("subjectNameFormatString", SubjectNameFormatString);
        }
    }
}
