using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.ServicePrincipals.Item.CreatePasswordSingleSignOnCredentials {
    /// <summary>Provides operations to call the createPasswordSingleSignOnCredentials method.</summary>
    public class CreatePasswordSingleSignOnCredentialsRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The credentials property</summary>
        public List<Credential> Credentials { get; set; }
        /// <summary>The id property</summary>
        public string Id { get; set; }
        /// <summary>
        /// Instantiates a new createPasswordSingleSignOnCredentialsRequestBody and sets the default values.
        /// </summary>
        public CreatePasswordSingleSignOnCredentialsRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static CreatePasswordSingleSignOnCredentialsRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CreatePasswordSingleSignOnCredentialsRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"credentials", n => { Credentials = n.GetCollectionOfObjectValues<Credential>(Credential.CreateFromDiscriminatorValue).ToList(); } },
                {"id", n => { Id = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<Credential>("credentials", Credentials);
            writer.WriteStringValue("id", Id);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
