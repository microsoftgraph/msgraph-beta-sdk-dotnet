using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class ParentLabelDetails : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The color that the user interface should display for the label, if configured.</summary>
        public string Color { get; set; }
        /// <summary>The admin-defined description for the label.</summary>
        public string Description { get; set; }
        /// <summary>The label ID is a globally unique identifier (GUID).</summary>
        public string Id { get; set; }
        /// <summary>Indicates whether the label is active or not. Active labels should be hidden or disabled in user interfaces.</summary>
        public bool? IsActive { get; set; }
        /// <summary>The plaintext name of the label.</summary>
        public string Name { get; set; }
        /// <summary>The parent property</summary>
        public ParentLabelDetails Parent { get; set; }
        /// <summary>The sensitivity value of the label, where lower is less sensitive.</summary>
        public int? Sensitivity { get; set; }
        /// <summary>The tooltip that should be displayed for the label in a user interface.</summary>
        public string Tooltip { get; set; }
        /// <summary>
        /// Instantiates a new parentLabelDetails and sets the default values.
        /// </summary>
        public ParentLabelDetails() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ParentLabelDetails CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ParentLabelDetails();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"color", n => { Color = n.GetStringValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"id", n => { Id = n.GetStringValue(); } },
                {"isActive", n => { IsActive = n.GetBoolValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"parent", n => { Parent = n.GetObjectValue<ParentLabelDetails>(ParentLabelDetails.CreateFromDiscriminatorValue); } },
                {"sensitivity", n => { Sensitivity = n.GetIntValue(); } },
                {"tooltip", n => { Tooltip = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("color", Color);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("id", Id);
            writer.WriteBoolValue("isActive", IsActive);
            writer.WriteStringValue("name", Name);
            writer.WriteObjectValue<ParentLabelDetails>("parent", Parent);
            writer.WriteIntValue("sensitivity", Sensitivity);
            writer.WriteStringValue("tooltip", Tooltip);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
