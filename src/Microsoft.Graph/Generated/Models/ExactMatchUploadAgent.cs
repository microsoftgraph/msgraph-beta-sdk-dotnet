using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class ExactMatchUploadAgent : Entity, IParsable {
        /// <summary>The creationDateTime property</summary>
        public DateTimeOffset? CreationDateTime { get; set; }
        /// <summary>The description property</summary>
        public string Description { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ExactMatchUploadAgent CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ExactMatchUploadAgent();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"creationDateTime", (o,n) => { (o as ExactMatchUploadAgent).CreationDateTime = n.GetDateTimeOffsetValue(); } },
                {"description", (o,n) => { (o as ExactMatchUploadAgent).Description = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("creationDateTime", CreationDateTime);
            writer.WriteStringValue("description", Description);
        }
    }
}
