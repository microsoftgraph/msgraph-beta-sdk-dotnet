using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class DeviceLogCollectionRequest : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The unique identifier</summary>
        public string Id { get; set; }
        /// <summary>The template type that is sent with the collection request. Possible values are: predefined.</summary>
        public DeviceLogCollectionTemplateType? TemplateType { get; set; }
        /// <summary>
        /// Instantiates a new deviceLogCollectionRequest and sets the default values.
        /// </summary>
        public DeviceLogCollectionRequest() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"id", (o,n) => { (o as DeviceLogCollectionRequest).Id = n.GetStringValue(); } },
                {"templateType", (o,n) => { (o as DeviceLogCollectionRequest).TemplateType = n.GetEnumValue<DeviceLogCollectionTemplateType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("id", Id);
            writer.WriteEnumValue<DeviceLogCollectionTemplateType>("templateType", TemplateType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
