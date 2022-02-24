using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraphSdk.Models.Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Applications.Item.Synchronization.Jobs.Item.ProvisionOnDemand {
    public class StringKeyStringValuePairRequestBody : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public List<SynchronizationJobApplicationParameters> Parameters { get; set; }
        /// <summary>
        /// Instantiates a new StringKeyStringValuePairRequestBody and sets the default values.
        /// </summary>
        public StringKeyStringValuePairRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"parameters", (o,n) => { (o as StringKeyStringValuePairRequestBody).Parameters = n.GetCollectionOfObjectValues<SynchronizationJobApplicationParameters>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<SynchronizationJobApplicationParameters>("parameters", Parameters);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
