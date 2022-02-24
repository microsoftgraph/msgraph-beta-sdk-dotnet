using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class AllowedDataLocation : Entity, IParsable {
        public string AppId { get; set; }
        public string Domain { get; set; }
        public bool? IsDefault { get; set; }
        public string Location { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"appId", (o,n) => { (o as AllowedDataLocation).AppId = n.GetStringValue(); } },
                {"domain", (o,n) => { (o as AllowedDataLocation).Domain = n.GetStringValue(); } },
                {"isDefault", (o,n) => { (o as AllowedDataLocation).IsDefault = n.GetBoolValue(); } },
                {"location", (o,n) => { (o as AllowedDataLocation).Location = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("appId", AppId);
            writer.WriteStringValue("domain", Domain);
            writer.WriteBoolValue("isDefault", IsDefault);
            writer.WriteStringValue("location", Location);
        }
    }
}
