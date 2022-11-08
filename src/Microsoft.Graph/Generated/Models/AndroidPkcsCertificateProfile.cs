using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class AndroidPkcsCertificateProfile : AndroidCertificateProfileBase, IParsable {
        /// <summary>PKCS Certificate Template Name</summary>
        public string CertificateTemplateName {
            get { return BackingStore?.Get<string>("certificateTemplateName"); }
            set { BackingStore?.Set("certificateTemplateName", value); }
        }
        /// <summary>PKCS Certification Authority</summary>
        public string CertificationAuthority {
            get { return BackingStore?.Get<string>("certificationAuthority"); }
            set { BackingStore?.Set("certificationAuthority", value); }
        }
        /// <summary>PKCS Certification Authority Name</summary>
        public string CertificationAuthorityName {
            get { return BackingStore?.Get<string>("certificationAuthorityName"); }
            set { BackingStore?.Set("certificationAuthorityName", value); }
        }
        /// <summary>Certificate state for devices. This collection can contain a maximum of 2147483647 elements.</summary>
        public List<ManagedDeviceCertificateState> ManagedDeviceCertificateStates {
            get { return BackingStore?.Get<List<ManagedDeviceCertificateState>>("managedDeviceCertificateStates"); }
            set { BackingStore?.Set("managedDeviceCertificateStates", value); }
        }
        /// <summary>Custom String that defines the AAD Attribute.</summary>
        public string SubjectAlternativeNameFormatString {
            get { return BackingStore?.Get<string>("subjectAlternativeNameFormatString"); }
            set { BackingStore?.Set("subjectAlternativeNameFormatString", value); }
        }
        /// <summary>
        /// Instantiates a new AndroidPkcsCertificateProfile and sets the default values.
        /// </summary>
        public AndroidPkcsCertificateProfile() : base() {
            OdataType = "#microsoft.graph.androidPkcsCertificateProfile";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new AndroidPkcsCertificateProfile CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AndroidPkcsCertificateProfile();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"certificateTemplateName", n => { CertificateTemplateName = n.GetStringValue(); } },
                {"certificationAuthority", n => { CertificationAuthority = n.GetStringValue(); } },
                {"certificationAuthorityName", n => { CertificationAuthorityName = n.GetStringValue(); } },
                {"managedDeviceCertificateStates", n => { ManagedDeviceCertificateStates = n.GetCollectionOfObjectValues<ManagedDeviceCertificateState>(ManagedDeviceCertificateState.CreateFromDiscriminatorValue)?.ToList(); } },
                {"subjectAlternativeNameFormatString", n => { SubjectAlternativeNameFormatString = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("certificateTemplateName", CertificateTemplateName);
            writer.WriteStringValue("certificationAuthority", CertificationAuthority);
            writer.WriteStringValue("certificationAuthorityName", CertificationAuthorityName);
            writer.WriteCollectionOfObjectValues<ManagedDeviceCertificateState>("managedDeviceCertificateStates", ManagedDeviceCertificateStates);
            writer.WriteStringValue("subjectAlternativeNameFormatString", SubjectAlternativeNameFormatString);
        }
    }
}
