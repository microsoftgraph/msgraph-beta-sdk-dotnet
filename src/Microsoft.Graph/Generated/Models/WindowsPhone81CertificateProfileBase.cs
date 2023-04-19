using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class WindowsPhone81CertificateProfileBase : DeviceConfiguration, IParsable {
        /// <summary>Certificate Validity Period Options.</summary>
        public Microsoft.Graph.Beta.Models.CertificateValidityPeriodScale? CertificateValidityPeriodScale {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.CertificateValidityPeriodScale?>("certificateValidityPeriodScale"); }
            set { BackingStore?.Set("certificateValidityPeriodScale", value); }
        }
        /// <summary>Value for the Certificate Validtiy Period.</summary>
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
        /// <summary>Key Storage Provider (KSP) Import Options.</summary>
        public KeyStorageProviderOption? KeyStorageProvider {
            get { return BackingStore?.Get<KeyStorageProviderOption?>("keyStorageProvider"); }
            set { BackingStore?.Set("keyStorageProvider", value); }
        }
        /// <summary>Certificate renewal threshold percentage.</summary>
        public int? RenewalThresholdPercentage {
            get { return BackingStore?.Get<int?>("renewalThresholdPercentage"); }
            set { BackingStore?.Set("renewalThresholdPercentage", value); }
        }
        /// <summary>Subject Alternative Name Options.</summary>
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
        /// Instantiates a new windowsPhone81CertificateProfileBase and sets the default values.
        /// </summary>
        public WindowsPhone81CertificateProfileBase() : base() {
            OdataType = "#microsoft.graph.windowsPhone81CertificateProfileBase";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new WindowsPhone81CertificateProfileBase CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WindowsPhone81CertificateProfileBase();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"certificateValidityPeriodScale", n => { CertificateValidityPeriodScale = n.GetEnumValue<CertificateValidityPeriodScale>(); } },
                {"certificateValidityPeriodValue", n => { CertificateValidityPeriodValue = n.GetIntValue(); } },
                {"extendedKeyUsages", n => { ExtendedKeyUsages = n.GetCollectionOfObjectValues<ExtendedKeyUsage>(ExtendedKeyUsage.CreateFromDiscriminatorValue)?.ToList(); } },
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
            writer.WriteCollectionOfObjectValues<ExtendedKeyUsage>("extendedKeyUsages", ExtendedKeyUsages);
            writer.WriteEnumValue<KeyStorageProviderOption>("keyStorageProvider", KeyStorageProvider);
            writer.WriteIntValue("renewalThresholdPercentage", RenewalThresholdPercentage);
            writer.WriteEnumValue<SubjectAlternativeNameType>("subjectAlternativeNameType", SubjectAlternativeNameType);
            writer.WriteEnumValue<SubjectNameFormat>("subjectNameFormat", SubjectNameFormat);
        }
    }
}
