using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraphSdk.Models.Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.ServicePrincipals.Item.Synchronization.Jobs.ValidateCredentials {
    public class ValidateCredentialsRequestBody : IParsable {
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
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"applicationIdentifier", (o,n) => { (o as ValidateCredentialsRequestBody).ApplicationIdentifier = n.GetStringValue(); } },
                {"credentials", (o,n) => { (o as ValidateCredentialsRequestBody).Credentials = n.GetCollectionOfObjectValues<SynchronizationSecretKeyStringValuePair>().ToList(); } },
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
