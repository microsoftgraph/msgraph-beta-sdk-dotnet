using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class SensitivityLabelAssignment : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The assignmentMethod property</summary>
        public SensitivityLabelAssignmentMethod? AssignmentMethod { get; set; }
        /// <summary>The sensitivityLabelId property</summary>
        public string SensitivityLabelId { get; set; }
        /// <summary>The tenantId property</summary>
        public string TenantId { get; set; }
        /// <summary>
        /// Instantiates a new sensitivityLabelAssignment and sets the default values.
        /// </summary>
        public SensitivityLabelAssignment() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static SensitivityLabelAssignment CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SensitivityLabelAssignment();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"assignmentMethod", (o,n) => { (o as SensitivityLabelAssignment).AssignmentMethod = n.GetEnumValue<SensitivityLabelAssignmentMethod>(); } },
                {"sensitivityLabelId", (o,n) => { (o as SensitivityLabelAssignment).SensitivityLabelId = n.GetStringValue(); } },
                {"tenantId", (o,n) => { (o as SensitivityLabelAssignment).TenantId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<SensitivityLabelAssignmentMethod>("assignmentMethod", AssignmentMethod);
            writer.WriteStringValue("sensitivityLabelId", SensitivityLabelId);
            writer.WriteStringValue("tenantId", TenantId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
