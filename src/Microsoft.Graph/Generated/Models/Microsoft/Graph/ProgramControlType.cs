using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the collection of programControlType entities.</summary>
    public class ProgramControlType : Entity, IParsable {
        public string ControlTypeGroupId { get; set; }
        /// <summary>The name of the program control type</summary>
        public string DisplayName { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ProgramControlType CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ProgramControlType();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"controlTypeGroupId", (o,n) => { (o as ProgramControlType).ControlTypeGroupId = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as ProgramControlType).DisplayName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("controlTypeGroupId", ControlTypeGroupId);
            writer.WriteStringValue("displayName", DisplayName);
        }
    }
}
