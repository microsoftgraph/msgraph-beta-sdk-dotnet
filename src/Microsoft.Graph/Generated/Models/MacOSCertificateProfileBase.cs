using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Mac OS certificate profile.</summary>
    public class MacOSCertificateProfileBase : DeviceConfiguration, IParsable {
        /// <summary>Scale for the Certificate Validity Period. Possible values are: days, months, years.</summary>
        public Microsoft.Graph.Beta.Models.CertificateValidityPeriodScale? CertificateValidityPeriodScale {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.CertificateValidityPeriodScale?>(nameof(CertificateValidityPeriodScale)); }
            set { BackingStore?.Set(nameof(CertificateValidityPeriodScale), value); }
        }
        /// <summary>Value for the Certificate Validity Period.</summary>
        public int? CertificateValidityPeriodValue {
            get { return BackingStore?.Get<int?>(nameof(CertificateValidityPeriodValue)); }
            set { BackingStore?.Set(nameof(CertificateValidityPeriodValue), value); }
        }
        /// <summary>Certificate renewal threshold percentage.</summary>
        public int? RenewalThresholdPercentage {
            get { return BackingStore?.Get<int?>(nameof(RenewalThresholdPercentage)); }
            set { BackingStore?.Set(nameof(RenewalThresholdPercentage), value); }
        }
        /// <summary>Certificate Subject Alternative Name Type. Possible values are: none, emailAddress, userPrincipalName, customAzureADAttribute, domainNameService, universalResourceIdentifier.</summary>
        public Microsoft.Graph.Beta.Models.SubjectAlternativeNameType? SubjectAlternativeNameType {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.SubjectAlternativeNameType?>(nameof(SubjectAlternativeNameType)); }
            set { BackingStore?.Set(nameof(SubjectAlternativeNameType), value); }
        }
        /// <summary>Certificate Subject Name Format. Possible values are: commonName, commonNameAsEmail, custom, commonNameIncludingEmail, commonNameAsIMEI, commonNameAsSerialNumber.</summary>
        public AppleSubjectNameFormat? SubjectNameFormat {
            get { return BackingStore?.Get<AppleSubjectNameFormat?>(nameof(SubjectNameFormat)); }
            set { BackingStore?.Set(nameof(SubjectNameFormat), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new MacOSCertificateProfileBase CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValueNode = parseNode.GetChildNode("@odata.type");
            var mappingValue = mappingValueNode?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.macOSImportedPFXCertificateProfile" => new MacOSImportedPFXCertificateProfile(),
                "#microsoft.graph.macOSPkcsCertificateProfile" => new MacOSPkcsCertificateProfile(),
                "#microsoft.graph.macOSScepCertificateProfile" => new MacOSScepCertificateProfile(),
                _ => new MacOSCertificateProfileBase(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"certificateValidityPeriodScale", n => { CertificateValidityPeriodScale = n.GetEnumValue<CertificateValidityPeriodScale>(); } },
                {"certificateValidityPeriodValue", n => { CertificateValidityPeriodValue = n.GetIntValue(); } },
                {"renewalThresholdPercentage", n => { RenewalThresholdPercentage = n.GetIntValue(); } },
                {"subjectAlternativeNameType", n => { SubjectAlternativeNameType = n.GetEnumValue<SubjectAlternativeNameType>(); } },
                {"subjectNameFormat", n => { SubjectNameFormat = n.GetEnumValue<AppleSubjectNameFormat>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<CertificateValidityPeriodScale>("certificateValidityPeriodScale", CertificateValidityPeriodScale);
            writer.WriteIntValue("certificateValidityPeriodValue", CertificateValidityPeriodValue);
            writer.WriteIntValue("renewalThresholdPercentage", RenewalThresholdPercentage);
            writer.WriteEnumValue<SubjectAlternativeNameType>("subjectAlternativeNameType", SubjectAlternativeNameType);
            writer.WriteEnumValue<AppleSubjectNameFormat>("subjectNameFormat", SubjectNameFormat);
        }
    }
}
