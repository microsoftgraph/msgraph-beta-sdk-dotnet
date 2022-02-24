using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraphSdk.Models.Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.ServicePrincipals.Item.Synchronization.AcquireAccessToken {
    public class AcquireAccessTokenRequestBody : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public List<SynchronizationSecretKeyStringValuePair> Credentials { get; set; }
        /// <summary>
        /// Instantiates a new acquireAccessTokenRequestBody and sets the default values.
        /// </summary>
        public AcquireAccessTokenRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"credentials", (o,n) => { (o as AcquireAccessTokenRequestBody).Credentials = n.GetCollectionOfObjectValues<SynchronizationSecretKeyStringValuePair>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<SynchronizationSecretKeyStringValuePair>("credentials", Credentials);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
