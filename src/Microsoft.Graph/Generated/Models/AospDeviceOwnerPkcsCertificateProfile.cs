using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class AospDeviceOwnerPkcsCertificateProfile : AospDeviceOwnerCertificateProfileBase, IParsable {
        /// <summary>Target store certificate. Possible values are: user, machine.</summary>
        public Microsoft.Graph.Beta.Models.CertificateStore? CertificateStore {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.CertificateStore?>(nameof(CertificateStore)); }
            set { BackingStore?.Set(nameof(CertificateStore), value); }
        }
        /// <summary>PKCS Certificate Template Name</summary>
        public string CertificateTemplateName {
            get { return BackingStore?.Get<string>(nameof(CertificateTemplateName)); }
            set { BackingStore?.Set(nameof(CertificateTemplateName), value); }
        }
        /// <summary>PKCS Certification Authority</summary>
        public string CertificationAuthority {
            get { return BackingStore?.Get<string>(nameof(CertificationAuthority)); }
            set { BackingStore?.Set(nameof(CertificationAuthority), value); }
        }
        /// <summary>PKCS Certification Authority Name</summary>
        public string CertificationAuthorityName {
            get { return BackingStore?.Get<string>(nameof(CertificationAuthorityName)); }
            set { BackingStore?.Set(nameof(CertificationAuthorityName), value); }
        }
        /// <summary>Certification authority type. Possible values are: notConfigured, microsoft, digiCert.</summary>
        public DeviceManagementCertificationAuthority? CertificationAuthorityType {
            get { return BackingStore?.Get<DeviceManagementCertificationAuthority?>(nameof(CertificationAuthorityType)); }
            set { BackingStore?.Set(nameof(CertificationAuthorityType), value); }
        }
        /// <summary>Custom Subject Alternative Name Settings. This collection can contain a maximum of 500 elements.</summary>
        public List<CustomSubjectAlternativeName> CustomSubjectAlternativeNames {
            get { return BackingStore?.Get<List<CustomSubjectAlternativeName>>(nameof(CustomSubjectAlternativeNames)); }
            set { BackingStore?.Set(nameof(CustomSubjectAlternativeNames), value); }
        }
        /// <summary>Certificate state for devices. This collection can contain a maximum of 2147483647 elements.</summary>
        public List<ManagedDeviceCertificateState> ManagedDeviceCertificateStates {
            get { return BackingStore?.Get<List<ManagedDeviceCertificateState>>(nameof(ManagedDeviceCertificateStates)); }
            set { BackingStore?.Set(nameof(ManagedDeviceCertificateStates), value); }
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
                {"customSubjectAlternativeNames", n => { CustomSubjectAlternativeNames = n.GetCollectionOfObjectValues<CustomSubjectAlternativeName>(CustomSubjectAlternativeName.CreateFromDiscriminatorValue).ToList(); } },
                {"managedDeviceCertificateStates", n => { ManagedDeviceCertificateStates = n.GetCollectionOfObjectValues<ManagedDeviceCertificateState>(ManagedDeviceCertificateState.CreateFromDiscriminatorValue).ToList(); } },
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
