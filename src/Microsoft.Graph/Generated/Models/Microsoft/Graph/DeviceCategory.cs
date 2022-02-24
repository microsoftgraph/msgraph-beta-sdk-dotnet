using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class DeviceCategory : Entity, IParsable {
        /// <summary>Optional description for the device category.</summary>
        public string Description { get; set; }
        /// <summary>Display name for the device category.</summary>
        public string DisplayName { get; set; }
        /// <summary>Optional role scope tags for the device category.</summary>
        public List<string> RoleScopeTagIds { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"description", (o,n) => { (o as DeviceCategory).Description = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as DeviceCategory).DisplayName = n.GetStringValue(); } },
                {"roleScopeTagIds", (o,n) => { (o as DeviceCategory).RoleScopeTagIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
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
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfPrimitiveValues<string>("roleScopeTagIds", RoleScopeTagIds);
        }
    }
}
