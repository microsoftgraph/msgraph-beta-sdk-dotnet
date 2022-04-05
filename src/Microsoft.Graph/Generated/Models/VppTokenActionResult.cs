using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>The status of the action performed with an Apple Volume Purchase Program token.</summary>
    public class VppTokenActionResult : IAdditionalDataHolder, IParsable {
        /// <summary>Action name</summary>
        public string ActionName { get; set; }
        /// <summary>State of the action. Possible values are: none, pending, canceled, active, done, failed, notSupported.</summary>
        public Microsoft.Graph.Beta.Models.ActionState? ActionState { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Time the action state was last updated</summary>
        public DateTimeOffset? LastUpdatedDateTime { get; set; }
        /// <summary>Time the action was initiated</summary>
        public DateTimeOffset? StartDateTime { get; set; }
        /// <summary>
        /// Instantiates a new vppTokenActionResult and sets the default values.
        /// </summary>
        public VppTokenActionResult() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static VppTokenActionResult CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new VppTokenActionResult();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"actionName", (o,n) => { (o as VppTokenActionResult).ActionName = n.GetStringValue(); } },
                {"actionState", (o,n) => { (o as VppTokenActionResult).ActionState = n.GetEnumValue<ActionState>(); } },
                {"lastUpdatedDateTime", (o,n) => { (o as VppTokenActionResult).LastUpdatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"startDateTime", (o,n) => { (o as VppTokenActionResult).StartDateTime = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("actionName", ActionName);
            writer.WriteEnumValue<ActionState>("actionState", ActionState);
            writer.WriteDateTimeOffsetValue("lastUpdatedDateTime", LastUpdatedDateTime);
            writer.WriteDateTimeOffsetValue("startDateTime", StartDateTime);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
