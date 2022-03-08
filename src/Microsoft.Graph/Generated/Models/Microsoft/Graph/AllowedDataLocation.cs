using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the collection of allowedDataLocation entities.</summary>
    public class AllowedDataLocation : Entity, IParsable {
        public string AppId { get; set; }
        public string Domain { get; set; }
        public bool? IsDefault { get; set; }
        public string Location { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new AllowedDataLocation CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AllowedDataLocation();
        }
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
