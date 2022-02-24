using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class DeleteAction : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The name of the item that was deleted.</summary>
        public string Name { get; set; }
        /// <summary>File or Folder, depending on the type of the deleted item.</summary>
        public string ObjectType { get; set; }
        /// <summary>
        /// Instantiates a new deleteAction and sets the default values.
        /// </summary>
        public DeleteAction() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"name", (o,n) => { (o as DeleteAction).Name = n.GetStringValue(); } },
                {"objectType", (o,n) => { (o as DeleteAction).ObjectType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("objectType", ObjectType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
