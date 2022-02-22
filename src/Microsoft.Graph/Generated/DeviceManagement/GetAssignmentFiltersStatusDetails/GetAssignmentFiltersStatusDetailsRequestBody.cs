using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.DeviceManagement.GetAssignmentFiltersStatusDetails {
    public class GetAssignmentFiltersStatusDetailsRequestBody : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public List<string> AssignmentFilterIds { get; set; }
        public string ManagedDeviceId { get; set; }
        public string PayloadId { get; set; }
        public int? Skip { get; set; }
        public int? Top { get; set; }
        public string UserId { get; set; }
        /// <summary>
        /// Instantiates a new getAssignmentFiltersStatusDetailsRequestBody and sets the default values.
        /// </summary>
        public GetAssignmentFiltersStatusDetailsRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"assignmentFilterIds", (o,n) => { (o as GetAssignmentFiltersStatusDetailsRequestBody).AssignmentFilterIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"managedDeviceId", (o,n) => { (o as GetAssignmentFiltersStatusDetailsRequestBody).ManagedDeviceId = n.GetStringValue(); } },
                {"payloadId", (o,n) => { (o as GetAssignmentFiltersStatusDetailsRequestBody).PayloadId = n.GetStringValue(); } },
                {"skip", (o,n) => { (o as GetAssignmentFiltersStatusDetailsRequestBody).Skip = n.GetIntValue(); } },
                {"top", (o,n) => { (o as GetAssignmentFiltersStatusDetailsRequestBody).Top = n.GetIntValue(); } },
                {"userId", (o,n) => { (o as GetAssignmentFiltersStatusDetailsRequestBody).UserId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("assignmentFilterIds", AssignmentFilterIds);
            writer.WriteStringValue("managedDeviceId", ManagedDeviceId);
            writer.WriteStringValue("payloadId", PayloadId);
            writer.WriteIntValue("skip", Skip);
            writer.WriteIntValue("top", Top);
            writer.WriteStringValue("userId", UserId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
