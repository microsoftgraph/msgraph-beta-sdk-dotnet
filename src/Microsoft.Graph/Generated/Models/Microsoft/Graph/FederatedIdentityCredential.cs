using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class FederatedIdentityCredential : Entity, IParsable {
        /// <summary>Lists the audiences that can appear in the external token. This field is mandatory, and defaults to 'api://AzureADTokenExchange'. It says what Microsoft identity platform should accept in the aud claim in the incoming token. This value represents Azure AD in your external identity provider and has no fixed value across identity providers - you may need to create a new application registration in your identity provider to serve as the audience of this token. Required.</summary>
        public List<string> Audiences { get; set; }
        /// <summary>The un-validated, user-provided description of the federated identity credential. Optional.</summary>
        public string Description { get; set; }
        /// <summary>The URL of the external identity provider and must match the issuer claim of the external token being exchanged. The combination of the values of issuer and subject must be unique on the app. Required.</summary>
        public string Issuer { get; set; }
        /// <summary>is the unique identifier for the federated identity credential, which has a character limit of 120 characters and must be URL friendly. It is immutable once created. Required. Not nullable. Supports $filter (eq).</summary>
        public string Name { get; set; }
        /// <summary>Required. The identifier of the external software workload within the external identity provider. Like the audience value, it has no fixed format, as each identity provider uses their own - sometimes a GUID, sometimes a colon delimited identifier, sometimes arbitrary strings. The value here must match the sub claim within the token presented to Azure AD. The combination of issuer and subject must be unique on the app. Supports $filter (eq).</summary>
        public string Subject { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"audiences", (o,n) => { (o as FederatedIdentityCredential).Audiences = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"description", (o,n) => { (o as FederatedIdentityCredential).Description = n.GetStringValue(); } },
                {"issuer", (o,n) => { (o as FederatedIdentityCredential).Issuer = n.GetStringValue(); } },
                {"name", (o,n) => { (o as FederatedIdentityCredential).Name = n.GetStringValue(); } },
                {"subject", (o,n) => { (o as FederatedIdentityCredential).Subject = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfPrimitiveValues<string>("audiences", Audiences);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("issuer", Issuer);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("subject", Subject);
        }
    }
}
