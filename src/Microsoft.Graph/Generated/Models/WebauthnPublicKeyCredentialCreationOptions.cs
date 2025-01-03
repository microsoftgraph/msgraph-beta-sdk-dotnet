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
    public partial class WebauthnPublicKeyCredentialCreationOptions : IAdditionalDataHolder, IBackedModel, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>Attestation preference for the Microsoft Entra ID relying party.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Attestation
        {
            get { return BackingStore?.Get<string?>("attestation"); }
            set { BackingStore?.Set("attestation", value); }
        }
#nullable restore
#else
        public string Attestation
        {
            get { return BackingStore?.Get<string>("attestation"); }
            set { BackingStore?.Set("attestation", value); }
        }
#endif
        /// <summary>Properties of WebAuthn authenticators allowed to be used for authentication in Microsoft Entra ID.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.WebauthnAuthenticatorSelectionCriteria? AuthenticatorSelection
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.WebauthnAuthenticatorSelectionCriteria?>("authenticatorSelection"); }
            set { BackingStore?.Set("authenticatorSelection", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.WebauthnAuthenticatorSelectionCriteria AuthenticatorSelection
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.WebauthnAuthenticatorSelectionCriteria>("authenticatorSelection"); }
            set { BackingStore?.Set("authenticatorSelection", value); }
        }
#endif
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>A Base64-encoded challenge generated by Microsoft Entra ID and sent back with the registration request to prevent replay attacks.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Challenge
        {
            get { return BackingStore?.Get<string?>("challenge"); }
            set { BackingStore?.Set("challenge", value); }
        }
#nullable restore
#else
        public string Challenge
        {
            get { return BackingStore?.Get<string>("challenge"); }
            set { BackingStore?.Set("challenge", value); }
        }
#endif
        /// <summary>List of credentials blocked for creations in Microsoft Entra ID.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.WebauthnPublicKeyCredentialDescriptor>? ExcludeCredentials
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.WebauthnPublicKeyCredentialDescriptor>?>("excludeCredentials"); }
            set { BackingStore?.Set("excludeCredentials", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.WebauthnPublicKeyCredentialDescriptor> ExcludeCredentials
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.WebauthnPublicKeyCredentialDescriptor>>("excludeCredentials"); }
            set { BackingStore?.Set("excludeCredentials", value); }
        }
#endif
        /// <summary>Additional processing required by Microsoft Entra ID for the client and WebAuthn authenticator. For example, Microsoft Entra ID might require that particular information be returned in the attestation object.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.WebauthnAuthenticationExtensionsClientInputs? Extensions
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.WebauthnAuthenticationExtensionsClientInputs?>("extensions"); }
            set { BackingStore?.Set("extensions", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.WebauthnAuthenticationExtensionsClientInputs Extensions
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.WebauthnAuthenticationExtensionsClientInputs>("extensions"); }
            set { BackingStore?.Set("extensions", value); }
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
        /// <summary>A set of preferred credential properties for the creation of a new public key credential in Microsoft Entra ID.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.WebauthnPublicKeyCredentialParameters>? PubKeyCredParams
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.WebauthnPublicKeyCredentialParameters>?>("pubKeyCredParams"); }
            set { BackingStore?.Set("pubKeyCredParams", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.WebauthnPublicKeyCredentialParameters> PubKeyCredParams
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.WebauthnPublicKeyCredentialParameters>>("pubKeyCredParams"); }
            set { BackingStore?.Set("pubKeyCredParams", value); }
        }
#endif
        /// <summary>Information about the relying party (Microsoft Entra ID) responsible for the request.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.WebauthnPublicKeyCredentialRpEntity? Rp
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.WebauthnPublicKeyCredentialRpEntity?>("rp"); }
            set { BackingStore?.Set("rp", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.WebauthnPublicKeyCredentialRpEntity Rp
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.WebauthnPublicKeyCredentialRpEntity>("rp"); }
            set { BackingStore?.Set("rp", value); }
        }
#endif
        /// <summary>The time in milliseconds that the client is willing to wait for the credential creation operation to complete.</summary>
        public int? Timeout
        {
            get { return BackingStore?.Get<int?>("timeout"); }
            set { BackingStore?.Set("timeout", value); }
        }
        /// <summary>Information about the user account for which the credential is generated.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.WebauthnPublicKeyCredentialUserEntity? User
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.WebauthnPublicKeyCredentialUserEntity?>("user"); }
            set { BackingStore?.Set("user", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.WebauthnPublicKeyCredentialUserEntity User
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.WebauthnPublicKeyCredentialUserEntity>("user"); }
            set { BackingStore?.Set("user", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.WebauthnPublicKeyCredentialCreationOptions"/> and sets the default values.
        /// </summary>
        public WebauthnPublicKeyCredentialCreationOptions()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.WebauthnPublicKeyCredentialCreationOptions"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Beta.Models.WebauthnPublicKeyCredentialCreationOptions CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.WebauthnPublicKeyCredentialCreationOptions();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "attestation", n => { Attestation = n.GetStringValue(); } },
                { "authenticatorSelection", n => { AuthenticatorSelection = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.WebauthnAuthenticatorSelectionCriteria>(global::Microsoft.Graph.Beta.Models.WebauthnAuthenticatorSelectionCriteria.CreateFromDiscriminatorValue); } },
                { "challenge", n => { Challenge = n.GetStringValue(); } },
                { "excludeCredentials", n => { ExcludeCredentials = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.WebauthnPublicKeyCredentialDescriptor>(global::Microsoft.Graph.Beta.Models.WebauthnPublicKeyCredentialDescriptor.CreateFromDiscriminatorValue)?.AsList(); } },
                { "extensions", n => { Extensions = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.WebauthnAuthenticationExtensionsClientInputs>(global::Microsoft.Graph.Beta.Models.WebauthnAuthenticationExtensionsClientInputs.CreateFromDiscriminatorValue); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "pubKeyCredParams", n => { PubKeyCredParams = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.WebauthnPublicKeyCredentialParameters>(global::Microsoft.Graph.Beta.Models.WebauthnPublicKeyCredentialParameters.CreateFromDiscriminatorValue)?.AsList(); } },
                { "rp", n => { Rp = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.WebauthnPublicKeyCredentialRpEntity>(global::Microsoft.Graph.Beta.Models.WebauthnPublicKeyCredentialRpEntity.CreateFromDiscriminatorValue); } },
                { "timeout", n => { Timeout = n.GetIntValue(); } },
                { "user", n => { User = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.WebauthnPublicKeyCredentialUserEntity>(global::Microsoft.Graph.Beta.Models.WebauthnPublicKeyCredentialUserEntity.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("attestation", Attestation);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.WebauthnAuthenticatorSelectionCriteria>("authenticatorSelection", AuthenticatorSelection);
            writer.WriteStringValue("challenge", Challenge);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.WebauthnPublicKeyCredentialDescriptor>("excludeCredentials", ExcludeCredentials);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.WebauthnAuthenticationExtensionsClientInputs>("extensions", Extensions);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.WebauthnPublicKeyCredentialParameters>("pubKeyCredParams", PubKeyCredParams);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.WebauthnPublicKeyCredentialRpEntity>("rp", Rp);
            writer.WriteIntValue("timeout", Timeout);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.WebauthnPublicKeyCredentialUserEntity>("user", User);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
