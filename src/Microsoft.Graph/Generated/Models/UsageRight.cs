using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class UsageRight : Entity, IParsable {
        /// <summary>Product id corresponding to the usage right.</summary>
        public string CatalogId { get; set; }
        /// <summary>Identifier of the service corresponding to the usage right.</summary>
        public string ServiceIdentifier { get; set; }
        /// <summary>The state of the usage right. Possible values are: active, inactive, warning, suspended.</summary>
        public UsageRightState? State { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new UsageRight CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UsageRight();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"catalogId", (o,n) => { (o as UsageRight).CatalogId = n.GetStringValue(); } },
                {"serviceIdentifier", (o,n) => { (o as UsageRight).ServiceIdentifier = n.GetStringValue(); } },
                {"state", (o,n) => { (o as UsageRight).State = n.GetEnumValue<UsageRightState>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("catalogId", CatalogId);
            writer.WriteStringValue("serviceIdentifier", ServiceIdentifier);
            writer.WriteEnumValue<UsageRightState>("state", State);
        }
    }
}
