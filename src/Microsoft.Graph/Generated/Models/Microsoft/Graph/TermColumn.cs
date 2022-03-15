using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public class TermColumn : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Specifies whether the column will allow more than one value.</summary>
        public bool? AllowMultipleValues { get; set; }
        /// <summary>Specifies whether to display the entire term path or only the term label.</summary>
        public bool? ShowFullyQualifiedName { get; set; }
        /// <summary>
        /// Instantiates a new termColumn and sets the default values.
        /// </summary>
        public TermColumn() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static TermColumn CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TermColumn();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"allowMultipleValues", (o,n) => { (o as TermColumn).AllowMultipleValues = n.GetBoolValue(); } },
                {"showFullyQualifiedName", (o,n) => { (o as TermColumn).ShowFullyQualifiedName = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("allowMultipleValues", AllowMultipleValues);
            writer.WriteBoolValue("showFullyQualifiedName", ShowFullyQualifiedName);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
