using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class CloudPcBulkRemoteActionResult : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public List<string> FailedDeviceIds { get; set; }
        public List<string> NotFoundDeviceIds { get; set; }
        public List<string> NotSupportedDeviceIds { get; set; }
        public List<string> SuccessfulDeviceIds { get; set; }
        /// <summary>
        /// Instantiates a new cloudPcBulkRemoteActionResult and sets the default values.
        /// </summary>
        public CloudPcBulkRemoteActionResult() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"failedDeviceIds", (o,n) => { (o as CloudPcBulkRemoteActionResult).FailedDeviceIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"notFoundDeviceIds", (o,n) => { (o as CloudPcBulkRemoteActionResult).NotFoundDeviceIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"notSupportedDeviceIds", (o,n) => { (o as CloudPcBulkRemoteActionResult).NotSupportedDeviceIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"successfulDeviceIds", (o,n) => { (o as CloudPcBulkRemoteActionResult).SuccessfulDeviceIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("failedDeviceIds", FailedDeviceIds);
            writer.WriteCollectionOfPrimitiveValues<string>("notFoundDeviceIds", NotFoundDeviceIds);
            writer.WriteCollectionOfPrimitiveValues<string>("notSupportedDeviceIds", NotSupportedDeviceIds);
            writer.WriteCollectionOfPrimitiveValues<string>("successfulDeviceIds", SuccessfulDeviceIds);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
