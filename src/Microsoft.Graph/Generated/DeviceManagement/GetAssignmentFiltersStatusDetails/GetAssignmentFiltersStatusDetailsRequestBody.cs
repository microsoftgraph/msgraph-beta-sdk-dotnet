using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.DeviceManagement.GetAssignmentFiltersStatusDetails {
    /// <summary>Provides operations to call the getAssignmentFiltersStatusDetails method.</summary>
    public class GetAssignmentFiltersStatusDetailsRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The assignmentFilterIds property</summary>
        public List<string> AssignmentFilterIds { get; set; }
        /// <summary>The managedDeviceId property</summary>
        public string ManagedDeviceId { get; set; }
        /// <summary>The payloadId property</summary>
        public string PayloadId { get; set; }
        /// <summary>The skip property</summary>
        public int? Skip { get; set; }
        /// <summary>The top property</summary>
        public int? Top { get; set; }
        /// <summary>The userId property</summary>
        public string UserId { get; set; }
        /// <summary>
        /// Instantiates a new getAssignmentFiltersStatusDetailsRequestBody and sets the default values.
        /// </summary>
        public GetAssignmentFiltersStatusDetailsRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static GetAssignmentFiltersStatusDetailsRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new GetAssignmentFiltersStatusDetailsRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"assignmentFilterIds", n => { AssignmentFilterIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"managedDeviceId", n => { ManagedDeviceId = n.GetStringValue(); } },
                {"payloadId", n => { PayloadId = n.GetStringValue(); } },
                {"skip", n => { Skip = n.GetIntValue(); } },
                {"top", n => { Top = n.GetIntValue(); } },
                {"userId", n => { UserId = n.GetStringValue(); } },
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
