using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to call the extractLabel method.</summary>
    public class InformationProtectionContentLabel : IParsable, IAdditionalDataHolder {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Possible values are: standard, privileged, auto.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.AssignmentMethod? AssignmentMethod { get; set; }
        /// <summary>The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? CreationDateTime { get; set; }
        /// <summary>Details on the label that is currently applied to the file.</summary>
        public LabelDetails Label { get; set; }
        /// <summary>
        /// Instantiates a new informationProtectionContentLabel and sets the default values.
        /// </summary>
        public InformationProtectionContentLabel() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static InformationProtectionContentLabel CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new InformationProtectionContentLabel();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"assignmentMethod", (o,n) => { (o as InformationProtectionContentLabel).AssignmentMethod = n.GetEnumValue<AssignmentMethod>(); } },
                {"creationDateTime", (o,n) => { (o as InformationProtectionContentLabel).CreationDateTime = n.GetDateTimeOffsetValue(); } },
                {"label", (o,n) => { (o as InformationProtectionContentLabel).Label = n.GetObjectValue<LabelDetails>(LabelDetails.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<AssignmentMethod>("assignmentMethod", AssignmentMethod);
            writer.WriteDateTimeOffsetValue("creationDateTime", CreationDateTime);
            writer.WriteObjectValue<LabelDetails>("label", Label);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
