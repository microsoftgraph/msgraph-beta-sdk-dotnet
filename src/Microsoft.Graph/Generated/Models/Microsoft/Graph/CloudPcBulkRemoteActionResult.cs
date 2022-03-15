using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to call the bulkRestoreCloudPc method.</summary>
    public class CloudPcBulkRemoteActionResult : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>A list of all the Intune managed device IDs that completed the bulk action with a failure.</summary>
        public List<string> FailedDeviceIds { get; set; }
        /// <summary>A list of all the Intune managed device IDs that were not found when the bulk action was attempted.</summary>
        public List<string> NotFoundDeviceIds { get; set; }
        /// <summary>A list of all the Intune managed device IDs that were identified as unsupported for the bulk action.</summary>
        public List<string> NotSupportedDeviceIds { get; set; }
        /// <summary>A list of all the Intune managed device IDs that completed the bulk action successfully.</summary>
        public List<string> SuccessfulDeviceIds { get; set; }
        /// <summary>
        /// Instantiates a new cloudPcBulkRemoteActionResult and sets the default values.
        /// </summary>
        public CloudPcBulkRemoteActionResult() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static CloudPcBulkRemoteActionResult CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CloudPcBulkRemoteActionResult();
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
