using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class WindowsCertificateProfileBase : DeviceConfiguration, IParsable {
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
        /// <summary>Key Storage Provider (KSP) Import Options.</summary>
        public KeyStorageProviderOption? KeyStorageProvider {
            get { return BackingStore?.Get<KeyStorageProviderOption?>("keyStorageProvider"); }
            set { BackingStore?.Set("keyStorageProvider", value); }
        }
        /// <summary>Certificate renewal threshold percentage. Valid values 1 to 99</summary>
        public int? RenewalThresholdPercentage {
            get { return BackingStore?.Get<int?>("renewalThresholdPercentage"); }
            set { BackingStore?.Set("renewalThresholdPercentage", value); }
        }
        /// <summary>Certificate Subject Alternative Name Type. Possible values are: none, emailAddress, userPrincipalName, customAzureADAttribute, domainNameService, universalResourceIdentifier.</summary>
        public Microsoft.Graph.Beta.Models.SubjectAlternativeNameType? SubjectAlternativeNameType {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.SubjectAlternativeNameType?>("subjectAlternativeNameType"); }
            set { BackingStore?.Set("subjectAlternativeNameType", value); }
        }
        /// <summary>Subject Name Format Options.</summary>
        public Microsoft.Graph.Beta.Models.SubjectNameFormat? SubjectNameFormat {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.SubjectNameFormat?>("subjectNameFormat"); }
            set { BackingStore?.Set("subjectNameFormat", value); }
        }
        /// <summary>
        /// Instantiates a new WindowsCertificateProfileBase and sets the default values.
        /// </summary>
        public WindowsCertificateProfileBase() : base() {
            OdataType = "#microsoft.graph.windowsCertificateProfileBase";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new WindowsCertificateProfileBase CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.windows10CertificateProfileBase" => new Windows10CertificateProfileBase(),
                "#microsoft.graph.windows10ImportedPFXCertificateProfile" => new Windows10ImportedPFXCertificateProfile(),
                "#microsoft.graph.windows10PkcsCertificateProfile" => new Windows10PkcsCertificateProfile(),
                "#microsoft.graph.windows81CertificateProfileBase" => new Windows81CertificateProfileBase(),
                "#microsoft.graph.windows81SCEPCertificateProfile" => new Windows81SCEPCertificateProfile(),
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
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
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
