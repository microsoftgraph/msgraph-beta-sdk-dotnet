using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph.ExternalConnectors {
    public class DisplayTemplate : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The text identifier for the display template; for example, contosoTickets.</summary>
        public string Id { get; set; }
        public Json Layout { get; set; }
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
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"id", (o,n) => { (o as DisplayTemplate).Id = n.GetStringValue(); } },
                {"layout", (o,n) => { (o as DisplayTemplate).Layout = n.GetObjectValue<Json>(); } },
                {"priority", (o,n) => { (o as DisplayTemplate).Priority = n.GetIntValue(); } },
                {"rules", (o,n) => { (o as DisplayTemplate).Rules = n.GetCollectionOfObjectValues<PropertyRule>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("id", Id);
            writer.WriteObjectValue<Json>("layout", Layout);
            writer.WriteIntValue("priority", Priority);
            writer.WriteCollectionOfObjectValues<PropertyRule>("rules", Rules);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
