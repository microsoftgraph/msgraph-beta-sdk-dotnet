// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>
    /// iOS SCEP certificate profile.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class IosScepCertificateProfile : global::Microsoft.Graph.Beta.Models.IosCertificateProfileBase, IParsable
    {
        /// <summary>Target store certificate. Possible values are: user, machine.</summary>
        public global::Microsoft.Graph.Beta.Models.CertificateStore? CertificateStore
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.CertificateStore?>("certificateStore"); }
            set { BackingStore?.Set("certificateStore", value); }
        }
        /// <summary>Custom Subject Alternative Name Settings. The OnPremisesUserPrincipalName variable is support as well as others documented here: https://go.microsoft.com/fwlink/?LinkId=2027630. This collection can contain a maximum of 500 elements.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.CustomSubjectAlternativeName>? CustomSubjectAlternativeNames
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.CustomSubjectAlternativeName>?>("customSubjectAlternativeNames"); }
            set { BackingStore?.Set("customSubjectAlternativeNames", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.CustomSubjectAlternativeName> CustomSubjectAlternativeNames
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.CustomSubjectAlternativeName>>("customSubjectAlternativeNames"); }
            set { BackingStore?.Set("customSubjectAlternativeNames", value); }
        }
#endif
        /// <summary>Extended Key Usage (EKU) settings. This collection can contain a maximum of 500 elements.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.ExtendedKeyUsage>? ExtendedKeyUsages
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.ExtendedKeyUsage>?>("extendedKeyUsages"); }
            set { BackingStore?.Set("extendedKeyUsages", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.ExtendedKeyUsage> ExtendedKeyUsages
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.ExtendedKeyUsage>>("extendedKeyUsages"); }
            set { BackingStore?.Set("extendedKeyUsages", value); }
        }
#endif
        /// <summary>Key Size Options.</summary>
        public global::Microsoft.Graph.Beta.Models.KeySize? KeySize
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.KeySize?>("keySize"); }
            set { BackingStore?.Set("keySize", value); }
        }
        /// <summary>Key Usage Options.</summary>
        public global::Microsoft.Graph.Beta.Models.KeyUsages? KeyUsage
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.KeyUsages?>("keyUsage"); }
            set { BackingStore?.Set("keyUsage", value); }
        }
        /// <summary>Certificate state for devices. This collection can contain a maximum of 2147483647 elements.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.ManagedDeviceCertificateState>? ManagedDeviceCertificateStates
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.ManagedDeviceCertificateState>?>("managedDeviceCertificateStates"); }
            set { BackingStore?.Set("managedDeviceCertificateStates", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.ManagedDeviceCertificateState> ManagedDeviceCertificateStates
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.ManagedDeviceCertificateState>>("managedDeviceCertificateStates"); }
            set { BackingStore?.Set("managedDeviceCertificateStates", value); }
        }
#endif
        /// <summary>Trusted Root Certificate.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.IosTrustedRootCertificate? RootCertificate
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.IosTrustedRootCertificate?>("rootCertificate"); }
            set { BackingStore?.Set("rootCertificate", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.IosTrustedRootCertificate RootCertificate
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.IosTrustedRootCertificate>("rootCertificate"); }
            set { BackingStore?.Set("rootCertificate", value); }
        }
#endif
        /// <summary>SCEP Server Url(s).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? ScepServerUrls
        {
            get { return BackingStore?.Get<List<string>?>("scepServerUrls"); }
            set { BackingStore?.Set("scepServerUrls", value); }
        }
#nullable restore
#else
        public List<string> ScepServerUrls
        {
            get { return BackingStore?.Get<List<string>>("scepServerUrls"); }
            set { BackingStore?.Set("scepServerUrls", value); }
        }
#endif
        /// <summary>Custom String that defines the AAD Attribute.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SubjectAlternativeNameFormatString
        {
            get { return BackingStore?.Get<string?>("subjectAlternativeNameFormatString"); }
            set { BackingStore?.Set("subjectAlternativeNameFormatString", value); }
        }
#nullable restore
#else
        public string SubjectAlternativeNameFormatString
        {
            get { return BackingStore?.Get<string>("subjectAlternativeNameFormatString"); }
            set { BackingStore?.Set("subjectAlternativeNameFormatString", value); }
        }
#endif
        /// <summary>Custom format to use with SubjectNameFormat = Custom. Example: CN={{EmailAddress}},E={{EmailAddress}},OU=Enterprise Users,O=Contoso Corporation,L=Redmond,ST=WA,C=US</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SubjectNameFormatString
        {
            get { return BackingStore?.Get<string?>("subjectNameFormatString"); }
            set { BackingStore?.Set("subjectNameFormatString", value); }
        }
#nullable restore
#else
        public string SubjectNameFormatString
        {
            get { return BackingStore?.Get<string>("subjectNameFormatString"); }
            set { BackingStore?.Set("subjectNameFormatString", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.IosScepCertificateProfile"/> and sets the default values.
        /// </summary>
        public IosScepCertificateProfile() : base()
        {
            OdataType = "#microsoft.graph.iosScepCertificateProfile";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.IosScepCertificateProfile"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.IosScepCertificateProfile CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.IosScepCertificateProfile();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "certificateStore", n => { CertificateStore = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.CertificateStore>(); } },
                { "customSubjectAlternativeNames", n => { CustomSubjectAlternativeNames = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.CustomSubjectAlternativeName>(global::Microsoft.Graph.Beta.Models.CustomSubjectAlternativeName.CreateFromDiscriminatorValue)?.AsList(); } },
                { "extendedKeyUsages", n => { ExtendedKeyUsages = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.ExtendedKeyUsage>(global::Microsoft.Graph.Beta.Models.ExtendedKeyUsage.CreateFromDiscriminatorValue)?.AsList(); } },
                { "keySize", n => { KeySize = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.KeySize>(); } },
                { "keyUsage", n => { KeyUsage = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.KeyUsages>(); } },
                { "managedDeviceCertificateStates", n => { ManagedDeviceCertificateStates = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.ManagedDeviceCertificateState>(global::Microsoft.Graph.Beta.Models.ManagedDeviceCertificateState.CreateFromDiscriminatorValue)?.AsList(); } },
                { "rootCertificate", n => { RootCertificate = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.IosTrustedRootCertificate>(global::Microsoft.Graph.Beta.Models.IosTrustedRootCertificate.CreateFromDiscriminatorValue); } },
                { "scepServerUrls", n => { ScepServerUrls = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "subjectAlternativeNameFormatString", n => { SubjectAlternativeNameFormatString = n.GetStringValue(); } },
                { "subjectNameFormatString", n => { SubjectNameFormatString = n.GetStringValue(); } },
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
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.CertificateStore>("certificateStore", CertificateStore);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.CustomSubjectAlternativeName>("customSubjectAlternativeNames", CustomSubjectAlternativeNames);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.ExtendedKeyUsage>("extendedKeyUsages", ExtendedKeyUsages);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.KeySize>("keySize", KeySize);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.KeyUsages>("keyUsage", KeyUsage);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.ManagedDeviceCertificateState>("managedDeviceCertificateStates", ManagedDeviceCertificateStates);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.IosTrustedRootCertificate>("rootCertificate", RootCertificate);
            writer.WriteCollectionOfPrimitiveValues<string>("scepServerUrls", ScepServerUrls);
            writer.WriteStringValue("subjectAlternativeNameFormatString", SubjectAlternativeNameFormatString);
            writer.WriteStringValue("subjectNameFormatString", SubjectNameFormatString);
        }
    }
}
#pragma warning restore CS0618
