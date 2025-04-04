// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class FederatedIdentityCredential : global::Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The audience that can appear in the external token. This field is mandatory and should be set to api://AzureADTokenExchange for Microsoft Entra ID. It says what Microsoft identity platform should accept in the aud claim in the incoming token. This value represents Microsoft Entra ID in your external identity provider and has no fixed value across identity providers - you may need to create a new application registration in your identity provider to serve as the audience of this token. This field can only accept a single value and has a limit of 600 characters. Required.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Audiences
        {
            get { return BackingStore?.Get<List<string>?>("audiences"); }
            set { BackingStore?.Set("audiences", value); }
        }
#nullable restore
#else
        public List<string> Audiences
        {
            get { return BackingStore?.Get<List<string>>("audiences"); }
            set { BackingStore?.Set("audiences", value); }
        }
#endif
        /// <summary>Nullable.  Defaults to null if not set. Enables the use of claims matching expressions against specified claims. If claimsMatchingExpression is defined, subject must be null. For the list of supported expression syntax and claims, visit the Flexible FIC reference.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.FederatedIdentityExpression? ClaimsMatchingExpression
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.FederatedIdentityExpression?>("claimsMatchingExpression"); }
            set { BackingStore?.Set("claimsMatchingExpression", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.FederatedIdentityExpression ClaimsMatchingExpression
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.FederatedIdentityExpression>("claimsMatchingExpression"); }
            set { BackingStore?.Set("claimsMatchingExpression", value); }
        }
#endif
        /// <summary>The un-validated, user-provided description of the federated identity credential. It has a limit of 600 characters. Optional.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description
        {
            get { return BackingStore?.Get<string?>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#nullable restore
#else
        public string Description
        {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#endif
        /// <summary>The URL of the external identity provider and must match the issuer claim of the external token being exchanged. The combination of the values of issuer and subject must be unique on the app. It has a limit of 600 characters. Required.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Issuer
        {
            get { return BackingStore?.Get<string?>("issuer"); }
            set { BackingStore?.Set("issuer", value); }
        }
#nullable restore
#else
        public string Issuer
        {
            get { return BackingStore?.Get<string>("issuer"); }
            set { BackingStore?.Set("issuer", value); }
        }
#endif
        /// <summary>The unique identifier for the federated identity credential, which has a limit of 120 characters and must be URL friendly. It is immutable once created. Alternate key. Required. Not nullable. Supports $filter (eq).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name
        {
            get { return BackingStore?.Get<string?>("name"); }
            set { BackingStore?.Set("name", value); }
        }
#nullable restore
#else
        public string Name
        {
            get { return BackingStore?.Get<string>("name"); }
            set { BackingStore?.Set("name", value); }
        }
#endif
        /// <summary>Nullable.  Defaults to null if not set. The identifier of the external software workload within the external identity provider. Like the audience value, it has no fixed format, as each identity provider uses their own - sometimes a GUID, sometimes a colon delimited identifier, sometimes arbitrary strings. The value here must match the sub claim within the token presented to Microsoft Entra ID. The combination of issuer and subject must be unique on the app. It has a limit of 600 characters. If subject is defined, claimsMatchingExpression must be null. Supports $filter (eq).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Subject
        {
            get { return BackingStore?.Get<string?>("subject"); }
            set { BackingStore?.Set("subject", value); }
        }
#nullable restore
#else
        public string Subject
        {
            get { return BackingStore?.Get<string>("subject"); }
            set { BackingStore?.Set("subject", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.FederatedIdentityCredential"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.FederatedIdentityCredential CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.FederatedIdentityCredential();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "audiences", n => { Audiences = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "claimsMatchingExpression", n => { ClaimsMatchingExpression = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.FederatedIdentityExpression>(global::Microsoft.Graph.Beta.Models.FederatedIdentityExpression.CreateFromDiscriminatorValue); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "issuer", n => { Issuer = n.GetStringValue(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "subject", n => { Subject = n.GetStringValue(); } },
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
            writer.WriteCollectionOfPrimitiveValues<string>("audiences", Audiences);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.FederatedIdentityExpression>("claimsMatchingExpression", ClaimsMatchingExpression);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("issuer", Issuer);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("subject", Subject);
        }
    }
}
#pragma warning restore CS0618
