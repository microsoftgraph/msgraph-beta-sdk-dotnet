using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraphSdk.Models.Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.ServicePrincipals.Item.UpdatePasswordSingleSignOnCredentials {
    /// <summary>Provides operations to call the updatePasswordSingleSignOnCredentials method.</summary>
    public class UpdatePasswordSingleSignOnCredentialsRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The credentials property</summary>
        public List<Credential> Credentials { get; set; }
        /// <summary>The id property</summary>
        public string Id { get; set; }
        /// <summary>
        /// Instantiates a new updatePasswordSingleSignOnCredentialsRequestBody and sets the default values.
        /// </summary>
        public UpdatePasswordSingleSignOnCredentialsRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static UpdatePasswordSingleSignOnCredentialsRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UpdatePasswordSingleSignOnCredentialsRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"credentials", (o,n) => { (o as UpdatePasswordSingleSignOnCredentialsRequestBody).Credentials = n.GetCollectionOfObjectValues<Credential>(Credential.CreateFromDiscriminatorValue).ToList(); } },
                {"id", (o,n) => { (o as UpdatePasswordSingleSignOnCredentialsRequestBody).Id = n.GetStringValue(); } },
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
