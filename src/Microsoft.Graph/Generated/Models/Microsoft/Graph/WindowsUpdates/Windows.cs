using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph.WindowsUpdates {
    public class Windows : Entity, IParsable {
        /// <summary>Entity that acts as a container for the functionality of the Windows Update for Business deployment service. Read-only.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.WindowsUpdates.Updates Updates { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Windows CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Windows();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"updates", (o,n) => { (o as Windows).Updates = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.WindowsUpdates.Updates>(MicrosoftGraphSdk.Models.Microsoft.Graph.WindowsUpdates.Updates.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.WindowsUpdates.Updates>("updates", Updates);
        }
    }
}
