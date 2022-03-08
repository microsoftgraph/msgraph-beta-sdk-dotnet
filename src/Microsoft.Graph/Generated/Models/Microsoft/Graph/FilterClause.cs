using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the collection of application entities.</summary>
    public class FilterClause : IParsable, IAdditionalDataHolder {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Name of the operator to be applied to the source and target operands. Must be one of the supported operators. Supported operators can be discovered.</summary>
        public string OperatorName { get; set; }
        /// <summary>Name of source operand (the operand being tested). The source operand name must match one of the attribute names on the source object.</summary>
        public string SourceOperandName { get; set; }
        /// <summary>Values that the source operand will be tested against.</summary>
        public FilterOperand TargetOperand { get; set; }
        /// <summary>
        /// Instantiates a new filterClause and sets the default values.
        /// </summary>
        public FilterClause() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static FilterClause CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new FilterClause();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"operatorName", (o,n) => { (o as FilterClause).OperatorName = n.GetStringValue(); } },
                {"sourceOperandName", (o,n) => { (o as FilterClause).SourceOperandName = n.GetStringValue(); } },
                {"targetOperand", (o,n) => { (o as FilterClause).TargetOperand = n.GetObjectValue<FilterOperand>(FilterOperand.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("operatorName", OperatorName);
            writer.WriteStringValue("sourceOperandName", SourceOperandName);
            writer.WriteObjectValue<FilterOperand>("targetOperand", TargetOperand);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
