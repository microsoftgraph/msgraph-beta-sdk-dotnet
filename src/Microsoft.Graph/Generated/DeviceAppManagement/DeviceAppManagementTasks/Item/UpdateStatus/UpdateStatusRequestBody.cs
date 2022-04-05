using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.DeviceAppManagement.DeviceAppManagementTasks.Item.UpdateStatus {
    /// <summary>Provides operations to call the updateStatus method.</summary>
    public class UpdateStatusRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The note property</summary>
        public string Note { get; set; }
        /// <summary>The status property</summary>
        public DeviceAppManagementTaskStatus? Status { get; set; }
        /// <summary>
        /// Instantiates a new updateStatusRequestBody and sets the default values.
        /// </summary>
        public UpdateStatusRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static UpdateStatusRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UpdateStatusRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"note", (o,n) => { (o as UpdateStatusRequestBody).Note = n.GetStringValue(); } },
                {"status", (o,n) => { (o as UpdateStatusRequestBody).Status = n.GetEnumValue<DeviceAppManagementTaskStatus>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("note", Note);
            writer.WriteEnumValue<DeviceAppManagementTaskStatus>("status", Status);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
