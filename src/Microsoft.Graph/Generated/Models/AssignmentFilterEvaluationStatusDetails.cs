using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>A class containing information about the payloads on which filter has been applied.</summary>
    public class AssignmentFilterEvaluationStatusDetails : Entity, IParsable {
        /// <summary>PayloadId on which filter has been applied.</summary>
        public string PayloadId {
            get { return BackingStore?.Get<string>("payloadId"); }
            set { BackingStore?.Set("payloadId", value); }
        }
        /// <summary>
        /// Instantiates a new assignmentFilterEvaluationStatusDetails and sets the default values.
        /// </summary>
        public AssignmentFilterEvaluationStatusDetails() : base() {
            OdataType = "#microsoft.graph.assignmentFilterEvaluationStatusDetails";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new AssignmentFilterEvaluationStatusDetails CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AssignmentFilterEvaluationStatusDetails();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"payloadId", n => { PayloadId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("payloadId", PayloadId);
        }
    }
}
