using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.RoleManagement.DeviceManagement.ResourceNamespaces.Item.ImportResourceActions {
    public class ImportResourceActionsRequestBody : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public string Format { get; set; }
        public bool? OverwriteResourceNamespace { get; set; }
        public string Value { get; set; }
        /// <summary>
        /// Instantiates a new importResourceActionsRequestBody and sets the default values.
        /// </summary>
        public ImportResourceActionsRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"format", (o,n) => { (o as ImportResourceActionsRequestBody).Format = n.GetStringValue(); } },
                {"overwriteResourceNamespace", (o,n) => { (o as ImportResourceActionsRequestBody).OverwriteResourceNamespace = n.GetBoolValue(); } },
                {"value", (o,n) => { (o as ImportResourceActionsRequestBody).Value = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("format", Format);
            writer.WriteBoolValue("overwriteResourceNamespace", OverwriteResourceNamespace);
            writer.WriteStringValue("value", Value);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
