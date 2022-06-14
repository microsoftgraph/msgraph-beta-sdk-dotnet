using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class WindowsCertificateProfileBase : DeviceConfiguration, IParsable {
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
        /// <summary>Key Storage Provider (KSP). Possible values are: useTpmKspOtherwiseUseSoftwareKsp, useTpmKspOtherwiseFail, usePassportForWorkKspOtherwiseFail, useSoftwareKsp.</summary>
        public KeyStorageProviderOption? KeyStorageProvider {
            get { return BackingStore?.Get<KeyStorageProviderOption?>(nameof(KeyStorageProvider)); }
            set { BackingStore?.Set(nameof(KeyStorageProvider), value); }
        }
        /// <summary>Certificate renewal threshold percentage. Valid values 1 to 99</summary>
        public int? RenewalThresholdPercentage {
            get { return BackingStore?.Get<int?>(nameof(RenewalThresholdPercentage)); }
            set { BackingStore?.Set(nameof(RenewalThresholdPercentage), value); }
        }
        /// <summary>Certificate Subject Alternative Name Type. Possible values are: none, emailAddress, userPrincipalName, customAzureADAttribute, domainNameService, universalResourceIdentifier.</summary>
        public Microsoft.Graph.Beta.Models.SubjectAlternativeNameType? SubjectAlternativeNameType {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.SubjectAlternativeNameType?>(nameof(SubjectAlternativeNameType)); }
            set { BackingStore?.Set(nameof(SubjectAlternativeNameType), value); }
        }
        /// <summary>Certificate Subject Name Format. Possible values are: commonName, commonNameIncludingEmail, commonNameAsEmail, custom, commonNameAsIMEI, commonNameAsSerialNumber, commonNameAsAadDeviceId, commonNameAsIntuneDeviceId, commonNameAsDurableDeviceId.</summary>
        public Microsoft.Graph.Beta.Models.SubjectNameFormat? SubjectNameFormat {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.SubjectNameFormat?>(nameof(SubjectNameFormat)); }
            set { BackingStore?.Set(nameof(SubjectNameFormat), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new WindowsCertificateProfileBase CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValueNode = parseNode.GetChildNode("@odata.type");
            var mappingValue = mappingValueNode?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.windows10CertificateProfileBase" => new Windows10CertificateProfileBase(),
                "#microsoft.graph.windows10ImportedPFXCertificateProfile" => new Windows10ImportedPFXCertificateProfile(),
                "#microsoft.graph.windows81CertificateProfileBase" => new Windows81CertificateProfileBase(),
                "#microsoft.graph.windowsPhone81ImportedPFXCertificateProfile" => new WindowsPhone81ImportedPFXCertificateProfile(),
                _ => new WindowsCertificateProfileBase(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"certificateValidityPeriodScale", n => { CertificateValidityPeriodScale = n.GetEnumValue<CertificateValidityPeriodScale>(); } },
                {"certificateValidityPeriodValue", n => { CertificateValidityPeriodValue = n.GetIntValue(); } },
                {"keyStorageProvider", n => { KeyStorageProvider = n.GetEnumValue<KeyStorageProviderOption>(); } },
                {"renewalThresholdPercentage", n => { RenewalThresholdPercentage = n.GetIntValue(); } },
                {"subjectAlternativeNameType", n => { SubjectAlternativeNameType = n.GetEnumValue<SubjectAlternativeNameType>(); } },
                {"subjectNameFormat", n => { SubjectNameFormat = n.GetEnumValue<SubjectNameFormat>(); } },
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
            writer.WriteEnumValue<KeyStorageProviderOption>("keyStorageProvider", KeyStorageProvider);
            writer.WriteIntValue("renewalThresholdPercentage", RenewalThresholdPercentage);
            writer.WriteEnumValue<SubjectAlternativeNameType>("subjectAlternativeNameType", SubjectAlternativeNameType);
            writer.WriteEnumValue<SubjectNameFormat>("subjectNameFormat", SubjectNameFormat);
        }
    }
}
