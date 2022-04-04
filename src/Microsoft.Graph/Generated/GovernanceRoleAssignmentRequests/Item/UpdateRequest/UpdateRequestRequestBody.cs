using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraphSdk.Models.Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.GovernanceRoleAssignmentRequests.Item.UpdateRequest {
    /// <summary>Provides operations to call the updateRequest method.</summary>
    public class UpdateRequestRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The assignmentState property</summary>
        public string AssignmentState { get; set; }
        /// <summary>The decision property</summary>
        public string Decision { get; set; }
        /// <summary>The reason property</summary>
        public string Reason { get; set; }
        /// <summary>The schedule property</summary>
        public GovernanceSchedule Schedule { get; set; }
        /// <summary>
        /// Instantiates a new updateRequestRequestBody and sets the default values.
        /// </summary>
        public UpdateRequestRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static UpdateRequestRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UpdateRequestRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"assignmentState", (o,n) => { (o as UpdateRequestRequestBody).AssignmentState = n.GetStringValue(); } },
                {"decision", (o,n) => { (o as UpdateRequestRequestBody).Decision = n.GetStringValue(); } },
                {"reason", (o,n) => { (o as UpdateRequestRequestBody).Reason = n.GetStringValue(); } },
                {"schedule", (o,n) => { (o as UpdateRequestRequestBody).Schedule = n.GetObjectValue<GovernanceSchedule>(GovernanceSchedule.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("assignmentState", AssignmentState);
            writer.WriteStringValue("decision", Decision);
            writer.WriteStringValue("reason", Reason);
            writer.WriteObjectValue<GovernanceSchedule>("schedule", Schedule);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
