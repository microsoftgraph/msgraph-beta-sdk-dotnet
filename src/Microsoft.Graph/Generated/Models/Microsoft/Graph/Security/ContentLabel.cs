using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph.Security {
    /// <summary>Provides operations to call the extractContentLabel method.</summary>
    public class ContentLabel : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public MicrosoftGraphSdk.Models.Microsoft.Graph.Security.AssignmentMethod? AssignmentMethod { get; set; }
        public DateTimeOffset? CreatedDateTime { get; set; }
        public string SensitivityLabelId { get; set; }
        /// <summary>
        /// Instantiates a new contentLabel and sets the default values.
        /// </summary>
        public ContentLabel() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ContentLabel CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ContentLabel();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"assignmentMethod", (o,n) => { (o as ContentLabel).AssignmentMethod = n.GetEnumValue<AssignmentMethod>(); } },
                {"createdDateTime", (o,n) => { (o as ContentLabel).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"sensitivityLabelId", (o,n) => { (o as ContentLabel).SensitivityLabelId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<AssignmentMethod>("assignmentMethod", AssignmentMethod);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("sensitivityLabelId", SensitivityLabelId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
