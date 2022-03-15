using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraphSdk.Models.Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Applications.Item.Synchronization.Jobs.ValidateCredentials {
    /// <summary>Provides operations to call the validateCredentials method.</summary>
    public class ValidateCredentialsRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public string ApplicationIdentifier { get; set; }
        public List<SynchronizationSecretKeyStringValuePair> Credentials { get; set; }
        public string TemplateId { get; set; }
        public bool? UseSavedCredentials { get; set; }
        /// <summary>
        /// Instantiates a new validateCredentialsRequestBody and sets the default values.
        /// </summary>
        public ValidateCredentialsRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ValidateCredentialsRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ValidateCredentialsRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"applicationIdentifier", (o,n) => { (o as ValidateCredentialsRequestBody).ApplicationIdentifier = n.GetStringValue(); } },
                {"credentials", (o,n) => { (o as ValidateCredentialsRequestBody).Credentials = n.GetCollectionOfObjectValues<SynchronizationSecretKeyStringValuePair>(SynchronizationSecretKeyStringValuePair.CreateFromDiscriminatorValue).ToList(); } },
                {"templateId", (o,n) => { (o as ValidateCredentialsRequestBody).TemplateId = n.GetStringValue(); } },
                {"useSavedCredentials", (o,n) => { (o as ValidateCredentialsRequestBody).UseSavedCredentials = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("applicationIdentifier", ApplicationIdentifier);
            writer.WriteCollectionOfObjectValues<SynchronizationSecretKeyStringValuePair>("credentials", Credentials);
            writer.WriteStringValue("templateId", TemplateId);
            writer.WriteBoolValue("useSavedCredentials", UseSavedCredentials);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
