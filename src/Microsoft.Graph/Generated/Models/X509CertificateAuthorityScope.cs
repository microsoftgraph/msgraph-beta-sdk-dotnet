// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class X509CertificateAuthorityScope : IAdditionalDataHolder, IBackedModel, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>A collection of groups that are enabled to be in scope to use certificates issued by specific certificate authority.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.IncludeTarget>? IncludeTargets
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.IncludeTarget>?>("includeTargets"); }
            set { BackingStore?.Set("includeTargets", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.IncludeTarget> IncludeTargets
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.IncludeTarget>>("includeTargets"); }
            set { BackingStore?.Set("includeTargets", value); }
        }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType
        {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType
        {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>Public Key Infrastructure container object under which the certificate authorities are stored in the Entra PKI based trust store.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PublicKeyInfrastructureIdentifier
        {
            get { return BackingStore?.Get<string?>("publicKeyInfrastructureIdentifier"); }
            set { BackingStore?.Set("publicKeyInfrastructureIdentifier", value); }
        }
#nullable restore
#else
        public string PublicKeyInfrastructureIdentifier
        {
            get { return BackingStore?.Get<string>("publicKeyInfrastructureIdentifier"); }
            set { BackingStore?.Set("publicKeyInfrastructureIdentifier", value); }
        }
#endif
        /// <summary>Subject Key Identifier that identifies the certificate authority uniquely.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SubjectKeyIdentifier
        {
            get { return BackingStore?.Get<string?>("subjectKeyIdentifier"); }
            set { BackingStore?.Set("subjectKeyIdentifier", value); }
        }
#nullable restore
#else
        public string SubjectKeyIdentifier
        {
            get { return BackingStore?.Get<string>("subjectKeyIdentifier"); }
            set { BackingStore?.Set("subjectKeyIdentifier", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.X509CertificateAuthorityScope"/> and sets the default values.
        /// </summary>
        public X509CertificateAuthorityScope()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.X509CertificateAuthorityScope"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Beta.Models.X509CertificateAuthorityScope CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.X509CertificateAuthorityScope();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "includeTargets", n => { IncludeTargets = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.IncludeTarget>(global::Microsoft.Graph.Beta.Models.IncludeTarget.CreateFromDiscriminatorValue)?.AsList(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "publicKeyInfrastructureIdentifier", n => { PublicKeyInfrastructureIdentifier = n.GetStringValue(); } },
                { "subjectKeyIdentifier", n => { SubjectKeyIdentifier = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.IncludeTarget>("includeTargets", IncludeTargets);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("publicKeyInfrastructureIdentifier", PublicKeyInfrastructureIdentifier);
            writer.WriteStringValue("subjectKeyIdentifier", SubjectKeyIdentifier);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
