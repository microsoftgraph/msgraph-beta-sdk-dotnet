using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Trusted Root and PFX certificates for iOS EDU.</summary>
    public class IosEduCertificateSettings : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>File name to display in UI.</summary>
        public string CertFileName {
            get { return BackingStore?.Get<string>(nameof(CertFileName)); }
            set { BackingStore?.Set(nameof(CertFileName), value); }
        }
        /// <summary>PKCS Certificate Template Name.</summary>
        public string CertificateTemplateName {
            get { return BackingStore?.Get<string>(nameof(CertificateTemplateName)); }
            set { BackingStore?.Set(nameof(CertificateTemplateName), value); }
        }
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
        /// <summary>PKCS Certification Authority.</summary>
        public string CertificationAuthority {
            get { return BackingStore?.Get<string>(nameof(CertificationAuthority)); }
            set { BackingStore?.Set(nameof(CertificationAuthority), value); }
        }
        /// <summary>PKCS Certification Authority Name.</summary>
        public string CertificationAuthorityName {
            get { return BackingStore?.Get<string>(nameof(CertificationAuthorityName)); }
            set { BackingStore?.Set(nameof(CertificationAuthorityName), value); }
        }
        /// <summary>Certificate renewal threshold percentage. Valid values 1 to 99</summary>
        public int? RenewalThresholdPercentage {
            get { return BackingStore?.Get<int?>(nameof(RenewalThresholdPercentage)); }
            set { BackingStore?.Set(nameof(RenewalThresholdPercentage), value); }
        }
        /// <summary>Trusted Root Certificate.</summary>
        public byte[] TrustedRootCertificate {
            get { return BackingStore?.Get<byte[]>(nameof(TrustedRootCertificate)); }
            set { BackingStore?.Set(nameof(TrustedRootCertificate), value); }
        }
        /// <summary>
        /// Instantiates a new iosEduCertificateSettings and sets the default values.
        /// </summary>
        public IosEduCertificateSettings() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static IosEduCertificateSettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new IosEduCertificateSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"certFileName", n => { CertFileName = n.GetStringValue(); } },
                {"certificateTemplateName", n => { CertificateTemplateName = n.GetStringValue(); } },
                {"certificateValidityPeriodScale", n => { CertificateValidityPeriodScale = n.GetEnumValue<CertificateValidityPeriodScale>(); } },
                {"certificateValidityPeriodValue", n => { CertificateValidityPeriodValue = n.GetIntValue(); } },
                {"certificationAuthority", n => { CertificationAuthority = n.GetStringValue(); } },
                {"certificationAuthorityName", n => { CertificationAuthorityName = n.GetStringValue(); } },
                {"renewalThresholdPercentage", n => { RenewalThresholdPercentage = n.GetIntValue(); } },
                {"trustedRootCertificate", n => { TrustedRootCertificate = n.GetByteArrayValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("certFileName", CertFileName);
            writer.WriteStringValue("certificateTemplateName", CertificateTemplateName);
            writer.WriteEnumValue<CertificateValidityPeriodScale>("certificateValidityPeriodScale", CertificateValidityPeriodScale);
            writer.WriteIntValue("certificateValidityPeriodValue", CertificateValidityPeriodValue);
            writer.WriteStringValue("certificationAuthority", CertificationAuthority);
            writer.WriteStringValue("certificationAuthorityName", CertificationAuthorityName);
            writer.WriteIntValue("renewalThresholdPercentage", RenewalThresholdPercentage);
            writer.WriteByteArrayValue("trustedRootCertificate", TrustedRootCertificate);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
