using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.ExternalConnectors {
    public class DisplayTemplate : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The text identifier for the display template; for example, contosoTickets.</summary>
        public string Id { get; set; }
        /// <summary>The layout property</summary>
        public Microsoft.Graph.Beta.Models.Json Layout { get; set; }
        /// <summary>Defines the priority of a display template. A display template with priority 1 is evaluated before a template with priority 4. Gaps in priority values are supported.</summary>
        public int? Priority { get; set; }
        /// <summary>Specifies additional rules for selecting this display template based on the item schema. Optional.</summary>
        public List<PropertyRule> Rules { get; set; }
        /// <summary>
        /// Instantiates a new displayTemplate and sets the default values.
        /// </summary>
        public DisplayTemplate() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static DisplayTemplate CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DisplayTemplate();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"id", n => { Id = n.GetStringValue(); } },
                {"layout", n => { Layout = n.GetObjectValue<Microsoft.Graph.Beta.Models.Json>(Microsoft.Graph.Beta.Models.Json.CreateFromDiscriminatorValue); } },
                {"priority", n => { Priority = n.GetIntValue(); } },
                {"rules", n => { Rules = n.GetCollectionOfObjectValues<PropertyRule>(PropertyRule.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("id", Id);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Json>("layout", Layout);
            writer.WriteIntValue("priority", Priority);
            writer.WriteCollectionOfObjectValues<PropertyRule>("rules", Rules);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
