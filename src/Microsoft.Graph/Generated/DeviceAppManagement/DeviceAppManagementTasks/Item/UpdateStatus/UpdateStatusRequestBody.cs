using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraph.Models.Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.DeviceAppManagement.DeviceAppManagementTasks.Item.UpdateStatus {
    public class UpdateStatusRequestBody : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public string Note { get; set; }
        public DeviceAppManagementTaskStatus? Status { get; set; }
        /// <summary>
        /// Instantiates a new updateStatusRequestBody and sets the default values.
        /// </summary>
        public UpdateStatusRequestBody() {
            AdditionalData = new Dictionary<string, object>();
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
