using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to call the executeAction method.</summary>
    public class BulkManagedDeviceActionResult : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Failed devices</summary>
        public List<string> FailedDeviceIds { get; set; }
        /// <summary>Not found devices</summary>
        public List<string> NotFoundDeviceIds { get; set; }
        /// <summary>Not supported devices</summary>
        public List<string> NotSupportedDeviceIds { get; set; }
        /// <summary>Successful devices</summary>
        public List<string> SuccessfulDeviceIds { get; set; }
        /// <summary>
        /// Instantiates a new bulkManagedDeviceActionResult and sets the default values.
        /// </summary>
        public BulkManagedDeviceActionResult() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static BulkManagedDeviceActionResult CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new BulkManagedDeviceActionResult();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"failedDeviceIds", (o,n) => { (o as BulkManagedDeviceActionResult).FailedDeviceIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"notFoundDeviceIds", (o,n) => { (o as BulkManagedDeviceActionResult).NotFoundDeviceIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"notSupportedDeviceIds", (o,n) => { (o as BulkManagedDeviceActionResult).NotSupportedDeviceIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"successfulDeviceIds", (o,n) => { (o as BulkManagedDeviceActionResult).SuccessfulDeviceIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
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
