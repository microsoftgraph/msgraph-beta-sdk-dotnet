using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class DeviceHealthScriptParameter : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Whether Apply DefaultValue When Not Assigned</summary>
        public bool? ApplyDefaultValueWhenNotAssigned { get; set; }
        /// <summary>The description of the param</summary>
        public string Description { get; set; }
        /// <summary>Whether the param is required</summary>
        public bool? IsRequired { get; set; }
        /// <summary>The name of the param</summary>
        public string Name { get; set; }
        /// <summary>
        /// Instantiates a new deviceHealthScriptParameter and sets the default values.
        /// </summary>
        public DeviceHealthScriptParameter() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"applyDefaultValueWhenNotAssigned", (o,n) => { (o as DeviceHealthScriptParameter).ApplyDefaultValueWhenNotAssigned = n.GetBoolValue(); } },
                {"description", (o,n) => { (o as DeviceHealthScriptParameter).Description = n.GetStringValue(); } },
                {"isRequired", (o,n) => { (o as DeviceHealthScriptParameter).IsRequired = n.GetBoolValue(); } },
                {"name", (o,n) => { (o as DeviceHealthScriptParameter).Name = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("applyDefaultValueWhenNotAssigned", ApplyDefaultValueWhenNotAssigned);
            writer.WriteStringValue("description", Description);
            writer.WriteBoolValue("isRequired", IsRequired);
            writer.WriteStringValue("name", Name);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
