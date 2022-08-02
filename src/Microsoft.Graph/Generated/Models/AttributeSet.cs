using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of activityStatistics entities.</summary>
    public class AttributeSet : Entity, IParsable {
        /// <summary>Description of the attribute set. Can be up to 128 characters long and include Unicode characters. Can be changed later.</summary>
        public string Description {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
        /// <summary>Maximum number of custom security attributes that can be defined in this attribute set. Default value is null. If not specified, the administrator can add up to the maximum of 500 active attributes per tenant. Can be changed later.</summary>
        public int? MaxAttributesPerSet {
            get { return BackingStore?.Get<int?>("maxAttributesPerSet"); }
            set { BackingStore?.Set("maxAttributesPerSet", value); }
        }
        /// <summary>
        /// Instantiates a new attributeSet and sets the default values.
        /// </summary>
        public AttributeSet() : base() {
            OdataType = "#microsoft.graph.attributeSet";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new AttributeSet CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AttributeSet();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"description", n => { Description = n.GetStringValue(); } },
                {"maxAttributesPerSet", n => { MaxAttributesPerSet = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("description", Description);
            writer.WriteIntValue("maxAttributesPerSet", MaxAttributesPerSet);
        }
    }
}
