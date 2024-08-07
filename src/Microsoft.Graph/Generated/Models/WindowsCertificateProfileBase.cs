// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>
    /// Device Configuration.
    /// </summary>
    public class WindowsCertificateProfileBase : Microsoft.Graph.Beta.Models.DeviceConfiguration, IParsable
    {
        /// <summary>Certificate Validity Period Options.</summary>
        public Microsoft.Graph.Beta.Models.CertificateValidityPeriodScale? CertificateValidityPeriodScale
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.CertificateValidityPeriodScale?>("certificateValidityPeriodScale"); }
            set { BackingStore?.Set("certificateValidityPeriodScale", value); }
        }
        /// <summary>Value for the Certificate Validity Period</summary>
        public int? CertificateValidityPeriodValue
        {
            get { return BackingStore?.Get<int?>("certificateValidityPeriodValue"); }
            set { BackingStore?.Set("certificateValidityPeriodValue", value); }
        }
        /// <summary>Key Storage Provider (KSP) Import Options.</summary>
        public Microsoft.Graph.Beta.Models.KeyStorageProviderOption? KeyStorageProvider
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.KeyStorageProviderOption?>("keyStorageProvider"); }
            set { BackingStore?.Set("keyStorageProvider", value); }
        }
        /// <summary>Certificate renewal threshold percentage. Valid values 1 to 99</summary>
        public int? RenewalThresholdPercentage
        {
            get { return BackingStore?.Get<int?>("renewalThresholdPercentage"); }
            set { BackingStore?.Set("renewalThresholdPercentage", value); }
        }
        /// <summary>Certificate Subject Alternative Name Type. Possible values are: none, emailAddress, userPrincipalName, customAzureADAttribute, domainNameService, universalResourceIdentifier.</summary>
        public Microsoft.Graph.Beta.Models.SubjectAlternativeNameType? SubjectAlternativeNameType
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.SubjectAlternativeNameType?>("subjectAlternativeNameType"); }
            set { BackingStore?.Set("subjectAlternativeNameType", value); }
        }
        /// <summary>Subject Name Format Options.</summary>
        public Microsoft.Graph.Beta.Models.SubjectNameFormat? SubjectNameFormat
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.SubjectNameFormat?>("subjectNameFormat"); }
            set { BackingStore?.Set("subjectNameFormat", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Models.WindowsCertificateProfileBase"/> and sets the default values.
        /// </summary>
        public WindowsCertificateProfileBase() : base()
        {
            OdataType = "#microsoft.graph.windowsCertificateProfileBase";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.WindowsCertificateProfileBase"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.WindowsCertificateProfileBase CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.windows10CertificateProfileBase" => new Microsoft.Graph.Beta.Models.Windows10CertificateProfileBase(),
                "#microsoft.graph.windows10ImportedPFXCertificateProfile" => new Microsoft.Graph.Beta.Models.Windows10ImportedPFXCertificateProfile(),
                "#microsoft.graph.windows10PkcsCertificateProfile" => new Microsoft.Graph.Beta.Models.Windows10PkcsCertificateProfile(),
                "#microsoft.graph.windows81CertificateProfileBase" => new Microsoft.Graph.Beta.Models.Windows81CertificateProfileBase(),
                "#microsoft.graph.windows81SCEPCertificateProfile" => new Microsoft.Graph.Beta.Models.Windows81SCEPCertificateProfile(),
                "#microsoft.graph.windowsPhone81ImportedPFXCertificateProfile" => new Microsoft.Graph.Beta.Models.WindowsPhone81ImportedPFXCertificateProfile(),
                _ => new Microsoft.Graph.Beta.Models.WindowsCertificateProfileBase(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "certificateValidityPeriodScale", n => { CertificateValidityPeriodScale = n.GetEnumValue<Microsoft.Graph.Beta.Models.CertificateValidityPeriodScale>(); } },
                { "certificateValidityPeriodValue", n => { CertificateValidityPeriodValue = n.GetIntValue(); } },
                { "keyStorageProvider", n => { KeyStorageProvider = n.GetEnumValue<Microsoft.Graph.Beta.Models.KeyStorageProviderOption>(); } },
                { "renewalThresholdPercentage", n => { RenewalThresholdPercentage = n.GetIntValue(); } },
                { "subjectAlternativeNameType", n => { SubjectAlternativeNameType = n.GetEnumValue<Microsoft.Graph.Beta.Models.SubjectAlternativeNameType>(); } },
                { "subjectNameFormat", n => { SubjectNameFormat = n.GetEnumValue<Microsoft.Graph.Beta.Models.SubjectNameFormat>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<Microsoft.Graph.Beta.Models.CertificateValidityPeriodScale>("certificateValidityPeriodScale", CertificateValidityPeriodScale);
            writer.WriteIntValue("certificateValidityPeriodValue", CertificateValidityPeriodValue);
            writer.WriteEnumValue<Microsoft.Graph.Beta.Models.KeyStorageProviderOption>("keyStorageProvider", KeyStorageProvider);
            writer.WriteIntValue("renewalThresholdPercentage", RenewalThresholdPercentage);
            writer.WriteEnumValue<Microsoft.Graph.Beta.Models.SubjectAlternativeNameType>("subjectAlternativeNameType", SubjectAlternativeNameType);
            writer.WriteEnumValue<Microsoft.Graph.Beta.Models.SubjectNameFormat>("subjectNameFormat", SubjectNameFormat);
        }
    }
}
