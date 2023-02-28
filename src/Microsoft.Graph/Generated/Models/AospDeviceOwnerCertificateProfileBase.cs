using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class AospDeviceOwnerCertificateProfileBase : DeviceConfiguration, IParsable {
        /// <summary>Certificate Validity Period Options.</summary>
        public Microsoft.Graph.Beta.Models.CertificateValidityPeriodScale? CertificateValidityPeriodScale {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.CertificateValidityPeriodScale?>("certificateValidityPeriodScale"); }
            set { BackingStore?.Set("certificateValidityPeriodScale", value); }
        }
        /// <summary>Value for the Certificate Validity Period.</summary>
        public int? CertificateValidityPeriodValue {
            get { return BackingStore?.Get<int?>("certificateValidityPeriodValue"); }
            set { BackingStore?.Set("certificateValidityPeriodValue", value); }
        }
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
        /// <summary>Certificate renewal threshold percentage. Valid values 1 to 99</summary>
        public int? RenewalThresholdPercentage {
            get { return BackingStore?.Get<int?>("renewalThresholdPercentage"); }
            set { BackingStore?.Set("renewalThresholdPercentage", value); }
        }
        /// <summary>Trusted Root Certificate.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public AospDeviceOwnerTrustedRootCertificate? RootCertificate {
            get { return BackingStore?.Get<AospDeviceOwnerTrustedRootCertificate?>("rootCertificate"); }
            set { BackingStore?.Set("rootCertificate", value); }
        }
#nullable restore
#else
        public AospDeviceOwnerTrustedRootCertificate RootCertificate {
            get { return BackingStore?.Get<AospDeviceOwnerTrustedRootCertificate>("rootCertificate"); }
            set { BackingStore?.Set("rootCertificate", value); }
        }
#endif
        /// <summary>Certificate Subject Alternative Name Type. This collection can contain a maximum of 500 elements. Possible values are: none, emailAddress, userPrincipalName, customAzureADAttribute, domainNameService, universalResourceIdentifier.</summary>
        public Microsoft.Graph.Beta.Models.SubjectAlternativeNameType? SubjectAlternativeNameType {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.SubjectAlternativeNameType?>("subjectAlternativeNameType"); }
            set { BackingStore?.Set("subjectAlternativeNameType", value); }
        }
        /// <summary>Certificate Subject Name Format. This collection can contain a maximum of 500 elements. Possible values are: commonName, commonNameIncludingEmail, commonNameAsEmail, custom, commonNameAsIMEI, commonNameAsSerialNumber, commonNameAsAadDeviceId, commonNameAsIntuneDeviceId, commonNameAsDurableDeviceId.</summary>
        public Microsoft.Graph.Beta.Models.SubjectNameFormat? SubjectNameFormat {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.SubjectNameFormat?>("subjectNameFormat"); }
            set { BackingStore?.Set("subjectNameFormat", value); }
        }
        /// <summary>
        /// Instantiates a new AospDeviceOwnerCertificateProfileBase and sets the default values.
        /// </summary>
        public AospDeviceOwnerCertificateProfileBase() : base() {
            OdataType = "#microsoft.graph.aospDeviceOwnerCertificateProfileBase";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new AospDeviceOwnerCertificateProfileBase CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.aospDeviceOwnerPkcsCertificateProfile" => new AospDeviceOwnerPkcsCertificateProfile(),
                "#microsoft.graph.aospDeviceOwnerScepCertificateProfile" => new AospDeviceOwnerScepCertificateProfile(),
                _ => new AospDeviceOwnerCertificateProfileBase(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"certificateValidityPeriodScale", n => { CertificateValidityPeriodScale = n.GetEnumValue<CertificateValidityPeriodScale>(); } },
                {"certificateValidityPeriodValue", n => { CertificateValidityPeriodValue = n.GetIntValue(); } },
                {"extendedKeyUsages", n => { ExtendedKeyUsages = n.GetCollectionOfObjectValues<ExtendedKeyUsage>(ExtendedKeyUsage.CreateFromDiscriminatorValue)?.ToList(); } },
                {"renewalThresholdPercentage", n => { RenewalThresholdPercentage = n.GetIntValue(); } },
                {"rootCertificate", n => { RootCertificate = n.GetObjectValue<AospDeviceOwnerTrustedRootCertificate>(AospDeviceOwnerTrustedRootCertificate.CreateFromDiscriminatorValue); } },
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
            writer.WriteCollectionOfObjectValues<ExtendedKeyUsage>("extendedKeyUsages", ExtendedKeyUsages);
            writer.WriteIntValue("renewalThresholdPercentage", RenewalThresholdPercentage);
            writer.WriteObjectValue<AospDeviceOwnerTrustedRootCertificate>("rootCertificate", RootCertificate);
            writer.WriteEnumValue<SubjectAlternativeNameType>("subjectAlternativeNameType", SubjectAlternativeNameType);
            writer.WriteEnumValue<SubjectNameFormat>("subjectNameFormat", SubjectNameFormat);
        }
    }
}
