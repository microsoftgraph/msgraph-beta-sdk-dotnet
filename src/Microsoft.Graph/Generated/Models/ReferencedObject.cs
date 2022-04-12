using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class ReferencedObject : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Name of the referenced object. Must match one of the objects in the directory definition.</summary>
        public string ReferencedObjectName { get; set; }
        /// <summary>Currently not supported. Name of the property in the referenced object, the value for which is used as the reference.</summary>
        public string ReferencedProperty { get; set; }
        /// <summary>
        /// Instantiates a new referencedObject and sets the default values.
        /// </summary>
        public ReferencedObject() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ReferencedObject CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ReferencedObject();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"referencedObjectName", n => { ReferencedObjectName = n.GetStringValue(); } },
                {"referencedProperty", n => { ReferencedProperty = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("referencedObjectName", ReferencedObjectName);
            writer.WriteStringValue("referencedProperty", ReferencedProperty);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
