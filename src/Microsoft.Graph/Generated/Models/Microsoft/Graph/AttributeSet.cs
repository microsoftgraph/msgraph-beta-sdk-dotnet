using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class AttributeSet : Entity, IParsable {
        /// <summary>Description of the attribute set. Can be up to 128 characters long and include Unicode characters. Can be changed later.</summary>
        public string Description { get; set; }
        /// <summary>Maximum number of custom security attributes that can be defined in this attribute set. Default value is null. If not specified, the administrator can add up to the maximum of 500 active attributes per tenant. Can be changed later.</summary>
        public int? MaxAttributesPerSet { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"description", (o,n) => { (o as AttributeSet).Description = n.GetStringValue(); } },
                {"maxAttributesPerSet", (o,n) => { (o as AttributeSet).MaxAttributesPerSet = n.GetIntValue(); } },
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
