using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class AndroidForWorkCertificateProfileBase : DeviceConfiguration, IParsable {
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
        /// <summary>Extended Key Usage (EKU) settings. This collection can contain a maximum of 500 elements.</summary>
        public List<ExtendedKeyUsage> ExtendedKeyUsages {
            get { return BackingStore?.Get<List<ExtendedKeyUsage>>(nameof(ExtendedKeyUsages)); }
            set { BackingStore?.Set(nameof(ExtendedKeyUsages), value); }
        }
        /// <summary>Certificate renewal threshold percentage. Valid values 1 to 99</summary>
        public int? RenewalThresholdPercentage {
            get { return BackingStore?.Get<int?>(nameof(RenewalThresholdPercentage)); }
            set { BackingStore?.Set(nameof(RenewalThresholdPercentage), value); }
        }
        /// <summary>Trusted Root Certificate.</summary>
        public AndroidForWorkTrustedRootCertificate RootCertificate {
            get { return BackingStore?.Get<AndroidForWorkTrustedRootCertificate>(nameof(RootCertificate)); }
            set { BackingStore?.Set(nameof(RootCertificate), value); }
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
        public static new AndroidForWorkCertificateProfileBase CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValueNode = parseNode.GetChildNode("@odata.type");
            var mappingValue = mappingValueNode?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.androidForWorkPkcsCertificateProfile" => new AndroidForWorkPkcsCertificateProfile(),
                "#microsoft.graph.androidForWorkScepCertificateProfile" => new AndroidForWorkScepCertificateProfile(),
                _ => new AndroidForWorkCertificateProfileBase(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"certificateValidityPeriodScale", n => { CertificateValidityPeriodScale = n.GetEnumValue<CertificateValidityPeriodScale>(); } },
                {"certificateValidityPeriodValue", n => { CertificateValidityPeriodValue = n.GetIntValue(); } },
                {"extendedKeyUsages", n => { ExtendedKeyUsages = n.GetCollectionOfObjectValues<ExtendedKeyUsage>(ExtendedKeyUsage.CreateFromDiscriminatorValue).ToList(); } },
                {"renewalThresholdPercentage", n => { RenewalThresholdPercentage = n.GetIntValue(); } },
                {"rootCertificate", n => { RootCertificate = n.GetObjectValue<AndroidForWorkTrustedRootCertificate>(AndroidForWorkTrustedRootCertificate.CreateFromDiscriminatorValue); } },
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
            writer.WriteCollectionOfObjectValues<ExtendedKeyUsage>("extendedKeyUsages", ExtendedKeyUsages);
            writer.WriteIntValue("renewalThresholdPercentage", RenewalThresholdPercentage);
            writer.WriteObjectValue<AndroidForWorkTrustedRootCertificate>("rootCertificate", RootCertificate);
            writer.WriteEnumValue<SubjectAlternativeNameType>("subjectAlternativeNameType", SubjectAlternativeNameType);
            writer.WriteEnumValue<SubjectNameFormat>("subjectNameFormat", SubjectNameFormat);
        }
    }
}
