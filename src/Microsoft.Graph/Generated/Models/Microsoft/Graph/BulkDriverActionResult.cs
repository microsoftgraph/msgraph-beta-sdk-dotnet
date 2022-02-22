using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class BulkDriverActionResult : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>List of driver Ids where the action is failed.</summary>
        public List<string> FailedDriverIds { get; set; }
        /// <summary>List of driver Ids that are not found.</summary>
        public List<string> NotFoundDriverIds { get; set; }
        /// <summary>List of driver Ids where the action is successful.</summary>
        public List<string> SuccessfulDriverIds { get; set; }
        /// <summary>
        /// Instantiates a new bulkDriverActionResult and sets the default values.
        /// </summary>
        public BulkDriverActionResult() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"failedDriverIds", (o,n) => { (o as BulkDriverActionResult).FailedDriverIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"notFoundDriverIds", (o,n) => { (o as BulkDriverActionResult).NotFoundDriverIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"successfulDriverIds", (o,n) => { (o as BulkDriverActionResult).SuccessfulDriverIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("failedDriverIds", FailedDriverIds);
            writer.WriteCollectionOfPrimitiveValues<string>("notFoundDriverIds", NotFoundDriverIds);
            writer.WriteCollectionOfPrimitiveValues<string>("successfulDriverIds", SuccessfulDriverIds);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
